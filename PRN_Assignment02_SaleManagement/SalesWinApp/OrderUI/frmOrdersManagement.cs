using AutoMapper;
using BusinessObject;
using DataAccess.Repository.OrderRepo;
using SalesWinApp.MemberUI;
using SalesWinApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesWinApp.ProductUI;
using DataAccess.Repository.ProductRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.CartRepo;
using System.Reflection;
using System.Diagnostics;

namespace SalesWinApp.OrderUI
{
    public partial class frmOrdersManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();
        private IEnumerable<OrderPresenter> orderPresenters = new List<OrderPresenter>();
        //private IEnumerable<AdminOrderPresenter> adminOrderPresenters = new List<AdminOrderPresenter>();

        BindingSource source;
        private IMapper mapper;
        public frmOrdersManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }
        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            if (LoginMember.Fullname.Equals("Admin"))
            {
                ToolStripMenuItem menuManagement = new ToolStripMenuItem("&Management");
                ToolStripMenuItem menuMemberMng = new ToolStripMenuItem("&Member Management");
                ToolStripMenuItem menuProductMng = new ToolStripMenuItem("&Product Management");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                menuManagement,
                menuExit
                });

                // Menu Management
                menuManagement.DropDownItems.AddRange(new ToolStripItem[]
                {
                menuMemberMng,
                menuProductMng
                });

                menuMemberMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.M);
                menuProductMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.O);

                menuMemberMng.Click += new EventHandler(menuMemberMng_Click);
                menuProductMng.Click += new EventHandler(menuProductMng_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }
            else
            {
                ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
                ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                    menuOrder,
                    menuProfile,
                    menuExit
                });
                menuOrder.Click += new EventHandler(menuOrder_Click);
                menuProfile.Click += new EventHandler(menuProfile_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }
        }

        private void menuMemberMng_Click(object sender, EventArgs e)
        {
            frmMembersManagement frmMemberManagement = null;
            frmMemberManagement = new frmMembersManagement
            {
                LoginMember = this.LoginMember
            };
            frmMemberManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberManagement.Show();
        }
        private void menuProductMng_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }
        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }
        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Member Details",
                MemberInfo = LoginMember,
                InsertOrUpdate = false,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmMemberDetails.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberDetails.Show();
        }

        private void LoadOrder()
        {
            source = new BindingSource();
            source.DataSource = orderPresenters;

            txtOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();
            txtMemberName.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", source, "OrderID");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtOrderTotal.DataBindings.Add("Text", source, "OrderTotal");
            txtMemberName.DataBindings.Add("Text", source, "MemberName");

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;
        }
        private void frmOrdersManagement_Load(object sender, EventArgs e)
        {
            try
            {
                CreateMainMenu();

                startDate.Value = DateTime.Today;
                startDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "dd/MM/yyyy";

                endDate.Value = DateTime.Today;
                endDate.Format = DateTimePickerFormat.Custom;
                endDate.CustomFormat = "dd/MM/yyyy";

                IEnumerable<Order> orders = orderRepository.GetOrders(LoginMember.MemberId);
                if (orders.Any())
                {
                    orderPresenters = orders.Select(or => mapper.Map<Order, OrderPresenter>(or));
                    LoadOrder();

                    DateTime minDate = orderPresenters.Min(order => order.OrderDate);
                    DateTime maxDate = orderPresenters.Max(order => order.OrderDate);

                    startDate.Value = minDate;
                    endDate.Value = maxDate;
                } else
                {
                    MessageBox.Show("No order found!", "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Orders List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private OrderPresenter GetOrder()
        {
            OrderPresenter orderPresenter = null;
            try
            {
                orderPresenter = new OrderPresenter()
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    MemberName = txtMemberName.Text,
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    OrderTotal = decimal.Parse(txtOrderTotal.Text)
                };
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderPresenter;
        }
        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                OrderPresenter = GetOrder(),
                LoginMember = this.LoginMember
            };
            frmOrderDetails.ShowDialog();
            LoadOrder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime searchStartDate = startDate.Value;
                DateTime searchEndDate = endDate.Value;
                if (DateTime.Compare(searchStartDate, searchEndDate) > 0)
                {
                    DateTime temp = searchStartDate;
                    searchStartDate = searchEndDate;
                    searchEndDate = temp;
                }
                IEnumerable<Order> orders = orderRepository.GetOrders(LoginMember.MemberId, searchStartDate, searchEndDate);
                if (orders.Any())
                {
                    orderPresenters = orders.Select(or => mapper.Map<Order, OrderPresenter>(or));
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("No order found!", "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable CreateDataTable<T>()
        {
            DataTable dt = new DataTable();

            PropertyInfo[] piT = typeof(T).GetProperties();

            foreach (PropertyInfo pi in piT)
            {
                Type propertyType = null;
                if (pi.PropertyType.IsGenericType)
                {
                    propertyType = pi.PropertyType.GetGenericArguments()[0];
                } else
                {
                    propertyType = pi.PropertyType;
                }
                DataColumn dc = new DataColumn(pi.Name, propertyType);
                if (pi.CanRead)
                {
                    dt.Columns.Add(dc);
                }
            }
            return dt;
        }
        private DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            var table = CreateDataTable<T>();
            PropertyInfo[] piT = typeof(T).GetProperties();

            foreach (var item in items)
            {
                var dr = table.NewRow();

                for (int property = 0; property < table.Columns.Count; property++)
                {
                    if (piT[property].CanRead)
                    {
                        dr[property] = piT[property].GetValue(item, null);
                    }
                }
                table.Rows.Add(dr);
            }
            return table;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var tableOfData = ToDataTable(orderPresenters);
                DataSet ds = new DataSet();
                ds.Tables.Add(tableOfData);
                ExcelLibrary.DataSetHelper.CreateWorkbook("Report.xls", ds);

                string path = Environment.CurrentDirectory + "\\";
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(path + "Report.xls")
                {
                    UseShellExecute = true
                };
                p.Start();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Export data", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
            
    }
}

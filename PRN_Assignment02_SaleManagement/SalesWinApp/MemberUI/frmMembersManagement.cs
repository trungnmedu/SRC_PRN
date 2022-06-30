using AutoMapper;
using BusinessObject;
using DataAccess.Repository;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderRepo;
using DataAccess.Repository.OrderDetailRepo;
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
using DataAccess.Repository.CartRepo;
using SalesWinApp.OrderUI;

namespace SalesWinApp.MemberUI
{
    public partial class frmMembersManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        public ICartRepository CartRepository { get; set; }

        BindingSource source;
        BindingSource citySource;
        BindingSource countrySource;

        bool search = false;
        bool filter = false;
        IEnumerable<Member> dataSource;
        IEnumerable<Member> searchResult;
        IEnumerable<Member> filterResult;
        
        IEnumerable<string> countryList;
        Dictionary<string, IEnumerable<string>> cityDictionary;
        private IMapper mapper;
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public frmMembersManagement()
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

            ToolStripMenuItem menuManagement = new ToolStripMenuItem("&Management");
            ToolStripMenuItem menuProductMng = new ToolStripMenuItem("&Product Management");
            ToolStripMenuItem menuOrderMng = new ToolStripMenuItem("&Order Management");
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
                menuProductMng,
                menuOrderMng
            });

            menuProductMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.P);
            menuOrderMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.O);

            menuProductMng.Click += new EventHandler(menuProductMng_Click);
            menuOrderMng.Click += new EventHandler(menuOrderMng_Click);
            menuExit.Click += new EventHandler(menuExit_Click);
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtMemberID.Enabled = false;
            txtMemberName.Enabled = false;
            txtEmail.Enabled = false;
            txtCompanyName.Enabled = false;
            txtPassword.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            btnNew.Enabled = false;
            dgvMemberList.Enabled = false;
            btnLoad.Enabled = true;
            grSearch.Enabled = false;
            grFilter.Enabled = false;
            CreateMainMenu();
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOrderMng_Click(object sender, EventArgs e)
        {
            frmOrdersManagement frmOrdersManagement = new frmOrdersManagement
            {
                LoginMember = this.LoginMember,
                CartRepository = this.CartRepository,
                MemberRepository = this.memberRepository
            };
            frmOrdersManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmOrdersManagement.Show();
        }

        private void menuProductMng_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.memberRepository,
                CartRepository = this.CartRepository
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }

        private MemberPresenter GetMemberInfo()
        {
            MemberPresenter memberPresenter = null;
            try
            {
                memberPresenter = new MemberPresenter
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Fullname = txtMemberName.Text,
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return memberPresenter;
        }
        private void LoadMemberList()
        {
            try
            {
                IEnumerable<MemberPresenter> presentSource;

                if (filter)
                {
                    presentSource = filterResult.Select
                        (
                            mem => mapper.Map<Member, MemberPresenter>(mem)
                        );
                } else
                {
                    presentSource = dataSource.Select
                        (
                            mem => mapper.Map<Member, MemberPresenter>(mem)
                        );
                }

                source = new BindingSource();
                source.DataSource = presentSource;
                if (!filter)
                {
                    countryList = from member in dataSource
                                  where !string.IsNullOrEmpty(member.Country.Trim())
                                  orderby member.Country ascending
                                  select member.Country;
                    countryList = countryList.Distinct();
                    cityDictionary = new Dictionary<string, IEnumerable<string>>();
                    foreach (var country in countryList)
                    {
                        var cityList = from member in dataSource
                                       where !string.IsNullOrEmpty(member.City.Trim()) && (member.Country.Equals(country))
                                       orderby member.City ascending
                                       select member.City;
                        cityList = cityList.Prepend("All");
                        cityList = cityList.Distinct();

                        cityDictionary.Add(country, cityList);
                    }

                    countryList = countryList.Prepend("All");

                    if (dataSource.Count() > 0)
                    {
                        countrySource = new BindingSource();
                        countrySource.DataSource = countryList;
                        cboCountry.DataSource = null;
                        cboCountry.DataSource = countrySource;

                        cboSearchCity.DataBindings.Clear();
                        //citySource = new BindingSource();
                        //citySource.DataSource = cityList;
                        //cboSearchCity.DataSource = null;
                        //cboSearchCity.DataSource = citySource;
                    }
                }

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtMemberName.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (dataSource.Count() > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void LoadFullList()
        {
            search = false;
            filter = false;
            var members = memberRepository.GetMembersList();
            var memberList = from member in members
                             orderby member.Fullname descending
                             select member;
            dataSource = memberList;
            searchResult = memberList;
            filterResult = memberList;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            dgvMemberList.Enabled = true;
            btnLoad.Enabled = true;
            grSearch.Enabled = true;
            grFilter.Enabled = true;
            LoadFullList();
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                MemberRepository = this.memberRepository,
                InsertOrUpdate = true,
                Text = "Add new member"
            };

            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberPresenter memberPresenter = GetMemberInfo();
                Member member = mapper.Map<Member>(memberPresenter);
                if (member.MemberId == LoginMember.MemberId)
                {
                    MessageBox.Show("You can't delete yourself!!", "Delete member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show($"Do you really want to delete the member: \n" +
                    $"Member ID: {member.MemberId}\n" +
                    $"Member Name: {member.Fullname}\n" +
                    $"Email: {member.Email}\n" +
                    $"City: {member.City}\n" +
                    $"Country: {member.Country}", "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IEnumerable<Order> orders = orderRepository.GetOrders(member.MemberId);
                        foreach (var order in orders)
                        {
                            orderDetailRepository.DeleteOrderDetails(order.OrderId);
                            orderRepository.DeleteOrder(order.OrderId);
                        }
                        memberRepository.DeleteMember(member.MemberId);
                        search = false;
                        LoadFullList();
                        LoadMemberList();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberPresenter memberPresenter = GetMemberInfo();

            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                MemberRepository = this.memberRepository,
                InsertOrUpdate = false,
                MemberInfo = memberPresenter,
                Text = "Update member info"
            };

            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();

                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearchValue.Text;
                if (radioByID.Checked)
                {
                    int searchID = int.Parse(searchValue);
                    Member member = memberRepository.GetMember(searchID);
                    if (member != null)
                    {
                        IEnumerable<Member> searchResult = new List<Member>() { member };
                        dataSource = searchResult;
                        this.searchResult = searchResult;
                        this.filterResult = searchResult;
                        filter = false;
                        search = true;
                        LoadMemberList();
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (radioByName.Checked)
                {
                    string searchName = searchValue;
                    IEnumerable<Member> searchResult = memberRepository.SearchMember(searchName);
                    if (searchResult.Any())
                    {
                        dataSource = searchResult;
                        this.searchResult = searchResult;
                        this.filterResult = searchResult;
                        filter = false;
                        search = true;
                        LoadMemberList();
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCountry.DataSource != null)
                {
                    string country = cboCountry.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(country))
                    {
                        IEnumerable<Member> searchResult;
                        if (search)
                        {
                            searchResult = memberRepository.SearchMemberByCountry(country, this.searchResult);
                        } else
                        {
                            searchResult = memberRepository.SearchMemberByCountry(country, this.dataSource);
                        }
                           
                        if (searchResult.Any())
                        {
                            cboSearchCity.DataBindings.Clear();

                            IEnumerable<string> cityList = new List<string>();
                            if (country.Equals("All"))
                            {
                                var keys = cityDictionary.Keys;
                                IEnumerable<string> _cityList;
                                foreach (var key in keys)
                                {
                                    cityDictionary.TryGetValue(key, out _cityList);
                                    if (_cityList.Any())
                                    {
                                        foreach (var _city in _cityList)
                                        {
                                            cityList = cityList.Concat(new List<string>() { _city });
                                        }
                                    }
                                }
                            } else
                            {
                                cityDictionary.TryGetValue(country, out cityList);
                            }

                            cityList = cityList.Distinct();

                            citySource = new BindingSource();
                            citySource.DataSource = cityList;
                            cboSearchCity.DataSource = null;
                            cboSearchCity.DataSource = citySource;

                            filterResult = searchResult;
                            filter = true;
                            LoadMemberList();
                        }
                        else
                        {
                            MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSearchCity.DataSource != null)
                {
                    string city = cboSearchCity.SelectedItem.ToString();
                    //string country = cboCountry.SelectedText.ToString();
                    string country = cboCountry.Text;

                    if (!string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(country))
                    {
                        IEnumerable<Member> searchResult;
                        if (search)
                        {
                            searchResult = memberRepository.SearchMemberByCity(country, city, this.searchResult);
                        } else
                        {
                            searchResult = memberRepository.SearchMemberByCity(country, city, this.dataSource);
                        }
                        
                        if (searchResult.Any())
                        {
                            filter = true;
                            filterResult = searchResult;
                            LoadMemberList();
                        }
                        else
                        {
                            MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

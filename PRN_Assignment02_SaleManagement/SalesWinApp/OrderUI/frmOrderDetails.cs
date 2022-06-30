using AutoMapper;
using BusinessObject;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.OrderRepo;
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

namespace SalesWinApp.OrderUI
{
    public partial class frmOrderDetails : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public OrderPresenter OrderPresenter { get; set; }

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private IEnumerable<CartPresenter> cartPresenters;
        private IMapper mapper;
        BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                int orderId = OrderPresenter.OrderID;
                string memberName = OrderPresenter.MemberName;
                DateTime orderDate = OrderPresenter.OrderDate;
                decimal orderTotal = OrderPresenter.OrderTotal;
                IEnumerable<OrderDetail> orderDetails = orderDetailRepository.GetOrderDetails(orderId);
                cartPresenters = orderDetails.Select(od => mapper.Map<OrderDetail, CartPresenter>(od));

                source = new BindingSource();
                source.DataSource = cartPresenters;

                txtOderID.Text = orderId.ToString();
                txtOrderDate.Text = orderDate.Date.ToString();
                txtOrderTotal.Text = orderTotal.ToString();
                txtMemberName.Text = memberName;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;

                if (LoginMember.Fullname.Equals("Admin"))
                {
                    btnDelete.Visible = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you really want to delete this order:\n" +
                    $"Order ID: {OrderPresenter.OrderID}\n" +
                    $"Member: {OrderPresenter.MemberName}\n" +
                    $"Order Date: {OrderPresenter.OrderDate}\n" +
                    $"Order Total: {OrderPresenter.OrderTotal}?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int orderId = OrderPresenter.OrderID;
                    orderDetailRepository.DeleteOrderDetails(orderId);
                    orderRepository.DeleteOrder(orderId);
                    MessageBox.Show("Delete Order Succesfully!", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

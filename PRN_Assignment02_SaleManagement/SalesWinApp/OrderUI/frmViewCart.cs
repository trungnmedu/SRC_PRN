using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.ProductRepo;
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
using SalesWinApp.MemberUI;
using SalesWinApp.OrderUI;
using DataAccess.Repository.OrderRepo;
using DataAccess.Repository.OrderDetailRepo;

namespace SalesWinApp.OrderUI
{
    public partial class frmViewCart : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();

        private IMapper mapper;
        BindingSource source;
        public frmViewCart()
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

            ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
            ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

            // Main Menu
            mainMenu.Items.AddRange(new ToolStripItem[]
            {
                        menuOrder,
                        menuExit
            });

            menuOrder.Click += new EventHandler(menuOrder_Click);
            menuProfile.Click += new EventHandler(menuProfile_Click);
            menuExit.Click += new EventHandler(menuExit_Click);

        }
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
        private void menuExit_Click(object sender, EventArgs e) => Close();
        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Member Details",
                MemberInfo = LoginMember,
                InsertOrUpdate = false,
                MemberRepository = MemberRepository
            };
            frmMemberDetails.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberDetails.Show();
        }
        private void LoadCart()
        {
            try
            {
                Dictionary<int, CartProduct> cart = CartRepository.GetCart();
                if (cart == null || cart.Count == 0)
                {
                    btnRemoveFromCart.Enabled = false;
                    txtVCProductName.DataBindings.Clear();
                    txtVCProductName.Text = string.Empty;
                    txtVCPrice.DataBindings.Clear();
                    txtVCPrice.Text = string.Empty;
                    txtVCQuantity.DataBindings.Clear();
                    txtVCQuantity.Text = string.Empty;
                    txtVCTotal.DataBindings.Clear();
                    txtVCTotal.Text = string.Empty;
                    dgvCart.DataSource = null;
                    btnCheckOut.Enabled = false;
                }
                else
                {
                    decimal orderTotal = 0;

                    IProductRepository productRepository = new ProductRepository();

                    IEnumerable<CartPresenter> cartPresenters = new List<CartPresenter>();

                    foreach (var cartItem in cart)
                    {
                        CartPresenter cartPresenter = new CartPresenter()
                        {
                            ProductName = productRepository.GetProduct(cartItem.Key).ProductName,
                            Price = cartItem.Value.Price,
                            Quantity = cartItem.Value.Quantity,
                            Total = cartItem.Value.Price * cartItem.Value.Quantity
                        };
                        orderTotal += cartItem.Value.Price * cartItem.Value.Quantity;
                        cartPresenters = cartPresenters.Append(cartPresenter);
                    }

                    source = new BindingSource();
                    source.DataSource = cartPresenters;

                    txtVCProductName.DataBindings.Clear();
                    txtVCPrice.DataBindings.Clear();
                    txtVCQuantity.DataBindings.Clear();
                    txtVCTotal.DataBindings.Clear();

                    txtVCProductName.DataBindings.Add("Text", source, "ProductName");
                    txtVCPrice.DataBindings.Add("Text", source, "Price");
                    txtVCQuantity.DataBindings.Add("Text", source, "Quantity");
                    txtVCTotal.DataBindings.Add("Text", source, "Total");

                    lbOrderTotal.Text = $"Order Total: {orderTotal}";

                    dgvCart.DataSource = null;
                    dgvCart.DataSource = source;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmViewCart_Load(object sender, EventArgs e)
        {
            CreateMainMenu();
            LoadCart();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Do you really want to delete the cart item:\n" +
                $"Product Name: {txtVCProductName.Text}\n" +
                $"Price: {txtVCPrice.Text}\n" +
                $"Quantity: {txtVCQuantity.Text}\n" +
                $"Total: {txtVCTotal.Text}?", "Remove From Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IProductRepository productRepository = new ProductRepository();
                    CartRepository.RemoveFromCart(productRepository.GetProduct(txtVCProductName.Text).ProductId);
                    LoadCart();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove From Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private CartPresenter GetCartItem()
        {
            CartPresenter cartPresenter = null;
            try
            {
                cartPresenter = new CartPresenter()
                {
                    ProductName = txtVCProductName.Text,
                    Price = decimal.Parse(txtVCPrice.Text),
                    Quantity = int.Parse(txtVCQuantity.Text),
                    Total = decimal.Parse(txtVCTotal.Text)
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cartPresenter;
        }
        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CartPresenter cartItem = GetCartItem();

            frmViewCartDetails frmViewCartDetails = new frmViewCartDetails
            {
                CartRepository = this.CartRepository,
                CartPresenter = cartItem
            };

            if (frmViewCartDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCart();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Dictionary<int, CartProduct> cart = CartRepository.GetCart();

            IProductRepository productRepository = new ProductRepository();
            IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            IEnumerable<OrderDetail> orderItems = new List<OrderDetail>();
            Order order = new Order();
            MemberPresenter member = this.LoginMember;

            DateTime dateTime = DateTime.Today;

            if (cart != null && cart.Count > 0)
            {
                try
                {
                    order = new Order
                    {
                        MemberId = member.MemberId,
                        OrderDate = dateTime,
                    };
                    Order insertedOrder = orderRepository.AddOrder(order);

                    foreach (var cartItem in cart)
                    {
                        decimal unitPrice = productRepository.GetProduct(cartItem.Key).UnitPrice;
                        decimal price = decimal.Parse(txtVCPrice.Text);
                        decimal discount = (unitPrice - price) / unitPrice;
                        OrderDetail orderDetail = new OrderDetail()
                        {
                            OrderId = insertedOrder.OrderId,
                            ProductId = cartItem.Key,
                            UnitPrice = productRepository.GetProduct(cartItem.Key).UnitPrice,
                            Quantity = cartItem.Value.Quantity,
                            Discount = Convert.ToDouble(discount)
                        };
                        orderDetailRepository.AddOrderDetail(orderDetail);
                        Product product = productRepository.GetProduct(cartItem.Key);
                        product.UnitsInStock = product.UnitsInStock - cartItem.Value.Quantity;
                        productRepository.Update(product);
                    }
                    MessageBox.Show("Check out successfully!", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CartRepository.DeleteCart();
                    frmProductsManagement frmProductsManagement = new frmProductsManagement()
                    {
                        LoginMember = this.LoginMember,
                        MemberRepository = this.MemberRepository,
                        CartRepository = this.CartRepository
                    };
                    frmProductsManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmProductsManagement.Show();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Check out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

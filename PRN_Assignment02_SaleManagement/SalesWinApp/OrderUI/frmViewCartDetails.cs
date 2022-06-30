using DataAccess.Repository.CartRepo;
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

namespace SalesWinApp.OrderUI
{
    public partial class frmViewCartDetails : Form
    {
        public ICartRepository  CartRepository { get; set; }
        public CartPresenter CartPresenter { get; set; }
        public frmViewCartDetails()
        {
            InitializeComponent();
        }

        private void frmViewCartDetails_Load(object sender, EventArgs e)
        {
            try
            {
                numUnitPrice.Maximum = decimal.MaxValue;
                IProductRepository productRepository = new ProductRepository();
                numQuantity.Maximum = productRepository.GetProduct(CartPresenter.ProductName).UnitsInStock;
                txtProductName.Text = CartPresenter.ProductName;
                numUnitPrice.Value = CartPresenter.Price;
                numQuantity.Value = CartPresenter.Quantity;
                txtTotal.Text = CartPresenter.Total.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepository productRepository = new ProductRepository();
                int productId = productRepository.GetProduct(CartPresenter.ProductName).ProductId;
                CartRepository.UpdateCart(productId, Convert.ToInt32(numQuantity.Value), numUnitPrice.Value);
                MessageBox.Show("Update successfully!", "Update Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal newTotal = numUnitPrice.Value * numQuantity.Value;
            txtTotal.Text = newTotal.ToString();
        }
    }
}

using AutoMapper;
using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.CategoryRepo;
using DataAccess.Repository.ProductRepo;
using SalesWinApp.CategoryUI;
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

namespace SalesWinApp.ProductUI
{
    public partial class frmProductDetail : Form
    {
        public bool InsertOrUpdate { get; set; }
        public MemberPresenter LoginMember { get; set; }
        public IProductRepository ProductRepository { get; set; }
        private ICategoryRepository CategoryRepository = new CategoryRepository();
        public ICartRepository CartRepository { get; set; }
        public ProductPresenter ProductInfo { get; set; }
        private IMapper mapper;

        public frmProductDetail()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }
        
        private void cboCategory_LoadDataSource(bool addCategory = false)
        {
            IEnumerable<Category> categories;
            try
            {
                categories = CategoryRepository.GetCategoryList();
                if (categories == null)
                {
                    categories = new List<Category>();
                }
                categories = categories.Append(new Category()
                {
                    CategoryName = "Add new Category"
                });
                BindingSource categorySource = new BindingSource();
                categorySource.DataSource = categories.ToList();

                cboCategory.DataSource = null;
                cboCategory.DataSource = categorySource;
                cboCategory.DisplayMember = "CategoryName";
                if (addCategory)
                {
                    categorySource.Position = categorySource.Count - 2;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            try
            {
                numUnitPrice.Maximum = decimal.MaxValue;
                numUnitsInStock.Maximum = int.MaxValue;
                if (LoginMember.Fullname.Equals("Admin"))
                {
                    if (InsertOrUpdate) // Insert
                    {
                        btnAction.Text = "&Add";
                        //txtProductId.Text = ProductRepository.GetNextProductId().ToString();
                        cboCategory_LoadDataSource();

                    }
                    else // Update
                    {
                        btnAction.Text = "&Update";
                        txtProductId.Text = ProductInfo.ProductId.ToString();
                        txtProductName.Text = ProductInfo.ProductName;
                        txtWeight.Text = ProductInfo.Weight;
                        numUnitPrice.Value = ProductInfo.UnitPrice;
                        numUnitsInStock.Value = ProductInfo.UnitsInStock;
                        cboCategory_LoadDataSource();
                        cboCategory.SelectedIndex = cboCategory.FindStringExact(ProductInfo.CategoryName);

                    }
                }
                else
                {
                    btnAction.Text = "&Add To Cart";
                    txtProductId.ReadOnly = true;
                    txtProductName.ReadOnly = true;
                    cboCategory.Enabled = false;
                    txtWeight.ReadOnly = true;
                    numUnitPrice.ReadOnly = true;

                    lbUnitsInStock.Text = "Quantity to Order";

                    txtProductId.Text = ProductInfo.ProductId.ToString();
                    txtProductName.Text = ProductInfo.ProductName;
                    cboCategory_LoadDataSource();
                    cboCategory.SelectedIndex = cboCategory.FindStringExact(ProductInfo.CategoryName);
                    txtWeight.Text = ProductInfo.Weight;
                    numUnitPrice.Value = ProductInfo.UnitPrice;

                    numUnitsInStock.Value = 1;
                    numUnitsInStock.Minimum = 1;
                    numUnitsInStock.Maximum = ProductInfo.UnitsInStock;
                    lbNote.Visible = true;
                    lbNote.Text += $"{ProductInfo.UnitsInStock + 1}\nDefault is 1";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LoginMember.Fullname.Equals("Admin") ? (InsertOrUpdate ? "Add Product" : "Update Product") : "Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginMember.Fullname.Equals("Admin"))
                {
                    if (InsertOrUpdate) // Insert
                    {
                        ProductPresenter productPresenter = new ProductPresenter()
                        {
                            //ProductId = int.Parse(txtProductId.Text),
                            ProductName = txtProductName.Text,
                            CategoryName = cboCategory.Text,
                            Weight = txtWeight.Text,
                            UnitPrice = numUnitPrice.Value,
                            UnitsInStock = Convert.ToInt32(numUnitsInStock.Value)
                        };
                        Product product = mapper.Map<Product>(productPresenter);
                        ProductRepository.AddProduct(product);
                        MessageBox.Show("Add successfully!!", "Add new Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Update
                    {
                        ProductPresenter productPresenter = new ProductPresenter()
                        {
                            ProductId = int.Parse(txtProductId.Text),
                            ProductName = txtProductName.Text,
                            CategoryName = cboCategory.Text,
                            Weight = txtWeight.Text,
                            UnitPrice = numUnitPrice.Value,
                            UnitsInStock = Convert.ToInt32(numUnitsInStock.Value)
                        };
                        Product product = mapper.Map<Product>(productPresenter);
                        ProductRepository.Update(product);
                        MessageBox.Show("Update successfully!!", "Update new Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Add To Cart
                    int quantity = Convert.ToInt32(numUnitsInStock.Value);
                    int productId = int.Parse(txtProductId.Text);
                    decimal price = numUnitPrice.Value;

                    CartRepository.AddToCart(productId, quantity, price);
                    MessageBox.Show("Add to cart successfully!!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (InsertOrUpdate) ? "Add new Product" : "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categorySelected = cboCategory.Text;
            if (categorySelected.Equals("Add new Category"))
            {
                frmAddCategory frmAddCategory = new frmAddCategory
                {
                    CategoryRepository = this.CategoryRepository
                };
                if (frmAddCategory.ShowDialog() == DialogResult.OK)
                {
                    cboCategory_LoadDataSource(true);
                }
            }
        }
    }
}

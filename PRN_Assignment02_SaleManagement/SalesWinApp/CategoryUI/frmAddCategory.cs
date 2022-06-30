using DataAccess.Repository.CategoryRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.CategoryUI
{
    public partial class frmAddCategory : Form
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            try
            {
                CategoryRepository.AddCategory(categoryName);
                MessageBox.Show("Add Category with the name: " + categoryName + " successfully!!", "Add new Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}

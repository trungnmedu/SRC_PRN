using SalesWinApp.MemberUI;
using SalesWinApp.ProductUI;
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
using DataAccess.Repository.MemberRepo;
using SalesWinApp.OrderUI;
using DataAccess.Repository.CartRepo;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
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

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrdersManagement frmOrdersManagement = new frmOrdersManagement
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmOrdersManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmOrdersManagement.Show();
        }
    }
}

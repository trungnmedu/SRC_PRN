
namespace SalesWinApp.MemberUI
{
    partial class frmMembersManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbSearchCity = new System.Windows.Forms.Label();
            this.cboSearchCity = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.menuProductMng = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderMng = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.grSearch.SuspendLayout();
            this.grFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(26, 43);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(130, 40);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(184, 23);
            this.txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(26, 84);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(56, 15);
            this.lbMemberName.TabIndex = 2;
            this.lbMemberName.Text = "Fullname";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(130, 81);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(184, 23);
            this.txtMemberName.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(26, 125);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(380, 43);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(446, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(380, 84);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 8;
            this.lbCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(446, 81);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 23);
            this.txtCity.TabIndex = 9;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(380, 125);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 10;
            this.lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(446, 122);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 23);
            this.txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(74, 198);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(271, 198);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(458, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(7, 333);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(650, 258);
            this.dgvMemberList.TabIndex = 15;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(16, 24);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(64, 21);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(118, 23);
            this.txtSearchValue.TabIndex = 17;
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(27, 21);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(50, 15);
            this.lbSearchCountry.TabIndex = 18;
            this.lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            this.cboCountry.Location = new System.Drawing.Point(77, 18);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(165, 23);
            this.cboCountry.TabIndex = 0;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lbSearchCity
            // 
            this.lbSearchCity.AutoSize = true;
            this.lbSearchCity.Location = new System.Drawing.Point(32, 56);
            this.lbSearchCity.Name = "lbSearchCity";
            this.lbSearchCity.Size = new System.Drawing.Size(28, 15);
            this.lbSearchCity.TabIndex = 19;
            this.lbSearchCity.Text = "City";
            // 
            // cboSearchCity
            // 
            this.cboSearchCity.Location = new System.Drawing.Point(77, 53);
            this.cboSearchCity.Name = "cboSearchCity";
            this.cboSearchCity.Size = new System.Drawing.Size(165, 23);
            this.cboSearchCity.TabIndex = 20;
            this.cboSearchCity.SelectedIndexChanged += new System.EventHandler(this.cboSearchCity_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(64, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Location = new System.Drawing.Point(25, 227);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(289, 89);
            this.grSearch.TabIndex = 22;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(202, 55);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(73, 19);
            this.radioByName.TabIndex = 23;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(202, 25);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(52, 19);
            this.radioByID.TabIndex = 22;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "By ID";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.cboSearchCity);
            this.grFilter.Controls.Add(this.lbSearchCity);
            this.grFilter.Controls.Add(this.cboCountry);
            this.grFilter.Controls.Add(this.lbSearchCountry);
            this.grFilter.Location = new System.Drawing.Point(369, 231);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(260, 84);
            this.grFilter.TabIndex = 23;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(26, 161);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lbCompanyName.TabIndex = 24;
            this.lbCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(130, 158);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 23);
            this.txtCompanyName.TabIndex = 5;
            // 
            // menuProductMng
            // 
            this.menuProductMng.Name = "menuProductMng";
            this.menuProductMng.Size = new System.Drawing.Size(32, 19);
            // 
            // menuOrderMng
            // 
            this.menuOrderMng.Name = "menuOrderMng";
            this.menuOrderMng.Size = new System.Drawing.Size(32, 19);
            // 
            // frmMembersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 607);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMembersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ToolStripMenuItem menuProductMng;
        private System.Windows.Forms.ToolStripMenuItem menuOrderMng;
    }
}
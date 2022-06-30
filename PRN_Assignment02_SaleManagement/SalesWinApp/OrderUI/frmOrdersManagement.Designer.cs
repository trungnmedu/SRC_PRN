
namespace SalesWinApp.OrderUI
{
    partial class frmOrdersManagement
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.grSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 178);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(413, 252);
            this.dgvOrderList.TabIndex = 0;
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(13, 43);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(84, 40);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(114, 23);
            this.txtOrderID.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(13, 72);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(84, 69);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(114, 23);
            this.txtOrderDate.TabIndex = 4;
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Location = new System.Drawing.Point(13, 101);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(65, 15);
            this.lbOrderTotal.TabIndex = 5;
            this.lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Location = new System.Drawing.Point(84, 98);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(114, 23);
            this.txtOrderTotal.TabIndex = 6;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.endDate);
            this.grSearch.Controls.Add(this.lbEndDate);
            this.grSearch.Controls.Add(this.startDate);
            this.grSearch.Controls.Add(this.lbStartDate);
            this.grSearch.Location = new System.Drawing.Point(214, 26);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(211, 132);
            this.grSearch.TabIndex = 7;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(70, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(70, 53);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(135, 23);
            this.endDate.TabIndex = 3;
            this.endDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(10, 59);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(54, 15);
            this.lbEndDate.TabIndex = 2;
            this.lbEndDate.Text = "End Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(70, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(135, 23);
            this.startDate.TabIndex = 1;
            this.startDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 20);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(58, 15);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Start Date";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(13, 130);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(52, 15);
            this.lbMember.TabIndex = 5;
            this.lbMember.Text = "Member";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(84, 127);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(114, 23);
            this.txtMemberName.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(156, 440);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 36);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmOrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 484);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmOrdersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Management";
            this.Load += new System.EventHandler(this.frmOrdersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Button btnExport;
    }
}
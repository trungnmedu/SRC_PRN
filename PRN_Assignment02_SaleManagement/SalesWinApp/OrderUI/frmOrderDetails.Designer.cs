
namespace SalesWinApp.OrderUI
{
    partial class frmOrderDetails
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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtOderID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.Label();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.Label();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbMember = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(12, 29);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtOderID
            // 
            this.txtOderID.AutoSize = true;
            this.txtOderID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOderID.Location = new System.Drawing.Point(84, 29);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.Size = new System.Drawing.Size(56, 15);
            this.txtOderID.TabIndex = 1;
            this.txtOderID.Text = "Order ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(12, 57);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 2;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.AutoSize = true;
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOrderDate.Location = new System.Drawing.Point(84, 57);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(70, 15);
            this.txtOrderDate.TabIndex = 3;
            this.txtOrderDate.Text = "Order Date";
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Location = new System.Drawing.Point(12, 85);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(65, 15);
            this.lbOrderTotal.TabIndex = 4;
            this.lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.AutoSize = true;
            this.txtOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOrderTotal.Location = new System.Drawing.Point(84, 85);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(70, 15);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.Text = "Order Total";
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(12, 121);
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.ReadOnly = true;
            this.dgvOrderDetailList.RowTemplate.Height = 25;
            this.dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(375, 212);
            this.dgvOrderDetailList.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(155, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(194, 29);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(52, 15);
            this.lbMember.TabIndex = 8;
            this.lbMember.Text = "Member";
            // 
            // txtMemberName
            // 
            this.txtMemberName.AutoSize = true;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(252, 29);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(91, 15);
            this.txtMemberName.TabIndex = 9;
            this.txtMemberName.Text = "Member Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 24);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 380);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOrderDetailList);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label txtOderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label txtOrderDate;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.Label txtOrderTotal;
        private System.Windows.Forms.DataGridView dgvOrderDetailList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label txtMemberName;
        private System.Windows.Forms.Button btnDelete;
    }
}
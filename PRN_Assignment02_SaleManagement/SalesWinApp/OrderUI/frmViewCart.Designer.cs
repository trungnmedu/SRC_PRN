
namespace SalesWinApp.OrderUI
{
    partial class frmViewCart
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtVCProductName = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtVCQuantity = new System.Windows.Forms.TextBox();
            this.lbVCPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtVCPrice = new System.Windows.Forms.TextBox();
            this.txtVCTotal = new System.Windows.Forms.TextBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(12, 185);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowTemplate.Height = 25;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(502, 228);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellDoubleClick);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(12, 46);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name";
            // 
            // txtVCProductName
            // 
            this.txtVCProductName.Enabled = false;
            this.txtVCProductName.Location = new System.Drawing.Point(105, 43);
            this.txtVCProductName.Name = "txtVCProductName";
            this.txtVCProductName.Size = new System.Drawing.Size(161, 23);
            this.txtVCProductName.TabIndex = 2;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(12, 89);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtVCQuantity
            // 
            this.txtVCQuantity.Enabled = false;
            this.txtVCQuantity.Location = new System.Drawing.Point(105, 86);
            this.txtVCQuantity.Name = "txtVCQuantity";
            this.txtVCQuantity.Size = new System.Drawing.Size(161, 23);
            this.txtVCQuantity.TabIndex = 4;
            // 
            // lbVCPrice
            // 
            this.lbVCPrice.AutoSize = true;
            this.lbVCPrice.Location = new System.Drawing.Point(300, 43);
            this.lbVCPrice.Name = "lbVCPrice";
            this.lbVCPrice.Size = new System.Drawing.Size(33, 15);
            this.lbVCPrice.TabIndex = 5;
            this.lbVCPrice.Text = "Price";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(301, 89);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(32, 15);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Total";
            // 
            // txtVCPrice
            // 
            this.txtVCPrice.Enabled = false;
            this.txtVCPrice.Location = new System.Drawing.Point(353, 40);
            this.txtVCPrice.Name = "txtVCPrice";
            this.txtVCPrice.Size = new System.Drawing.Size(161, 23);
            this.txtVCPrice.TabIndex = 7;
            // 
            // txtVCTotal
            // 
            this.txtVCTotal.Enabled = false;
            this.txtVCTotal.Location = new System.Drawing.Point(353, 86);
            this.txtVCTotal.Name = "txtVCTotal";
            this.txtVCTotal.Size = new System.Drawing.Size(161, 23);
            this.txtVCTotal.TabIndex = 8;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(265, 146);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveFromCart.TabIndex = 9;
            this.btnRemoveFromCart.Text = "&Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderTotal.Location = new System.Drawing.Point(12, 150);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(76, 15);
            this.lbOrderTotal.TabIndex = 10;
            this.lbOrderTotal.Text = "Order Total: ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(406, 146);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 23);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "&Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 424);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.txtVCTotal);
            this.Controls.Add(this.txtVCPrice);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVCPrice);
            this.Controls.Add(this.txtVCQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtVCProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.dgvCart);
            this.Name = "frmViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            this.Load += new System.EventHandler(this.frmViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtVCQuantity;
        private System.Windows.Forms.Label lbVCPrice;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtVCPrice;
        private System.Windows.Forms.TextBox txtVCTotal;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.TextBox txtVCProductName;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.Button btnCheckOut;
    }
}
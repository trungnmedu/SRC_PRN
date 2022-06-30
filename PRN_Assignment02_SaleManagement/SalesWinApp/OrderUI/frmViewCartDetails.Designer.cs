
namespace SalesWinApp.OrderUI
{
    partial class frmViewCartDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCartDetails));
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            resources.ApplyResources(this.lbProductName, "lbProductName");
            this.lbProductName.Name = "lbProductName";
            // 
            // txtProductName
            // 
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.Name = "txtProductName";
            // 
            // lbQuantity
            // 
            resources.ApplyResources(this.lbQuantity, "lbQuantity");
            this.lbQuantity.Name = "lbQuantity";
            // 
            // lbUnitPrice
            // 
            resources.ApplyResources(this.lbUnitPrice, "lbUnitPrice");
            this.lbUnitPrice.Name = "lbUnitPrice";
            // 
            // numUnitPrice
            // 
            resources.ApplyResources(this.numUnitPrice, "numUnitPrice");
            this.numUnitPrice.Name = "numUnitPrice";
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lbTotal
            // 
            resources.ApplyResources(this.lbTotal, "lbTotal");
            this.lbTotal.Name = "lbTotal";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmViewCartDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Name = "frmViewCartDetails";
            this.Load += new System.EventHandler(this.frmViewCartDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}
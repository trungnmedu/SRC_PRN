
namespace SalesWinApp
{
    partial class frmMain
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
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.Location = new System.Drawing.Point(42, 34);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Size = new System.Drawing.Size(126, 53);
            this.btnMemberManagement.TabIndex = 1;
            this.btnMemberManagement.Text = "&Member Management";
            this.btnMemberManagement.UseVisualStyleBackColor = true;
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Location = new System.Drawing.Point(204, 34);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(126, 53);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "&Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(361, 34);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(126, 53);
            this.btnOrderManagement.TabIndex = 3;
            this.btnOrderManagement.Text = "&Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 118);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.btnMemberManagement);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStore Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnOrderManagement;
    }
}
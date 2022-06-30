
namespace SalesWinApp.ProductUI
{
    partial class frmProductsManagement
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
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.rdUnitsInStock = new System.Windows.Forms.RadioButton();
            this.rdUnitPrice = new System.Windows.Forms.RadioButton();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.grFilter.SuspendLayout();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.btnFilter);
            this.grFilter.Controls.Add(this.txtTo);
            this.grFilter.Controls.Add(this.lbTo);
            this.grFilter.Controls.Add(this.txtFrom);
            this.grFilter.Controls.Add(this.lbFrom);
            this.grFilter.Controls.Add(this.rdUnitsInStock);
            this.grFilter.Controls.Add(this.rdUnitPrice);
            this.grFilter.Enabled = false;
            this.grFilter.Location = new System.Drawing.Point(313, 218);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(336, 89);
            this.grFilter.TabIndex = 43;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(238, 53);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 23);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(218, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 23);
            this.txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(193, 23);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(19, 15);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(55, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 23);
            this.txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(14, 22);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(35, 15);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From";
            // 
            // rdUnitsInStock
            // 
            this.rdUnitsInStock.AutoSize = true;
            this.rdUnitsInStock.Location = new System.Drawing.Point(115, 55);
            this.rdUnitsInStock.Name = "rdUnitsInStock";
            this.rdUnitsInStock.Size = new System.Drawing.Size(97, 19);
            this.rdUnitsInStock.TabIndex = 17;
            this.rdUnitsInStock.Text = "Units In Stock";
            this.rdUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // rdUnitPrice
            // 
            this.rdUnitPrice.AutoSize = true;
            this.rdUnitPrice.Checked = true;
            this.rdUnitPrice.Location = new System.Drawing.Point(14, 55);
            this.rdUnitPrice.Name = "rdUnitPrice";
            this.rdUnitPrice.Size = new System.Drawing.Size(76, 19);
            this.rdUnitPrice.TabIndex = 16;
            this.rdUnitPrice.TabStop = true;
            this.rdUnitPrice.Text = "Unit Price";
            this.rdUnitPrice.UseVisualStyleBackColor = true;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Enabled = false;
            this.grSearch.Location = new System.Drawing.Point(18, 218);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(289, 89);
            this.grSearch.TabIndex = 42;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(215, 53);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(73, 19);
            this.radioByName.TabIndex = 12;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(215, 23);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(52, 19);
            this.radioByID.TabIndex = 11;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "By ID";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(77, 19);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(118, 23);
            this.txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(29, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(17, 322);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(632, 257);
            this.dgvProductList.TabIndex = 41;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(452, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(265, 177);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(68, 177);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(372, 125);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitsInStock.TabIndex = 36;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(372, 84);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 34;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(372, 43);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 32;
            this.lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(465, 40);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(184, 23);
            this.txtWeight.TabIndex = 4;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(18, 125);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(55, 15);
            this.lbCategory.TabIndex = 29;
            this.lbCategory.Text = "Category";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(122, 81);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 23);
            this.txtProductName.TabIndex = 2;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(18, 84);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(84, 15);
            this.lbMemberName.TabIndex = 27;
            this.lbMemberName.Text = "Product Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(122, 40);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(184, 23);
            this.txtProductID.TabIndex = 1;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(18, 43);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(63, 15);
            this.lbProductID.TabIndex = 25;
            this.lbProductID.Text = "Product ID";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(122, 122);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(184, 23);
            this.txtCategory.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(465, 81);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(184, 23);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Enabled = false;
            this.txtUnitsInStock.Location = new System.Drawing.Point(465, 122);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(184, 23);
            this.txtUnitsInStock.TabIndex = 6;
            // 
            // frmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 591);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbProductID);
            this.Name = "frmProductsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProductsManagement_Load);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.RadioButton rdUnitsInStock;
        private System.Windows.Forms.RadioButton rdUnitPrice;
    }
}
namespace AcmeInsuranceDB.Presentation_Layer
{
    partial class frmSalesSearch
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbSearchByCategory = new System.Windows.Forms.RadioButton();
            this.rbSearchByLastName = new System.Windows.Forms.RadioButton();
            this.rbListAllRows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(221, 101);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(185, 24);
            this.cbProduct.TabIndex = 13;
            this.cbProduct.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(221, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // rbSearchByCategory
            // 
            this.rbSearchByCategory.AutoSize = true;
            this.rbSearchByCategory.Location = new System.Drawing.Point(18, 152);
            this.rbSearchByCategory.Name = "rbSearchByCategory";
            this.rbSearchByCategory.Size = new System.Drawing.Size(146, 21);
            this.rbSearchByCategory.TabIndex = 10;
            this.rbSearchByCategory.TabStop = true;
            this.rbSearchByCategory.Text = "Search by Product";
            this.rbSearchByCategory.UseVisualStyleBackColor = true;
            this.rbSearchByCategory.CheckedChanged += new System.EventHandler(this.rbSearchByCategory_CheckedChanged);
            // 
            // rbSearchByLastName
            // 
            this.rbSearchByLastName.AutoSize = true;
            this.rbSearchByLastName.Location = new System.Drawing.Point(18, 105);
            this.rbSearchByLastName.Name = "rbSearchByLastName";
            this.rbSearchByLastName.Size = new System.Drawing.Size(165, 21);
            this.rbSearchByLastName.TabIndex = 9;
            this.rbSearchByLastName.TabStop = true;
            this.rbSearchByLastName.Text = "Search by Last Name";
            this.rbSearchByLastName.UseVisualStyleBackColor = true;
            this.rbSearchByLastName.CheckedChanged += new System.EventHandler(this.rbSearchByLastName_CheckedChanged);
            // 
            // rbListAllRows
            // 
            this.rbListAllRows.AutoSize = true;
            this.rbListAllRows.Location = new System.Drawing.Point(18, 58);
            this.rbListAllRows.Name = "rbListAllRows";
            this.rbListAllRows.Size = new System.Drawing.Size(102, 21);
            this.rbListAllRows.TabIndex = 8;
            this.rbListAllRows.TabStop = true;
            this.rbListAllRows.Text = "List all rows";
            this.rbListAllRows.UseVisualStyleBackColor = true;
            this.rbListAllRows.CheckedChanged += new System.EventHandler(this.rbListAllRows_CheckedChanged);
            // 
            // frmSalesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbSearchByCategory);
            this.Controls.Add(this.rbSearchByLastName);
            this.Controls.Add(this.rbListAllRows);
            this.Name = "frmSalesSearch";
            this.Text = "Search Sales";
            this.Load += new System.EventHandler(this.frmSalesSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbSearchByCategory;
        private System.Windows.Forms.RadioButton rbSearchByLastName;
        private System.Windows.Forms.RadioButton rbListAllRows;
    }
}
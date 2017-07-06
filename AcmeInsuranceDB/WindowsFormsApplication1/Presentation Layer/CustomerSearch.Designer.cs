namespace AcmeInsuranceDB.Presentation_Layer
{
    partial class frmCustomerSearch
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
            this.rbListAllRows = new System.Windows.Forms.RadioButton();
            this.rbSearchByLastName = new System.Windows.Forms.RadioButton();
            this.rbSearchByCategory = new System.Windows.Forms.RadioButton();
            this.rbSearchByPostcode = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbListAllRows
            // 
            this.rbListAllRows.AutoSize = true;
            this.rbListAllRows.Location = new System.Drawing.Point(34, 50);
            this.rbListAllRows.Name = "rbListAllRows";
            this.rbListAllRows.Size = new System.Drawing.Size(102, 21);
            this.rbListAllRows.TabIndex = 0;
            this.rbListAllRows.TabStop = true;
            this.rbListAllRows.Text = "List all rows";
            this.rbListAllRows.UseVisualStyleBackColor = true;
            // 
            // rbSearchByLastName
            // 
            this.rbSearchByLastName.AutoSize = true;
            this.rbSearchByLastName.Location = new System.Drawing.Point(34, 97);
            this.rbSearchByLastName.Name = "rbSearchByLastName";
            this.rbSearchByLastName.Size = new System.Drawing.Size(165, 21);
            this.rbSearchByLastName.TabIndex = 1;
            this.rbSearchByLastName.TabStop = true;
            this.rbSearchByLastName.Text = "Search by Last Name";
            this.rbSearchByLastName.UseVisualStyleBackColor = true;
            // 
            // rbSearchByCategory
            // 
            this.rbSearchByCategory.AutoSize = true;
            this.rbSearchByCategory.Location = new System.Drawing.Point(34, 144);
            this.rbSearchByCategory.Name = "rbSearchByCategory";
            this.rbSearchByCategory.Size = new System.Drawing.Size(154, 21);
            this.rbSearchByCategory.TabIndex = 2;
            this.rbSearchByCategory.TabStop = true;
            this.rbSearchByCategory.Text = "Search by Category";
            this.rbSearchByCategory.UseVisualStyleBackColor = true;
            // 
            // rbSearchByPostcode
            // 
            this.rbSearchByPostcode.AutoSize = true;
            this.rbSearchByPostcode.Location = new System.Drawing.Point(34, 191);
            this.rbSearchByPostcode.Name = "rbSearchByPostcode";
            this.rbSearchByPostcode.Size = new System.Drawing.Size(156, 21);
            this.rbSearchByPostcode.TabIndex = 3;
            this.rbSearchByPostcode.TabStop = true;
            this.rbSearchByPostcode.Text = "Search by Postcode";
            this.rbSearchByPostcode.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(233, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(233, 97);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(185, 24);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(34, 239);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 295);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbSearchByPostcode);
            this.Controls.Add(this.rbSearchByCategory);
            this.Controls.Add(this.rbSearchByLastName);
            this.Controls.Add(this.rbListAllRows);
            this.Name = "frmCustomerSearch";
            this.Text = "Search Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbListAllRows;
        private System.Windows.Forms.RadioButton rbSearchByLastName;
        private System.Windows.Forms.RadioButton rbSearchByCategory;
        private System.Windows.Forms.RadioButton rbSearchByPostcode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}
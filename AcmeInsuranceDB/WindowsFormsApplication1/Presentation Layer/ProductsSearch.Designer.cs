namespace AcmeInsuranceDB.Presentation_Layer
{
    partial class frmProductsSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbSearchByYearlyPremium = new System.Windows.Forms.RadioButton();
            this.rbSearchByProductName = new System.Windows.Forms.RadioButton();
            this.rbListAllRows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(227, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // rbSearchByYearlyPremium
            // 
            this.rbSearchByYearlyPremium.AutoSize = true;
            this.rbSearchByYearlyPremium.Location = new System.Drawing.Point(23, 138);
            this.rbSearchByYearlyPremium.Name = "rbSearchByYearlyPremium";
            this.rbSearchByYearlyPremium.Size = new System.Drawing.Size(196, 21);
            this.rbSearchByYearlyPremium.TabIndex = 10;
            this.rbSearchByYearlyPremium.TabStop = true;
            this.rbSearchByYearlyPremium.Text = "Search by Yearly Premium";
            this.rbSearchByYearlyPremium.UseVisualStyleBackColor = true;
            // 
            // rbSearchByProductName
            // 
            this.rbSearchByProductName.AutoSize = true;
            this.rbSearchByProductName.Location = new System.Drawing.Point(23, 91);
            this.rbSearchByProductName.Name = "rbSearchByProductName";
            this.rbSearchByProductName.Size = new System.Drawing.Size(187, 21);
            this.rbSearchByProductName.TabIndex = 9;
            this.rbSearchByProductName.TabStop = true;
            this.rbSearchByProductName.Text = "Search by Product Name";
            this.rbSearchByProductName.UseVisualStyleBackColor = true;
            this.rbSearchByProductName.CheckedChanged += new System.EventHandler(this.rbSearchByProductName_CheckedChanged);
            // 
            // rbListAllRows
            // 
            this.rbListAllRows.AutoSize = true;
            this.rbListAllRows.Location = new System.Drawing.Point(23, 44);
            this.rbListAllRows.Name = "rbListAllRows";
            this.rbListAllRows.Size = new System.Drawing.Size(102, 21);
            this.rbListAllRows.TabIndex = 8;
            this.rbListAllRows.TabStop = true;
            this.rbListAllRows.Text = "List all rows";
            this.rbListAllRows.UseVisualStyleBackColor = true;
            // 
            // frmProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbSearchByYearlyPremium);
            this.Controls.Add(this.rbSearchByProductName);
            this.Controls.Add(this.rbListAllRows);
            this.Name = "frmProductsSearch";
            this.Text = "Search Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbSearchByYearlyPremium;
        private System.Windows.Forms.RadioButton rbSearchByProductName;
        private System.Windows.Forms.RadioButton rbListAllRows;
    }
}
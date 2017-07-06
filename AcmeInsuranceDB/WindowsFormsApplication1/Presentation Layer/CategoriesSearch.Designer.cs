namespace AcmeInsuranceDB.Presentation_Layer
{
    partial class frmCategoriesSearch
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
            this.rbSearchByCategory = new System.Windows.Forms.RadioButton();
            this.rbListAllRows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(218, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // rbSearchByCategory
            // 
            this.rbSearchByCategory.AutoSize = true;
            this.rbSearchByCategory.Location = new System.Drawing.Point(21, 107);
            this.rbSearchByCategory.Name = "rbSearchByCategory";
            this.rbSearchByCategory.Size = new System.Drawing.Size(154, 21);
            this.rbSearchByCategory.TabIndex = 10;
            this.rbSearchByCategory.TabStop = true;
            this.rbSearchByCategory.Text = "Search by Category";
            this.rbSearchByCategory.UseVisualStyleBackColor = true;
            // 
            // rbListAllRows
            // 
            this.rbListAllRows.AutoSize = true;
            this.rbListAllRows.Location = new System.Drawing.Point(21, 60);
            this.rbListAllRows.Name = "rbListAllRows";
            this.rbListAllRows.Size = new System.Drawing.Size(102, 21);
            this.rbListAllRows.TabIndex = 8;
            this.rbListAllRows.TabStop = true;
            this.rbListAllRows.Text = "List all rows";
            this.rbListAllRows.UseVisualStyleBackColor = true;
            // 
            // frmCategoriesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbSearchByCategory);
            this.Controls.Add(this.rbListAllRows);
            this.Name = "frmCategoriesSearch";
            this.Text = "Search Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbSearchByCategory;
        private System.Windows.Forms.RadioButton rbListAllRows;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AcmeInsuranceDB.Data_Access_Layer;
using AcmeInsuranceDB.Business_Logic_Layer;

namespace AcmeInsuranceDB.Presentation_Layer
{
    public partial class frmCategoriesSearch : Form
    {
        public frmCategoriesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories();
            categories.Show();
            this.Hide();
        }

        private void rbListAllRows_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbCategory.Visible = false;
        }

        private void rbSearchByCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = true;
            cbCategory.Top = txtSearch.Top;
            cbCategory.Left = txtSearch.Left;
        }

        private void frmCategoriesSearch_Load(object sender, EventArgs e)
        {
            string populateCategory = "SELECT * FROM Categories";
            List<Categories> categoriesList = new List<Categories>();
            try
            {
                using (var con = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(populateCategory, con))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var category = new Categories(int.Parse(rdr["CategoryID"].ToString()), rdr["Category"].ToString());
                        categoriesList.Add(category);
                    }
                }
                cbCategory.DataSource = categoriesList;
                cbCategory.DisplayMember = "Category";
                cbCategory.ValueMember = "CategoryID";
            }
            catch
            {
                //catch error here
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbListAllRows.Checked == true)
            {//select all

            }
            
            if (rbSearchByCategory.Checked == true)
            {
                //"WHERE Customers.CategoryID = " + cbCategory.Items[cbCategory.SelectedIndex].ToString() + "";
            }

            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers viewForm = new frmCustomers();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales viewForm = new frmSales();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories viewForm = new frmCategories();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts viewForm = new frmProducts();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductTypes viewForm = new frmProductTypes();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorial viewForm = new frmTutorial();
            viewForm.ShowDialog();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAbout();
            frm1.ShowDialog(this);
        }
    }
}

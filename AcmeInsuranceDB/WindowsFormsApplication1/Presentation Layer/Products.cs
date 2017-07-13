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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductsAdd viewForm = new frmProductsAdd();
            viewForm.Show();
            this.Hide();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            displayProducts();
        }
      
        private void displayProducts()
        {
            string selectQuery = "SELECT * FROM Products";
            List<Products> productsList = new List<Products>();
            try
            {
                using (var con = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(selectQuery, con))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                         var products = new Products
                         (int.Parse(rdr["ProductID"].ToString()),
                         int.Parse(rdr["ProductTypeID"].ToString()),
                         rdr["ProductName"].ToString(),
                         int.Parse(rdr["YearlyPremium"].ToString())
                         );

                        productsList.Add(products);
                    }
                    dgProductsView.DataSource = productsList;
                }

            }
            catch
            {

            }
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
            displayProducts();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbListAllRows.Checked == true)
            {

            }

            if (rbSearchByProductName.Checked == true)
            {
                //"SELECT * FROM Products WHERE Product.ProductName = " + txtSearch.Text + "'";
            }

            if (rbSearchByYearlyPremium.Checked == true)
            {
                //"SELECT * FROM Products WHERE Product.YearlyPremium = " + txtSearch.Text + "'";
            }
        }
    }
}

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
    public partial class frmSales : Form
    {
        public frmSales()
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
            frmSalesAdd viewForm = new frmSalesAdd();
            viewForm.Show();
            this.Hide();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    frmSalesSearch viewForm = new Presentation_Layer.frmSalesSearch();
        //    viewForm.Show();
        //    this.Hide();
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmSalesUpdate viewForm = new frmSalesUpdate();
            viewForm.Show();
            this.Hide();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            displaySales();
        }

        private void displaySales()
        {
            string selectQuery = "SELECT * FROM Sales";
            List<Sales> salesList = new List<Sales>();
            try
            {
                using (var con = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(selectQuery, con))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var sales = new Sales
                         (int.Parse(rdr["SaleID"].ToString()),
                         int.Parse(rdr["CustomerID"].ToString()),
                         int.Parse(rdr["ProductID"].ToString()),
                         rdr["Payable"].ToString(),
                         DateTime.Parse(rdr["StartDate"].ToString())
                         );

                        salesList.Add(sales);
                    }
                    dgSalesView.DataSource = salesList;
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
            displaySales();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

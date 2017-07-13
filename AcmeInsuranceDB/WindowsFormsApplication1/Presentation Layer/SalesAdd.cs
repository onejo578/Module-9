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
    public partial class frmSalesAdd : Form
    {
        public frmSalesAdd()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {

                //Sales sale = new Sales(0,
                //    int.Parse(txtCustomerID.Text),
                //    int.Parse(txtProductID.Text),
                //    cbPayable.Text,
                //    dtpStartDate.Value);

                Sales sale = new Sales();

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Customers_CreateSale ", conn))
                {
                    //CommandType = CommandType.StoredProcedure })

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter newsaleid = cmd.Parameters.Add("NewSaleID", SqlDbType.Int); //~~~~~~~~~~~
                    newsaleid.Direction = ParameterDirection.Output;
                    
                    cmd.Parameters.AddWithValue("CustomerID", sale.CustomerID);
                    cmd.Parameters.AddWithValue("ProductID", sale.ProductID);
                    cmd.Parameters.AddWithValue("Payable", sale.Payable);
                    cmd.Parameters.AddWithValue("StartDate", sale.StartDate);
                    cmd.Parameters.AddWithValue("@NewSaleID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                }

                //Add closing confirmation here
                this.Close();
            }
        }
        

        private bool validateForm()
        {
            // Customer ID should generate itself ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


            if (String.IsNullOrEmpty(cbPayable.Text))
            {
                MessageBox.Show("Please select a Payable period.");
                return false;
            }

            if (String.IsNullOrEmpty(dtpStartDate.Text))
            {
                MessageBox.Show("Please select a Start Date.");
                return false;
            }
            return true;
        }

        private void frmSalesAdd_Load(object sender, EventArgs e)
        {

            string populateSales = "SELECT * FROM Sales"; //right? ~~~~~~~~~~~~~~~~~~~~~
            List<Sales> salesList = new List<Sales>();
            try
            {
                using (var con = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(populateSales, con))
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
                }
                cbPayable.DataSource = salesList;

                cbPayable.DisplayMember = "Payable";
                cbPayable.ValueMember = "Payable";

            }
            catch
            {
                //catch error here
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtCustomerID.Clear();
            txtProductID.Clear();
            cbPayable.SelectedIndex = -1;
            //Start Date? ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        }
    }
}

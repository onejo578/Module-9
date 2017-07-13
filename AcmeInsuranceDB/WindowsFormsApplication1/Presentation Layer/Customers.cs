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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
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
            frmCustomersAdd viewForm = new frmCustomersAdd();
            viewForm.Show();
            this.Hide();
            
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    frmCustomerSearch viewForm = new frmCustomerSearch();
        //    viewForm.Show();
        //    this.Hide();
        //}



        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new AcmeInsuranceDB.frmMainForm();
            mainForm.Show();
            this.Hide();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void displayCustomers()
        {
            string selectQuery = "SELECT * FROM Customers";
            List<Customers> customersList = new List<Customers>();
            try
            {
                using (var con = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(selectQuery, con))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Customers customer = new Customers(
                         int.Parse(rdr["CustomerID"].ToString()),
                         rdr["FirstName"].ToString(),
                         rdr["LastName"].ToString(),
                         rdr["Address"].ToString(),
                         rdr["Suburb"].ToString(),
                         rdr["State"].ToString(),
                         rdr["Gender"].ToString(),
                         int.Parse(rdr["Postcode"].ToString()),
                         int.Parse(rdr["CategoryID"].ToString()),
                         DateTime.Parse(rdr["BirthDate"].ToString()));

                        customersList.Add(customer);
                    }
                    dgCustomersView.DataSource = customersList;
                }

            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (dgCustomersView.SelectedRows > 0)
            //{
            //    DataGridViewRow selectedRow = dgCustomersView.SelectedRows[0];
            //    var updateCustomer = (Customers)selectedRow.DataBoundItem;

            //} //bracket should be below the form nav

                frmCustomersUpdate viewForm = new frmCustomersUpdate();
                viewForm.ShowDialog();
                displayCustomers();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgCustomersView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Customer to Delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
            //int selectedCustomerID = int.Parse(dgCustomersView.SelectedRows[0].Text);

            string deleteQuery = "sp_Customers_DeleteCustomer";
            DataGridViewRow selectedRow = dgCustomersView.SelectedRows[0]; //Selecting the row
            var deleteCustomer = (Customers)selectedRow.DataBoundItem; //setting deleteCustomer to an instance of the Customer Class of the selected row.

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            //conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", dgCustomersView.Rows[0].Selected); //dgCustomersView.Rows[0].Selected ---> is that legit?
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            //dgCustomersView.Rows.Clear();
            displayCustomers();
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~






        }

        //private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void productToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayCustomers();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (rbListAllRows.Checked == true)
            //{//select all
            //    //SELECT * FROM Customers;
            //}

            //if (rbSearchByLastName.Checked == true)
            //{
            //   // "WHERE LastName = '" + txtSearch.Text + "'";
            //}

            //if (rbSearchByCategory.Checked == true)
            //{
            //    //"WHERE Customers.CategoryID = " + cbCategory.Items[cbCategory.SelectedIndex].ToString() + "";
            //}

            //if (rbSearchByPostcode.Checked == true)
            //{
            //    //"WHERE Customers.Postcode = " + txtSearch.Text + "'";
            //}

            //this.Close();
        }
    }
    }


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
    public partial class frmCustomersAdd : Form
    {
        public frmCustomersAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                string gender = "M";
                if (rbFemale.Checked)
                {
                    gender = "F";
                }
                
                Customers customer = new Customers(0,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtAddress.Text,
                    txtSuburb.Text,
                    cbState.Text,
                    gender,
                    int.Parse(txtPostcode.Text),
                    (int)cbCategory.SelectedValue,
                    dtpBirthDate.Value);
                
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Customers_CreateCustomer ", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@Address", customer.Address);
                    cmd.Parameters.AddWithValue("@Suburb", customer.Suburb);
                    cmd.Parameters.AddWithValue("@State", customer.State);
                    cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                    cmd.Parameters.AddWithValue("@PostCode", customer.PostCode);
                    cmd.Parameters.AddWithValue("@CategoryID", customer.CategoryID);
                    cmd.Parameters.AddWithValue("@BirthDate", customer.BirthDate);
                    cmd.Parameters.AddWithValue("@NewCustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                }
                //Add closing confirmation here
                this.Close();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
            this.Hide();
        }

        private void frmCustomersAdd_Load(object sender, EventArgs e)
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

        private bool validateForm()
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.");
                return false;
            }

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last name.");
                return false;
            }

            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please select a Gender.");
                return false;
            }

            if (String.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please select a Category.");
                return false;
            }

            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an Address.");
                return false;
            }

            if (String.IsNullOrEmpty(txtSuburb.Text))
            {
                MessageBox.Show("Please enter a Suburb.");
                return false;
            }

            if (String.IsNullOrEmpty(cbState.Text))
            {
                MessageBox.Show("Please select a State.");
                return false;
            }

            if (String.IsNullOrEmpty(txtPostcode.Text))
            {
                MessageBox.Show("Please enter a postcode.");
                return false;
            }

            int parsedValue;
            if (!int.TryParse(txtPostcode.Text, out parsedValue))
            {
                MessageBox.Show("Postcode must be an number.");
                return false;
            }
            return true;
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            txtFirstName.Clear();
            txtLastName.Clear();
            // Birthdate? ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbCategory.SelectedIndex = -1;
            txtAddress.Clear();
            txtSuburb.Clear();
            cbState.SelectedIndex = -1;
            txtPostcode.Clear();
            txtCustomerID.Clear();
        }
    }
}

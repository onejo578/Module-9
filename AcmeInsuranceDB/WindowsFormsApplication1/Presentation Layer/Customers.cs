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


        //private void DisplayCustomers()
        //{
        //    string selectQuery;

        //    selectQuery = "SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, ";
        //    selectQuery = selectQuery + "Customers.Address, Customers.Suburb, Customers.State, Customers.Postcode, ";
        //    selectQuery = selectQuery + "Customers.Gender, ";
        //    selectQuery = selectQuery + "FROM Customers INNER JOIN ";
        //    selectQuery = selectQuery + "Categories ON Customers.CategoryID = Categories.CategoryID";

        //    SqlConnection conn = ConnectionManager.DatabaseConnection();
        //    SqlDataReader rdr = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(selectQuery, conn);
        //        rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            // Define the list items

        //            string gender = "Male";
        //            if (rdr["Gender"].ToString() == "F")
        //            {
        //                gender = "Female";
        //            }
                    
        //            Customers customer = new Customers(int.Parse(rdr["CustomerID"].ToString()),
        //                                 rdr["FirstName"].ToString(),
        //                                 rdr["LastName"].ToString(),
        //                                rdr["Address"].ToString(),
        //                                 rdr["Suburb"].ToString(),
        //                                 rdr["State"].ToString(),
        //                                 gender, 
        //                                 int.Parse(rdr["Postcode"].ToString()),
        //                                 int.Parse(rdr["CategoryID"].ToString()),
        //                                 DateTime.Parse(rdr["BirthDate"].ToString()));
                                         
              

        //            ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
        //            lvi.SubItems.Add(customer.FirstName);
        //            lvi.SubItems.Add(customer.LastName);
        //            lvi.SubItems.Add(customer.Address);
        //            lvi.SubItems.Add(customer.Suburb);
        //            lvi.SubItems.Add(customer.State);
        //            lvi.SubItems.Add(customer.Gender);
        //            lvi.SubItems.Add(customer.PostCode.ToString());
        //            //lvi.SubItems.Add(customer.CategoryID);
        //            lvi.SubItems.Add(customer.BirthDate.ToString());

        //            lvCustomers.Items.Add(lvi);
        //        }
        //        if (rdr != null)
        //            rdr.Close();
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Unsuccessful" + ex);
        //    }
        //}
        

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

            WindowsFormsApplication1.GlobalVariables.selectedCustomerID = 0;
            frmCustomersAdd editForm = new frmCustomersAdd();
            editForm.ShowDialog();
            displayCustomers();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCustomerSearch viewForm = new frmCustomerSearch();
            viewForm.Show();
            this.Hide();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new AcmeInsuranceDB.frmMainForm();
            mainForm.Show();
            this.Hide();
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
                        Customers customer = new Customers(int.Parse(rdr["CustomerID"].ToString()),
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
    }
}

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
                //    txtFirstName.Text,
                //    txtLastName.Text,
                //    cbProduct.Text,
                //    cbPayable.Text,
                //    dtpStartDate.Value);


                //using (var conn = ConnectionManager.DatabaseConnection())
                //using (var cmd = new SqlCommand("sp_Customers_CreateSale ", conn)
                //{
                //    CommandType = CommandType.StoredProcedure
                //})
                //{
                //    cmd.Parameters.AddWithValue("@FirstName", sale.FirstName);
                //    cmd.Parameters.AddWithValue("@LastName", sale.LastName);
                //    cmd.Parameters.AddWithValue("@Address", sale.ProductID);
                //    cmd.Parameters.AddWithValue("@Suburb", sale.Payable);
                //    cmd.Parameters.AddWithValue("@State", sale.StartDate);

                //    cmd.Parameters.AddWithValue("@NewSaleID", SqlDbType.Int).Direction = ParameterDirection.Output;

                //    cmd.Transaction = conn.BeginTransaction();
                //    cmd.ExecuteNonQuery();
                //    cmd.Transaction.Commit();
                //}
                ////Add closing confirmation here
                //this.Close();
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

            if (String.IsNullOrEmpty(cbProduct.Text))
            {
                MessageBox.Show("Please select a Category.");
                return false;
            }

            if (String.IsNullOrEmpty(cbPayable.Text))
            {
                MessageBox.Show("Please enter an Address.");
                return false;
            }
            //Need one for the Start Date

            return true;
        }

        private void frmSalesAdd_Load(object sender, EventArgs e)
        {

            //string populateSales = "SELECT Product, Payable FROM Sales"; //right?
            //List<Sales> salesList = new List<Sales>();
            //try
            //{
            //    using (var con = ConnectionManager.DatabaseConnection())
            //    using (var cmd = new SqlCommand(populateSales, con))
            //    using (var rdr = cmd.ExecuteReader())
            //    {
            //        while (rdr.Read())
            //        {
            //            var sales = new Sales(rdr["Product"].ToString(), rdr["Payable"].ToString());
                    
            //            salesList.Add(sales);
            //        }
            //    }
            //    cbProduct.DataSource = salesList;
            //    cbPayable.DataSource = salesList;
                
            //    cbPayable.DisplayMember = "Payable";
            //    cbPayable.ValueMember = "Payable";

            //    cbProduct.DisplayMember = "Product";
            //    cbProduct.ValueMember = "Product";
            //}
            //catch
            //{
            //    //catch error here
            //}




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

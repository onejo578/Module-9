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
    public partial class frmProductsAdd : Form
    {
        public frmProductsAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.Show();
            this.Hide();
        }
        


        private void frmProductsAdd_Load(object sender, EventArgs e)
        {
            //  Pulling the Product Types into the combo box when form loads


            //string populateProductID = "SELECT ProductTypeID FROM ProductTypes"; //Is that the right syntax? "ProductTypeID"?
            //List<Product_Types_Class> productTypeIDList = new List<Product_Types_Class>();
            //try
            //{
            //    using (var con = ConnectionManager.DatabaseConnection())
            //    using (var cmd = new SqlCommand(populateProductID, con))
            //    using (var rdr = cmd.ExecuteReader())
            //    {
            //        while (rdr.Read())
            //        {
            //            var producttypeID = new Product_Types_Class(/*int.Parse*/(rdr["ProductTypeID"].ToString()));
            //            //Is it the class where we're calling it from? 
            //            productTypeIDList.Add(producttypeID);
            //        }
            //    }
            //    cbProductTypeID.DataSource = productTypeIDList;
            //    cbProductTypeID.DisplayMember = "ProductTypeID";

            //}
            //catch
            //{
            //    //catch error here
            //}
        }





        private bool validateForm()
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter the Product name.");
                return false;
            }

            int parsedValue;
            if (!int.TryParse(txtYearlyPremium.Text, out parsedValue))
            {
                MessageBox.Show("Yearly Premium must be an number.");
                return false;
            }

            if (String.IsNullOrEmpty(cbProductTypeID.Text))
            {
                MessageBox.Show("Please select a Product Type");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //    if (validateForm())
            //    {
            //        Products products = new Products(
            //            //0,
            //            txtProductName.Text,
            //            int.Parse(txtYearlyPremium.Text),
            //            (int)cbProductTypeID.SelectedValue);



            //        using (var conn = ConnectionManager.DatabaseConnection())
            //        using (var cmd = new SqlCommand("sp_Products_CreateProduct ", conn)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        })
            //        {
            //            cmd.Parameters.AddWithValue("@ProductName", products.ProductName);
            //            cmd.Parameters.AddWithValue("@YearlyPremium", products.YearlyPremium);
            //            cmd.Parameters.AddWithValue("@ProductTypeID", products.ProductTypeID);

            //            //cmd.Parameters.AddWithValue("@NewCustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;

            //            cmd.Transaction = conn.BeginTransaction();
            //            cmd.ExecuteNonQuery();
            //            cmd.Transaction.Commit();
            //        }
            //        //Add closing confirmation here
            //        this.Close();
            //    }
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

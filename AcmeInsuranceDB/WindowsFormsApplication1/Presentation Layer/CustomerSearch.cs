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
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
        {
            InitializeComponent();
        }
        
        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
        }
        //Display or Hide text box/combo box depending on radio button selection
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
            this.Hide();
        }

        private void rbListAllRows_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;

        }

        private void rbSearchByCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
        }

        private void rbSearchByLastName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSearchByPostcode_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbListAllRows.Checked == true)
            {//select all
                //SELECT* FROM Customers;
            }

            if (rbSearchByLastName.Checked == true)
            {
                // "WHERE LastName = '" + txtSearch.Text + "'";
            }
            
            if (rbSearchByPostcode.Checked == true)
            {
                //"WHERE Customers.Postcode = " + txtSearch.Text + "'";
            }

            this.Close();
        }

        private void frmCustomerSearch_Load_1(object sender, EventArgs e)
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


    }
    }
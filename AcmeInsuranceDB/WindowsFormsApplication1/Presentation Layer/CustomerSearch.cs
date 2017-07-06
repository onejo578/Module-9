using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeInsuranceDB.Presentation_Layer
{
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
        {
            InitializeComponent();
        }


        private void rbListAllRows_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = false;
        }

        private void rbSearchByLastName_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbCategory.Visible = false;
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {

            txtSearch.Visible = false;
            cbCategory.Visible = true;
            cbCategory.Top = txtSearch.Top;
            cbCategory.Left = txtSearch.Left;
        }

        private void rbPostcode_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbCategory.Visible = false;
        }



        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = false;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
            this.Hide();
        }
    }
}

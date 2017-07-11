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
    public partial class frmProductsSearch : Form
    {
        public frmProductsSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.Show();
            this.Hide();
        }

        private void rbSearchByProductName_CheckedChanged(object sender, EventArgs e)
        {

        }

  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbListAllRows.Checked == true)
            {
  
            }

            if (rbSearchByProductName.Checked == true)
            {
                //"WHERE Product.ProductName = " + txtSearch.Text + "'";
            }

            if (rbSearchByYearlyPremium.Checked == true)
            {
                //"WHERE Product.YearlyPremium = " + txtSearch.Text + "'";
            }
        }
    }
}

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
    public partial class frmSalesSearch : Form
    {
        public frmSalesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales ();
            sales.Show();
            this.Hide();
        }

        private void rbListAllRows_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbProduct.Visible = false;
        }

        private void rbSearchByLastName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbProduct.Visible = false;
        }

        private void rbSearchByCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbProduct.Visible = true;
            cbProduct.Top = txtSearch.Top;
            cbProduct.Left = txtSearch.Left;
        }

        private void frmSalesSearch_Load(object sender, EventArgs e)
        {

            ////Needs fixed  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //string populateProduct = "SELECT * FROM Products";
            //List<Products> productTypeList = new List<Products>();
            //try
            //{
            //    using (var con = ConnectionManager.DatabaseConnection())
            //    using (var cmd = new SqlCommand(populateProduct, con))
            //    using (var rdr = cmd.ExecuteReader())
            //    {
            //        while (rdr.Read())
            //        {
            //            var category = new Products(rdr["Product"].ToString());
            //            productTypeList.Add(category);
            //        }
            //    }
            //    cbProduct.DataSource = productTypeList;
            //    cbProduct.DisplayMember = "Product";
            //    cbProduct.ValueMember = "Product";
            //}
            //catch
            //{
            //    //catch error here
        }
    }
}

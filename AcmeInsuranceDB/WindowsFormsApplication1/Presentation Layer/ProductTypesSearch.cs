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
    public partial class frmProductTypesSearch : Form
    {
        public frmProductTypesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProductTypes producttypes = new frmProductTypes();
            producttypes.Show();
            this.Hide();
        }

        private void frmProductTypesSearch_Load(object sender, EventArgs e)
        {

            //Needs fixed  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //string populateProductType = "SELECT * FROM ProductTypes";
            //List<Products> productTypeList = new List<Products>();
            //try
            //{
            //    using (var con = ConnectionManager.DatabaseConnection())
            //    using (var cmd = new SqlCommand(populateProductType, con))
            //    using (var rdr = cmd.ExecuteReader())
            //    {
            //        while (rdr.Read())
            //        {
            //            var category = new Products(rdr["ProductType"].ToString());
            //            productTypeList.Add(category);
            //        }
            //    }
            //    cbProductType.DataSource = productTypeList;
            //    cbProductType.DisplayMember = "ProductType";
            //    cbProductType.ValueMember = "ProductType";
            //}
            //catch
            //{
            //    //catch error here
        }

        private void rbListAllRows_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbProductType.Visible = false;
        }

        private void rbSearchByProductName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbProductType.Visible = true;
            cbProductType.Top = txtSearch.Top;
            cbProductType.Left = txtSearch.Left;
        }

      }
    }


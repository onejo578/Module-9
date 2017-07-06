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
    }
}

﻿using System;
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
    public partial class frmProductTypesAdd : Form
    {
        public frmProductTypesAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProductTypes productTypes = new frmProductTypes();
            productTypes.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            







        }
        
        private bool validateForm()
        {
            if (String.IsNullOrEmpty(txtProductType.Text))
            {
                MessageBox.Show("Please enter the Product Type.");
                return false;
            }

            return true;
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

using System;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormSuppliersApp : Form
    {
        public FormSuppliersApp()
        {
            InitializeComponent();
        }

        // STOCK

        private void mnuStock_Click(object sender, EventArgs e)
        {
        }

        private void mnuAddStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddStock nextForm = new FormAddStock(this);
            nextForm.Show();
        }

        private void mnuUpdStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateStock nextForm = new FormUpdateStock(this);
            nextForm.Show();
        }

        private void mnuListStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListStock nextForm = new FormListStock(this);
            nextForm.Show();
        }

        private void mnuRmvStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveStock nextForm = new FormRemoveStock(this);
            nextForm.Show();
        }


        // SUPPLIER

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
        }

        private void mnuAddSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSupplier nextForm = new FormAddSupplier(this);
            nextForm.Show();
        }

        private void mnuUpdSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateSupplier nextForm = new FormUpdateSupplier(this);
            nextForm.Show();
        }

        private void mnuListSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListSupplier nextForm = new FormListSupplier(this);
            nextForm.Show();
        }

        private void mnuRmvSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveSupplier nextForm = new FormRemoveSupplier(this);
            nextForm.Show();
        }


        // SALE

        private void mnuSale_Click(object sender, EventArgs e)
        {
        }

        private void mnuAddSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSale nextForm = new FormAddSale(this);
            nextForm.Show();
        }

        private void mnuUpdSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateSale nextForm = new FormUpdateSale(this);
            nextForm.Show();
        }

        private void mnuListSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListSale nextForm = new FormListSale(this);
            nextForm.Show();
        }

        private void mnuRmvSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveSale nextForm = new FormRemoveSale(this);
            nextForm.Show();
        }


        // REVENUE

        private void mnuViewRevenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewRevenue nextForm = new FormViewRevenue(this);
            nextForm.Show();
        }


        // EXIT

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
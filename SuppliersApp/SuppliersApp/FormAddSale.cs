using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormAddSale : Form
    {
        private FormSuppliersApp parent;

        public FormAddSale(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            // Get the next Sale ID
            txtSaleID.Text = Sale.GetNextSaleID().ToString("0000");

            // Set today's date
            dtpSaleDate.Value = DateTime.Now;

            // Load Stock into the combo box
            DataSet ds = Stock.GetAllStock();

            cboStock.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboStock.Items.Add(
                    ds.Tables[0].Rows[i]["StockID"] + " - " +
                    ds.Tables[0].Rows[i]["Description"]
                );
            }
        }

        private void cboStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStock.SelectedIndex >= 0)
            {
                string selected = cboStock.SelectedItem.ToString();

                // Get StockID from the beginning of the combo box item
                txtStockID.Text = selected.Split('-')[0].Trim();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a Sale object using the values from the form
            Sale aSale = new Sale(
                Convert.ToInt32(txtSaleID.Text),
                Convert.ToInt32(txtStockID.Text),
                Convert.ToInt32(txtQty.Text),
                Convert.ToDecimal(txtTotal.Text),
                dtpSaleDate.Value
            );

            // Add the sale to the database
            aSale.AddSale();

            // Display confirmation
            MessageBox.Show(
                "Sale " + txtSaleID.Text + " added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Reset the form
            txtSaleID.Text = Sale.GetNextSaleID().ToString("0000");
            txtStockID.Clear();
            txtQty.Clear();
            txtTotal.Text = "0.00";
            dtpSaleDate.Value = DateTime.Now;
            cboStock.SelectedIndex = -1;

            txtQty.Focus();
        }
    }
}
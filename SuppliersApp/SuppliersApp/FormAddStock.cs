using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormAddStock : Form
    {
        FormSuppliersApp parent;

        public FormAddStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormAddStock_Load(object sender, EventArgs e)
        {
            txtStockID.Text = Stock.GetNextStockID().ToString("0000");

            DataSet ds = Supplier.GetAllSuppliers();

            cboSupplier.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSupplier.Items.Add(
                    ds.Tables[0].Rows[i]["SuppID"] +
                    " - " +
                    ds.Tables[0].Rows[i]["Name"]
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the selected Supplier ID
            int supplierID = 0;

            if (cboSupplier.SelectedIndex >= 0)
            {
                supplierID = Convert.ToInt32(
                cboSupplier.Text.Split('-')[0].Trim()
                );
            }
            else
            {
                MessageBox.Show(
                    "Please select a supplier.",
                    "Missing Supplier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboSupplier.Focus();
                return;
            }

            // Create Stock object
            Stock aStock = new Stock(
                Convert.ToInt32(txtStockID.Text),
                txtDescription.Text,
                Convert.ToDecimal(txtPrice.Text),
                Convert.ToInt32(txtQty.Text),
                supplierID
            );

            // Add Stock to database
            aStock.AddStock();

            // Display confirmation
            MessageBox.Show(
                "Stock " + txtStockID.Text +
                " added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Reset UI
            txtStockID.Text = Stock.GetNextStockID().ToString("0000");
            txtDescription.Clear();
            txtPrice.Text = "0.00";
            txtQty.Clear();
            cboSupplier.SelectedIndex = -1;

            txtDescription.Focus();
        }
    }
}
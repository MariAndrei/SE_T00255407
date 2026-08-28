using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormUpdateStock : Form
    {
        private FormSuppliersApp parent;
        private Stock stock;

        public FormUpdateStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;

            grdStock.Visible = false;
            grpStock.Visible = false;
        }

        // FORM LOAD
        private void FormUpdateStock_Load(object sender, EventArgs e)
        {
            // Load suppliers into cboSupplier
            DataSet ds = Stock.GetSuppliers();

            cboSupplier.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSupplier.Items.Add(
                    ds.Tables[0].Rows[i]["SuppID"] + " - " +
                    ds.Tables[0].Rows[i]["Name"]
                );
            }
        }

        // SEARCH STOCK USING ENTER
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataSet ds = Stock.FindStock(txtSearch.Text);

                grdStock.DataSource = ds.Tables[0];

                if (grdStock.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No stock found.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                grdStock.Visible = true;
            }
        }

        // SELECT STOCK FROM GRID
        private void grdStock_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get StockID from the first column
            int stockID = Convert.ToInt32(
                grdStock.Rows[e.RowIndex].Cells[0].Value
            );

            // Get the selected stock
            stock = Stock.GetStock(stockID);

            if (stock == null)
            {
                MessageBox.Show("Stock not found.");
                return;
            }

            // Put stock information into the textboxes
            txtStockID.Text = stock.StockID.ToString();
            txtDescription.Text = stock.Description;
            txtPrice.Text = stock.Price.ToString("0.00");
            txtStockQty.Text = stock.StockQty.ToString();
            txtSuppID.Text = stock.SuppID.ToString();

            // Select the current supplier
            for (int i = 0; i < cboSupplier.Items.Count; i++)
            {
                string item = cboSupplier.Items[i].ToString();

                if (item.StartsWith(stock.SuppID + " -"))
                {
                    cboSupplier.SelectedIndex = i;
                    break;
                }
            }

            // Show the update section
            grpStock.Visible = true;
        }

        // SUPPLIER COMBO BOX
        private void cboSupplier_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboSupplier.SelectedIndex >= 0)
            {
                string selected =
                    cboSupplier.SelectedItem.ToString();

                // Get SuppID from the beginning of the item
                txtSuppID.Text =
                    selected.Split('-')[0].Trim();
            }
        }

        // UPDATE BUTTON
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (stock == null)
            {
                MessageBox.Show(
                    "Please search for and select a stock item first.",
                    "Update Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // Update the Stock object
                stock.Description = txtDescription.Text;
                stock.Price = Convert.ToDecimal(txtPrice.Text);
                stock.StockQty = Convert.ToInt32(txtStockQty.Text);
                stock.SuppID = Convert.ToInt32(txtSuppID.Text);

                // Update database
                stock.UpdateStock();

                MessageBox.Show(
                    "Stock " + stock.StockID +
                    " updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Reset form
                stock = null;

                grpStock.Visible = false;
                grdStock.Visible = false;

                txtSearch.Clear();
                txtStockID.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                txtStockQty.Clear();
                txtSuppID.Clear();

                cboSupplier.SelectedIndex = -1;

                txtSearch.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers for Price and Quantity.",
                    "Invalid Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // BACK BUTTON
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

    }
}
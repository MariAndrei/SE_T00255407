using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormRemoveStock : Form
    {
        private FormSuppliersApp parent;
        private Stock stock;

        public FormRemoveStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormRemoveStock_Load(object sender, EventArgs e)
        {
            grdStock.Visible = false;
        }

        // Search when Enter is pressed
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
                        MessageBoxIcon.Information);

                    return;
                }

                grdStock.Visible = true;
            }
        }

        // Select stock from grid
        private void grdStock_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int stockID = Convert.ToInt32(
                grdStock.Rows[e.RowIndex].Cells[0].Value);

            stock = Stock.GetStock(stockID);

            if (stock != null)
            {
                txtStockID.Text = stock.StockID.ToString();
                txtDescription.Text = stock.Description;
                txtPrice.Text = stock.Price.ToString("0.00");
                txtStockQty.Text = stock.StockQty.ToString();
                txtSuppID.Text = stock.SuppID.ToString();
            }
        }

        // Remove stock
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (stock == null)
            {
                MessageBox.Show(
                    "Please search for and select a stock item first.",
                    "Remove Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove Stock " +
                stock.StockID + "?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                stock.RemoveStock();

                MessageBox.Show(
                    "Stock " + stock.StockID +
                    " removed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                stock = null;

                txtSearch.Clear();
                txtStockID.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                txtStockQty.Clear();
                txtSuppID.Clear();

                grdStock.DataSource = null;
                grdStock.Visible = false;

                txtSearch.Focus();
            }
        }

        // Back
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormRemoveSale : Form
    {
        private FormSuppliersApp parent;
        private Sale sale;

        public FormRemoveSale(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormRemoveSale_Load(object sender, EventArgs e)
        {
            grdSales.Visible = false;
        }

        // Search when Enter is pressed
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataSet ds = Sale.GetAllSales();

                grdSales.DataSource = ds.Tables[0];

                if (grdSales.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No sales found.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                grdSales.Visible = true;
            }
        }

        // Select sale from grid
        private void grdSales_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int saleID = Convert.ToInt32(
                grdSales.Rows[e.RowIndex].Cells[0].Value);

            sale = Sale.GetSale(saleID);

            if (sale != null)
            {
                txtSaleID.Text = sale.SaleID.ToString();
                txtStockID.Text = sale.StockID.ToString();
                txtQty.Text = sale.Qty.ToString();
                txtTotal.Text = sale.Total.ToString("0.00");
                txtSaleDate.Text =
                    sale.SaleDate.ToShortDateString();
            }
        }

        // Remove sale
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (sale == null)
            {
                MessageBox.Show(
                    "Please select a sale first.",
                    "Remove Sale",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove Sale " +
                sale.SaleID + "?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sale.RemoveSale();

                MessageBox.Show(
                    "Sale " + sale.SaleID +
                    " removed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                sale = null;

                txtSearch.Clear();
                txtSaleID.Clear();
                txtStockID.Clear();
                txtQty.Clear();
                txtTotal.Clear();
                txtSaleDate.Clear();

                grdSales.DataSource = null;
                grdSales.Visible = false;

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
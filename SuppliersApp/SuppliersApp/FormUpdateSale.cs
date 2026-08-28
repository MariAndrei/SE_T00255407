using System.Data;

using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormUpdateSale : Form
    {
        private FormSuppliersApp parent;
        private Sale sale;

        public FormUpdateSale()
        {
            InitializeComponent();

            grdSales.Visible = false;
            grpSale.Visible = false;
        }

        public FormUpdateSale(FormSuppliersApp Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdSales.Visible = false;
            grpSale.Visible = false;
        }

        // FORM LOAD
        private void FormUpdateSale_Load(object sender, EventArgs e)
        {
            // Load Stock into ComboBox
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

        // SEARCH USING ENTER
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataSet ds = Sale.FindSale(txtSearch.Text);

                grdSales.DataSource = ds.Tables[0];

                if (grdSales.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");

                    txtSearch.Focus();

                    return;
                }

                grdSales.Visible = true;
            }
        }

        // SELECT SALE FROM GRID
        private void grdSales_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get SaleID from first column
            int saleID = Convert.ToInt32(
                grdSales.Rows[e.RowIndex].Cells[0].Value
            );

            // Get sale from database
            sale = Sale.GetSale(saleID);

            if (sale == null)
            {
                MessageBox.Show("Sale not found.");
                return;
            }

            // Display sale information
            txtSaleID.Text = sale.SaleID.ToString();
            txtStockID.Text = sale.StockID.ToString();
            txtQty.Text = sale.Qty.ToString();
            txtTotal.Text = sale.Total.ToString("0.00");
            txtSaleDate.Text = sale.SaleDate.ToString("dd/MM/yyyy");


            for (int i = 0; i < cboStock.Items.Count; i++)
            {
                string item = cboStock.Items[i].ToString();

                if (item.StartsWith(sale.StockID + " -"))
                {
                    cboStock.SelectedIndex = i;
                    break;
                }
            }

           
            grpSale.Visible = true;
        }

        // CHANGE STOCK 
        private void cboStock_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboStock.SelectedIndex >= 0)
            {
                string selected = cboStock.SelectedItem.ToString();

                txtStockID.Text = selected.Split('-')[0].Trim();
            }
        }

        // UPDATE SALE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sale == null)
            {
                MessageBox.Show("Please search for and select a sale first.");
                return;
            }

            try
            {
                // Update Sale object
                sale.StockID = Convert.ToInt32(txtStockID.Text);
                sale.Qty = Convert.ToInt32(txtQty.Text);
                sale.Total = Convert.ToDecimal(txtTotal.Text);
                sale.SaleDate = DateTime.Parse(txtSaleDate.Text);

                // Update database
                sale.UpdateSale();

                MessageBox.Show(
                    "Sale Updated",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Reset form
                grpSale.Visible = false;
                grdSales.Visible = false;

                txtSearch.Clear();
                txtSaleID.Clear();
                txtStockID.Clear();
                txtQty.Clear();
                txtTotal.Clear();
                txtSaleDate.Clear();

                cboStock.SelectedIndex = -1;

                txtSearch.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numbers and a valid date.",
                    "Invalid Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // BACK
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Visible = true;
        }

        private void grdSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
using SuppliersApp;

namespace SuppliersApp
{
    public partial class FormAddStock : Form
    {
        public FormAddStock()
        {
            InitializeComponent();

        }

        private void FormAddStock_Load(object sender, EventArgs e)
        {
            txtStockID.Text = Stock.GetNextStockID().ToString("0000");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(
                Convert.ToInt32(txtStockID.Text),
                txtDescription.Text,
                Convert.ToDecimal(txtPrice.Text),
                Convert.ToInt32(txtQty.Text)
            );

            stock.AddStock();

            MessageBox.Show("Stock Added Successfully");

            txtStockID.Text = Stock.GetNextStockID().ToString("0000");
            txtDescription.Clear();
            txtPrice.Clear();
            txtQty.Clear();

            txtDescription.Focus();

        }

        private void mnuStripBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

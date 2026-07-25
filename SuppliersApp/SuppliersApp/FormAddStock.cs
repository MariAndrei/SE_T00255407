using SuppliersApp;

namespace SuppliersApp
{
    public partial class FormAddStock : Form
    {
        public FormAddStock()
        {
            InitializeComponent();
            txtStockID.Text = Stock.GetNextStockID().ToString("0000");
        }
        
    }
}

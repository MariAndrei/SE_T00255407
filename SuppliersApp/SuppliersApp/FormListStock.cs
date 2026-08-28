using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormListStock : Form
    {
        private FormSuppliersApp parent;

        public FormListStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormListStock_Load(object sender, EventArgs e)
        {
            // Get all suppliers from the database
            DataSet ds = Stock.GetAllStock();

            // Display the suppliers in the DataGridView
            grdStocks.DataSource = ds.Tables[0];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
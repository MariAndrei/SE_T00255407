using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormListSupplier : Form
    {
        private FormSuppliersApp parent;


        public FormListSupplier(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormListSupplier_Load(object sender, EventArgs e)
        {
            // Get all suppliers from the database
            DataSet ds = Supplier.GetAllSuppliers();

            // Display the suppliers in the DataGridView
            grdSuppliers.DataSource = ds.Tables[0];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

    }
}
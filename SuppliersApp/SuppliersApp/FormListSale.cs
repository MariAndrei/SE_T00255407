using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SuppliersApp
{
    public partial class FormListSale : Form
    {
        private FormSuppliersApp parent;

        public FormListSale(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormListSale_Load(object sender, EventArgs e)
        {
            // Get all suppliers from the database
            DataSet ds = Sale.GetAllSales();

            // Display the suppliers in the DataGridView
            grdSales.DataSource = ds.Tables[0];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}

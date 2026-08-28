using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormViewRevenue : Form
    {
        private FormSuppliersApp parent;

        public FormViewRevenue(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormViewRevenue_Load(object sender, EventArgs e)
        {
            DataSet ds = Revenue.GetAllRevenue();

            grdRevenue.DataSource = ds.Tables[0];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
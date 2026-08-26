using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormAddSupplier : Form
    {
        FormSuppliersApp parent;

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        public FormAddSupplier(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormAddSupplier_Load(object sender, EventArgs e)
        {
            // Get the next Supplier ID

            txtSupplierID.Text =
                Supplier.GetNextSupplierID().ToString("0000");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a Supplier object

            Supplier aSupplier = new Supplier(
                Convert.ToInt32(txtSupplierID.Text),
                txtName.Text,
                txtEmail.Text,
                txtPhone.Text
            );

            // Add Supplier to database

            aSupplier.AddSupplier();

            // Display confirmation

            MessageBox.Show(
                "Supplier " + txtSupplierID.Text +
                " added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Reset UI

            txtSupplierID.Text =
                Supplier.GetNextSupplierID().ToString("0000");

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtName.Focus();
        }
    }
}
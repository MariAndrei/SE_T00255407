using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormUpdateSupplier : Form
    {
        private FormSuppliersApp parent;
        private Supplier supplier;

        public FormUpdateSupplier(FormSuppliersApp Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdSuppliers.Visible = false;
            grpSupplier.Visible = false;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        // SEARCH SUPPLIER USING ENTER
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataSet ds = Supplier.FindSupplier(txtSearch.Text);

                grdSuppliers.DataSource = ds.Tables[0];

                if (grdSuppliers.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
                    txtSearch.Focus();
                    return;
                }

                grdSuppliers.Visible = true;
            }
        }

        // SELECT SUPPLIER FROM GRID
        private void grdSuppliers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get SupplierID
            int supplierID = Convert.ToInt32(
                grdSuppliers.Rows[e.RowIndex].Cells[0].Value
            );

            // Get the supplier 
            supplier = Supplier.GetSupplier(supplierID);

            if (supplier == null)
            {
                MessageBox.Show("Supplier not found.");
                return;
            }

            txtName.Text = supplier.Name;
            txtEmail.Text = supplier.Email;
            txtPhone.Text = supplier.Phone;
            txtManufacturer.Text = supplier.Manufacturer;

            // Show the update section
            grpSupplier.Visible = true;
        }

        // UPDATE SUPPLIER
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (supplier == null)
            {
                MessageBox.Show("Please search for and select a supplier first.");
                return;
            }

            // Update the Supplier
            supplier.Name = txtName.Text;
            supplier.Email = txtEmail.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Manufacturer = txtManufacturer.Text;

            // Update database
            supplier.UpdateSupplier();

            MessageBox.Show(
                "Supplier Updated",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Reset form
            grpSupplier.Visible = false;
            grdSuppliers.Visible = false;

            txtSearch.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtManufacturer.Clear();

            txtSearch.Focus();
        }

    }
}
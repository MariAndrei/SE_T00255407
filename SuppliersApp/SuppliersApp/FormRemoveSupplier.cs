using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormRemoveSupplier : Form
    {
        private FormSuppliersApp parent;
        private Supplier supplier;

        public FormRemoveSupplier(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FormRemoveSupplier_Load(object sender, EventArgs e)
        {
            grdSuppliers.Visible = false;
        }

        // Search when Enter is pressed
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataSet ds = Supplier.FindSupplier(txtSearch.Text);

                grdSuppliers.DataSource = ds.Tables[0];

                if (grdSuppliers.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No supplier found.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                grdSuppliers.Visible = true;
            }
        }

        // Select supplier
        private void grdSuppliers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int supplierID = Convert.ToInt32(
                grdSuppliers.Rows[e.RowIndex].Cells[0].Value);

            supplier = Supplier.GetSupplier(supplierID);

            if (supplier != null)
            {
                txtSuppID.Text =
                    supplier.SuppID.ToString();

                txtName.Text = supplier.Name;
                txtEmail.Text = supplier.Email;
                txtPhone.Text = supplier.Phone;
                txtManufacturer.Text = supplier.Manufacturer;
            }
        }

        // Remove supplier
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (supplier == null)
            {
                MessageBox.Show(
                    "Please search for and select a supplier first.",
                    "Remove Supplier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove Supplier " +
                supplier.SuppID + "?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                supplier.RemoveSupplier();

                MessageBox.Show(
                    "Supplier " + supplier.SuppID +
                    " removed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                supplier = null;

                txtSearch.Clear();
                txtSuppID.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtManufacturer.Clear();

                grdSuppliers.DataSource = null;
                grdSuppliers.Visible = false;

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
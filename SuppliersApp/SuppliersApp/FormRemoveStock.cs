using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormRemoveStock : Form
    {
        private FormSuppliersApp parent;

        public FormRemoveStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
    }
}
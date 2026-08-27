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
    }
}
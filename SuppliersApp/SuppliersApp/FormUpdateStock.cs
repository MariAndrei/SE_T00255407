using System;
using System.Data;
using System.Windows.Forms;

namespace SuppliersApp
{
    public partial class FormUpdateStock : Form
    {
        private FormSuppliersApp parent;

        public FormUpdateStock(FormSuppliersApp Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

    }
}
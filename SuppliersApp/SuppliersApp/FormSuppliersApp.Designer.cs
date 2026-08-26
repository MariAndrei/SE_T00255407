namespace SuppliersApp
{
    partial class FormSuppliersApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuStock = new ToolStripMenuItem();
            mnuAddStock = new ToolStripMenuItem();
            mnuUpdStock = new ToolStripMenuItem();
            mnuListStock = new ToolStripMenuItem();
            mnuRmvStock = new ToolStripMenuItem();
            mnuSupplier = new ToolStripMenuItem();
            mnuAddSupp = new ToolStripMenuItem();
            mnuUpdSupp = new ToolStripMenuItem();
            mnuListSupp = new ToolStripMenuItem();
            mnuRmvSupp = new ToolStripMenuItem();
            mnuSale = new ToolStripMenuItem();
            mnuAddSale = new ToolStripMenuItem();
            mnuUpdSale = new ToolStripMenuItem();
            mnuListSale = new ToolStripMenuItem();
            mnuRmvSale = new ToolStripMenuItem();
            mnuRevenue = new ToolStripMenuItem();
            mnuViewRevenue = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuStock, mnuSupplier, mnuSale, mnuRevenue, mnuExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuStock
            // 
            mnuStock.DropDownItems.AddRange(new ToolStripItem[] { mnuAddStock, mnuUpdStock, mnuListStock, mnuRmvStock });
            mnuStock.Name = "mnuStock";
            mnuStock.Size = new Size(48, 20);
            mnuStock.Text = "Stock";
            mnuStock.Click += mnuStock_Click;
            // 
            // mnuAddStock
            // 
            mnuAddStock.Name = "mnuAddStock";
            mnuAddStock.Size = new Size(180, 22);
            mnuAddStock.Text = "Add Stock";
            mnuAddStock.Click += mnuAddStock_Click;
            // 
            // mnuUpdStock
            // 
            mnuUpdStock.Name = "mnuUpdStock";
            mnuUpdStock.Size = new Size(180, 22);
            mnuUpdStock.Text = "Update Stock";
            mnuUpdStock.Click += mnuUpdStock_Click;
            // 
            // mnuListStock
            // 
            mnuListStock.Name = "mnuListStock";
            mnuListStock.Size = new Size(180, 22);
            mnuListStock.Text = "List Stock";
            mnuListStock.Click += mnuListStock_Click;
            // 
            // mnuRmvStock
            // 
            mnuRmvStock.Name = "mnuRmvStock";
            mnuRmvStock.Size = new Size(180, 22);
            mnuRmvStock.Text = "Remove Stock";
            mnuRmvStock.Click += mnuRmvStock_Click;
            // 
            // mnuSupplier
            // 
            mnuSupplier.DropDownItems.AddRange(new ToolStripItem[] { mnuAddSupp, mnuUpdSupp, mnuListSupp, mnuRmvSupp });
            mnuSupplier.Name = "mnuSupplier";
            mnuSupplier.Size = new Size(62, 20);
            mnuSupplier.Text = "Supplier";
            // 
            // mnuAddSupp
            // 
            mnuAddSupp.Name = "mnuAddSupp";
            mnuAddSupp.Size = new Size(163, 22);
            mnuAddSupp.Text = "Add Supplier";
            // 
            // mnuUpdSupp
            // 
            mnuUpdSupp.Name = "mnuUpdSupp";
            mnuUpdSupp.Size = new Size(163, 22);
            mnuUpdSupp.Text = "Update Supplier";
            // 
            // mnuListSupp
            // 
            mnuListSupp.Name = "mnuListSupp";
            mnuListSupp.Size = new Size(163, 22);
            mnuListSupp.Text = "List Supplier";
            // 
            // mnuRmvSupp
            // 
            mnuRmvSupp.Name = "mnuRmvSupp";
            mnuRmvSupp.Size = new Size(163, 22);
            mnuRmvSupp.Text = "Remove Supplier";
            // 
            // mnuSale
            // 
            mnuSale.DropDownItems.AddRange(new ToolStripItem[] { mnuAddSale, mnuUpdSale, mnuListSale, mnuRmvSale });
            mnuSale.Name = "mnuSale";
            mnuSale.Size = new Size(40, 20);
            mnuSale.Text = "Sale";
            // 
            // mnuAddSale
            // 
            mnuAddSale.Name = "mnuAddSale";
            mnuAddSale.Size = new Size(141, 22);
            mnuAddSale.Text = "Add Sale";
            // 
            // mnuUpdSale
            // 
            mnuUpdSale.Name = "mnuUpdSale";
            mnuUpdSale.Size = new Size(141, 22);
            mnuUpdSale.Text = "Update Sale";
            // 
            // mnuListSale
            // 
            mnuListSale.Name = "mnuListSale";
            mnuListSale.Size = new Size(141, 22);
            mnuListSale.Text = "List Sale";
            // 
            // mnuRmvSale
            // 
            mnuRmvSale.Name = "mnuRmvSale";
            mnuRmvSale.Size = new Size(141, 22);
            mnuRmvSale.Text = "Remove Sale";
            // 
            // mnuRevenue
            // 
            mnuRevenue.DropDownItems.AddRange(new ToolStripItem[] { mnuViewRevenue });
            mnuRevenue.Name = "mnuRevenue";
            mnuRevenue.Size = new Size(64, 20);
            mnuRevenue.Text = "Revenue";
            // 
            // mnuViewRevenue
            // 
            mnuViewRevenue.Name = "mnuViewRevenue";
            mnuViewRevenue.Size = new Size(147, 22);
            mnuViewRevenue.Text = "View Revenue";
            // 
            // mnuExit
            // 
            mnuExit.Alignment = ToolStripItemAlignment.Right;
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(37, 20);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // FormSuppliersApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormSuppliersApp";
            Text = "FormSuppliersApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuStock;
        private ToolStripMenuItem mnuAddStock;
        private ToolStripMenuItem mnuUpdStock;
        private ToolStripMenuItem mnuListStock;
        private ToolStripMenuItem mnuSupplier;
        private ToolStripMenuItem mnuAddSupp;
        private ToolStripMenuItem mnuUpdSupp;
        private ToolStripMenuItem mnuListSupp;
        private ToolStripMenuItem mnuSale;
        private ToolStripMenuItem mnuAddSale;
        private ToolStripMenuItem mnuUpdSale;
        private ToolStripMenuItem mnuListSale;
        private ToolStripMenuItem mnuRevenue;
        private ToolStripMenuItem mnuViewRevenue;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuRmvSupp;
        private ToolStripMenuItem mnuRmvSale;
        private ToolStripMenuItem mnuRmvStock;
    }
}
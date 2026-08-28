namespace SuppliersApp
{
    partial class FormListSale
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
            grdSales = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuBack = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdSales).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdSales
            // 
            grdSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSales.Location = new Point(78, 69);
            grdSales.Name = "grdSales";
            grdSales.Size = new Size(645, 312);
            grdSales.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            mnuBack.Alignment = ToolStripItemAlignment.Right;
            mnuBack.Name = "mnuBack";
            mnuBack.Size = new Size(44, 20);
            mnuBack.Text = "Back";
            mnuBack.Click += mnuBack_Click;
            // 
            // FormListSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdSales);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormListSale";
            Text = "FormListSale";
            Load += FormListSale_Load;
            ((System.ComponentModel.ISupportInitialize)grdSales).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSales;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
    }
}
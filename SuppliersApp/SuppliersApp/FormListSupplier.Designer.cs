namespace SuppliersApp
{
    partial class FormListSupplier
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
            grdSuppliers = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuBack = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdSuppliers
            // 
            grdSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSuppliers.Location = new Point(53, 59);
            grdSuppliers.Name = "grdSuppliers";
            grdSuppliers.Size = new Size(645, 312);
            grdSuppliers.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            mnuBack.Alignment = ToolStripItemAlignment.Right;
            mnuBack.Name = "mnuBack";
            mnuBack.Size = new Size(44, 20);
            mnuBack.Text = "Back";
            // 
            // FormListSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdSuppliers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormListSupplier";
            Text = "FormListSupplier";
            Load += FormListSupplier_Load_1;
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSuppliers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
    }
}
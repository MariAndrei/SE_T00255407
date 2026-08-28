namespace SuppliersApp
{
    partial class FormRemoveSale
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
            txtTotal = new TextBox();
            txtQty = new TextBox();
            txtStockID = new TextBox();
            lblTotal = new Label();
            lblQty = new Label();
            lblStockID = new Label();
            txtSaleDate = new TextBox();
            lblSaleDate = new Label();
            txtSaleID = new TextBox();
            lblSaleID = new Label();
            btnRemove = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            grdSales = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuBack = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdSales).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(124, 303);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 50;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(124, 274);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 49;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(124, 245);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 48;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 306);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 47;
            lblTotal.Text = "Total";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(19, 274);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 46;
            lblQty.Text = "Quantity";
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(19, 245);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 45;
            lblStockID.Text = "Stock ID";
            // 
            // txtSaleDate
            // 
            txtSaleDate.Location = new Point(124, 331);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.Size = new Size(100, 23);
            txtSaleDate.TabIndex = 44;
            // 
            // lblSaleDate
            // 
            lblSaleDate.AutoSize = true;
            lblSaleDate.Location = new Point(18, 332);
            lblSaleDate.Name = "lblSaleDate";
            lblSaleDate.Size = new Size(31, 15);
            lblSaleDate.TabIndex = 43;
            lblSaleDate.Text = "Date";
            // 
            // txtSaleID
            // 
            txtSaleID.Location = new Point(124, 213);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(100, 23);
            txtSaleID.TabIndex = 42;
            // 
            // lblSaleID
            // 
            lblSaleID.AutoSize = true;
            lblSaleID.Location = new Point(18, 216);
            lblSaleID.Name = "lblSaleID";
            lblSaleID.Size = new Size(42, 15);
            lblSaleID.TabIndex = 41;
            lblSaleID.Text = "Sale ID";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(349, 381);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 40;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(19, 35);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(28, 15);
            lblSearch.TabIndex = 39;
            lblSearch.Text = "Sale";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 38;
            // 
            // grdSales
            // 
            grdSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSales.Location = new Point(124, 66);
            grdSales.Name = "grdSales";
            grdSales.Size = new Size(494, 129);
            grdSales.TabIndex = 37;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 51;
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
            // FormRemoveSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtQty);
            Controls.Add(txtStockID);
            Controls.Add(lblTotal);
            Controls.Add(lblQty);
            Controls.Add(lblStockID);
            Controls.Add(txtSaleDate);
            Controls.Add(lblSaleDate);
            Controls.Add(txtSaleID);
            Controls.Add(lblSaleID);
            Controls.Add(btnRemove);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(grdSales);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRemoveSale";
            Text = "FormRemoveSale";
            Load += FormRemoveSale_Load;
            ((System.ComponentModel.ISupportInitialize)grdSales).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private TextBox txtQty;
        private TextBox txtStockID;
        private Label lblTotal;
        private Label lblQty;
        private Label lblStockID;
        private TextBox txtSaleDate;
        private Label lblSaleDate;
        private TextBox txtSaleID;
        private Label lblSaleID;
        private Button btnRemove;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView grdSales;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
    }
}
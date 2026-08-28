namespace SuppliersApp
{
    partial class FormUpdateSale
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
            mnuBack = new ToolStripMenuItem();
            grpSale = new GroupBox();
            txtCboStock = new Label();
            cboStock = new ComboBox();
            txtSaleDate = new TextBox();
            lblDate = new Label();
            btnUpdate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            txtQty = new TextBox();
            lblQty = new Label();
            txtSaleID = new TextBox();
            txtStockID = new TextBox();
            lblSaleID = new Label();
            lblStockID = new Label();
            grdSales = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            menuStrip1.SuspendLayout();
            grpSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSales).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
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
            // grpSale
            // 
            grpSale.Controls.Add(txtCboStock);
            grpSale.Controls.Add(cboStock);
            grpSale.Controls.Add(txtSaleDate);
            grpSale.Controls.Add(lblDate);
            grpSale.Controls.Add(btnUpdate);
            grpSale.Controls.Add(lblTotal);
            grpSale.Controls.Add(txtTotal);
            grpSale.Controls.Add(txtQty);
            grpSale.Controls.Add(lblQty);
            grpSale.Controls.Add(txtSaleID);
            grpSale.Controls.Add(txtStockID);
            grpSale.Controls.Add(lblSaleID);
            grpSale.Controls.Add(lblStockID);
            grpSale.Location = new Point(20, 207);
            grpSale.Name = "grpSale";
            grpSale.Size = new Size(602, 240);
            grpSale.TabIndex = 8;
            grpSale.TabStop = false;
            grpSale.Text = "Sale";
            // 
            // txtCboStock
            // 
            txtCboStock.AutoSize = true;
            txtCboStock.Location = new Point(264, 88);
            txtCboStock.Name = "txtCboStock";
            txtCboStock.Size = new Size(36, 15);
            txtCboStock.TabIndex = 16;
            txtCboStock.Text = "Stock";
            // 
            // cboStock
            // 
            cboStock.FormattingEnabled = true;
            cboStock.Location = new Point(318, 85);
            cboStock.Name = "cboStock";
            cboStock.Size = new Size(121, 23);
            cboStock.TabIndex = 15;
            cboStock.SelectedIndexChanged += cboStock_SelectedIndexChanged;
            // 
            // txtSaleDate
            // 
            txtSaleDate.Location = new Point(318, 34);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.Size = new Size(100, 23);
            txtSaleDate.TabIndex = 14;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(264, 34);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 13;
            lblDate.Text = "Date";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(264, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 148);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(100, 145);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(100, 107);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 9;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(6, 110);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(85, 15);
            lblQty.TabIndex = 8;
            lblQty.Text = "Stock Quantity";
            // 
            // txtSaleID
            // 
            txtSaleID.Location = new Point(100, 31);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(100, 23);
            txtSaleID.TabIndex = 7;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(100, 69);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 5;
            // 
            // lblSaleID
            // 
            lblSaleID.AutoSize = true;
            lblSaleID.Location = new Point(6, 34);
            lblSaleID.Name = "lblSaleID";
            lblSaleID.Size = new Size(42, 15);
            lblSaleID.TabIndex = 6;
            lblSaleID.Text = "Sale ID";
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(6, 72);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 5;
            lblStockID.Text = "Stock ID";
            // 
            // grdSales
            // 
            grdSales.AllowUserToAddRows = false;
            grdSales.AllowUserToDeleteRows = false;
            grdSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSales.Location = new Point(149, 85);
            grdSales.Name = "grdSales";
            grdSales.Size = new Size(414, 93);
            grdSales.TabIndex = 7;
            grdSales.CellClick += grdSales_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(149, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 47);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 15);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search Sale";
            // 
            // FormUpdateSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpSale);
            Controls.Add(grdSales);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormUpdateSale";
            Text = "FormUpdateSale";
            Load += FormUpdateSale_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpSale.ResumeLayout(false);
            grpSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private GroupBox grpSale;
        private Button btnUpdate;
        private Label lblTotal;
        private TextBox txtTotal;
        private TextBox txtQty;
        private Label lblQty;
        private TextBox txtSaleID;
        private TextBox txtStockID;
        private Label lblSaleID;
        private Label lblStockID;
        private DataGridView grdSales;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboStock;
        private TextBox txtSaleDate;
        private Label lblDate;
        private Label txtCboStock;
    }
}
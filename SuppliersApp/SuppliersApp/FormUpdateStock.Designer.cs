namespace SuppliersApp
{
    partial class FormUpdateStock
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
            grdStock = new DataGridView();
            btnUpdate = new Button();
            lblPrice = new Label();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            txtStockQty = new TextBox();
            txtSuppID = new TextBox();
            txtStockID = new TextBox();
            lblSuppID = new Label();
            lblStockID = new Label();
            lblSearch = new Label();
            lblQty = new Label();
            grpStock = new GroupBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblCboSupplier = new Label();
            cboSupplier = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdStock).BeginInit();
            grpStock.SuspendLayout();
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
            // grdStock
            // 
            grdStock.AllowUserToAddRows = false;
            grdStock.AllowUserToDeleteRows = false;
            grdStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdStock.Location = new Point(142, 69);
            grdStock.Name = "grdStock";
            grdStock.Size = new Size(414, 93);
            grdStock.TabIndex = 11;
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
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 174);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(142, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 10;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // txtStockQty
            // 
            txtStockQty.Location = new Point(100, 133);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(100, 23);
            txtStockQty.TabIndex = 9;
            // 
            // txtSuppID
            // 
            txtSuppID.Location = new Point(100, 31);
            txtSuppID.Name = "txtSuppID";
            txtSuppID.Size = new Size(100, 23);
            txtSuppID.TabIndex = 7;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(100, 69);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 5;
            // 
            // lblSuppID
            // 
            lblSuppID.AutoSize = true;
            lblSuppID.Location = new Point(6, 34);
            lblSuppID.Name = "lblSuppID";
            lblSuppID.Size = new Size(64, 15);
            lblSuppID.TabIndex = 6;
            lblSuppID.Text = "Supplier ID";
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 31);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 15);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search Stock";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(6, 136);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(85, 15);
            lblQty.TabIndex = 8;
            lblQty.Text = "Stock Quantity";
            // 
            // grpStock
            // 
            grpStock.Controls.Add(txtDescription);
            grpStock.Controls.Add(lblDescription);
            grpStock.Controls.Add(lblCboSupplier);
            grpStock.Controls.Add(cboSupplier);
            grpStock.Controls.Add(btnUpdate);
            grpStock.Controls.Add(lblPrice);
            grpStock.Controls.Add(txtPrice);
            grpStock.Controls.Add(txtStockQty);
            grpStock.Controls.Add(lblQty);
            grpStock.Controls.Add(txtSuppID);
            grpStock.Controls.Add(txtStockID);
            grpStock.Controls.Add(lblSuppID);
            grpStock.Controls.Add(lblStockID);
            grpStock.Location = new Point(13, 191);
            grpStock.Name = "grpStock";
            grpStock.Size = new Size(602, 240);
            grpStock.TabIndex = 12;
            grpStock.TabStop = false;
            grpStock.Text = "Stock";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 101);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 16;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 104);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description";
            // 
            // lblCboSupplier
            // 
            lblCboSupplier.AutoSize = true;
            lblCboSupplier.Location = new Point(264, 34);
            lblCboSupplier.Name = "lblCboSupplier";
            lblCboSupplier.Size = new Size(50, 15);
            lblCboSupplier.TabIndex = 14;
            lblCboSupplier.Text = "Supplier";
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(343, 31);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(121, 23);
            cboSupplier.TabIndex = 13;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // FormUpdateStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdStock);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(grpStock);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormUpdateStock";
            Text = "FormUpdateStock";
            Load += FormUpdateStock_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdStock).EndInit();
            grpStock.ResumeLayout(false);
            grpStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private DataGridView grdStock;
        private Button btnUpdate;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtSearch;
        private TextBox txtStockQty;
        private TextBox txtSuppID;
        private TextBox txtStockID;
        private Label lblSuppID;
        private Label lblStockID;
        private Label lblSearch;
        private Label lblQty;
        private GroupBox grpStock;
        private Label lblCboSupplier;
        private ComboBox cboSupplier;
        private TextBox txtDescription;
        private Label lblDescription;
    }
}
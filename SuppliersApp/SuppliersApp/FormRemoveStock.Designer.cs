namespace SuppliersApp
{
    partial class FormRemoveStock
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
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnRemove = new Button();
            lblStockID = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblStockQty = new Label();
            lblSuppID = new Label();
            txtStockID = new TextBox();
            txtSuppID = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtStockQty = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdStock).BeginInit();
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
            grdStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdStock.Location = new Point(144, 56);
            grdStock.Name = "grdStock";
            grdStock.Size = new Size(494, 129);
            grdStock.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(117, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(48, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(36, 15);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Stock";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(359, 372);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(48, 212);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 5;
            lblStockID.Text = "Stock ID";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(48, 282);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(48, 316);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Location = new Point(48, 353);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(85, 15);
            lblStockQty.TabIndex = 8;
            lblStockQty.Text = "Stock Quantity";
            // 
            // lblSuppID
            // 
            lblSuppID.AutoSize = true;
            lblSuppID.Location = new Point(48, 248);
            lblSuppID.Name = "lblSuppID";
            lblSuppID.Size = new Size(64, 15);
            lblSuppID.TabIndex = 9;
            lblSuppID.Text = "Supplier ID";
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(154, 209);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 10;
            // 
            // txtSuppID
            // 
            txtSuppID.Location = new Point(154, 245);
            txtSuppID.Name = "txtSuppID";
            txtSuppID.Size = new Size(100, 23);
            txtSuppID.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(154, 280);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(154, 314);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtStockQty
            // 
            txtStockQty.Location = new Point(154, 352);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(100, 23);
            txtStockQty.TabIndex = 14;
            // 
            // FormRemoveStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStockQty);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtSuppID);
            Controls.Add(txtStockID);
            Controls.Add(lblSuppID);
            Controls.Add(lblStockQty);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblStockID);
            Controls.Add(btnRemove);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(grdStock);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRemoveStock";
            Text = "FormRemoveStock";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private DataGridView grdStock;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnRemove;
        private Label lblStockID;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblStockQty;
        private Label lblSuppID;
        private TextBox txtStockID;
        private TextBox txtSuppID;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtStockQty;
    }
}
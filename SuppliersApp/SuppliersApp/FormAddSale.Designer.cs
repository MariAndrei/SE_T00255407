namespace SuppliersApp
{
    partial class FormAddSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed otherwise, false.
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
            lblSaleID = new Label();
            lblStockID = new Label();
            lblQty = new Label();
            txtSaleID = new TextBox();
            txtStockID = new TextBox();
            txtQty = new TextBox();
            btnAdd = new Button();
            dtpSaleDate = new DateTimePicker();
            lblDate = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            menuStrip1 = new MenuStrip();
            mnuBack = new ToolStripMenuItem();
            cboStock = new ComboBox();
            lblStock = new Label();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // lblSaleID
            // 
            lblSaleID.AutoSize = true;
            lblSaleID.Location = new Point(44, 52);
            lblSaleID.Name = "lblSaleID";
            lblSaleID.Size = new Size(50, 15);
            lblSaleID.TabIndex = 0;
            lblSaleID.Text = "Sale ID";

            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(44, 101);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 1;
            lblStockID.Text = "Stock ID";

            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(41, 214);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 2;
            lblQty.Text = "Quantity";

            // 
            // txtSaleID
            // 
            txtSaleID.Location = new Point(140, 49);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(100, 23);
            txtSaleID.TabIndex = 3;

            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(140, 98);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 4;

            // 
            // txtQty
            // 
            txtQty.Location = new Point(140, 211);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 6;

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(365, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Sale";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(140, 320);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(200, 23);
            dtpSaleDate.TabIndex = 9;

            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 326);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 10;
            lblDate.Text = "Date";

            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(41, 266);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total";

            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(140, 263);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;

            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
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
            // cboStock
            // 
            cboStock.FormattingEnabled = true;
            cboStock.Location = new Point(140, 155);
            cboStock.Name = "cboStock";
            cboStock.Size = new Size(200, 23);
            cboStock.TabIndex = 5;
            cboStock.SelectedIndexChanged += cboStock_SelectedIndexChanged;

            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(44, 158);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock";

            // 
            // FormAddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(lblStock);
            Controls.Add(cboStock);
            Controls.Add(txtSaleID);
            Controls.Add(lblSaleID);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblDate);
            Controls.Add(dtpSaleDate);
            Controls.Add(btnAdd);
            Controls.Add(txtQty);
            Controls.Add(txtStockID);
            Controls.Add(lblQty);
            Controls.Add(lblStockID);
            Controls.Add(menuStrip1);

            MainMenuStrip = menuStrip1;
            Name = "FormAddSale";
            Text = "Add Sale";

            Load += FormAddSale_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaleID;
        private Label lblStockID;
        private Label lblQty;
        private TextBox txtSaleID;
        private TextBox txtStockID;
        private TextBox txtQty;
        private Button btnAdd;
        private DateTimePicker dtpSaleDate;
        private Label lblDate;
        private Label lblTotal;
        private TextBox txtTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private ComboBox cboStock;
        private Label lblStock;
    }
}
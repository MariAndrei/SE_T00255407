namespace SuppliersApp
{
    partial class FormAddStock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtQty = new TextBox();
            txtStockID = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            mnuStrip = new MenuStrip();
            mnuStripBack = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            lblStockID = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            cboSupplier = new ComboBox();
            lblSupplier = new Label();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtQty
            // 
            txtQty.Location = new Point(126, 314);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 1;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(126, 116);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(126, 179);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 244);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(344, 381);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // mnuStrip
            // 
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuStripBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(800, 24);
            mnuStrip.TabIndex = 6;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuStripBack
            // 
            mnuStripBack.Alignment = ToolStripItemAlignment.Right;
            mnuStripBack.Name = "mnuStripBack";
            mnuStripBack.Size = new Size(44, 20);
            mnuStripBack.Text = "Back";
            mnuStripBack.Click += mnuBack_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(49, 122);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 8;
            lblStockID.Text = "Stock ID";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(49, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(49, 247);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(49, 317);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 11;
            lblQty.Text = "Quantity";
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(344, 53);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(121, 23);
            cboSupplier.TabIndex = 12;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(255, 56);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(55, 15);
            lblSupplier.TabIndex = 13;
            lblSupplier.Text = "Suppliers";
            // 
            // FormAddStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSupplier);
            Controls.Add(cboSupplier);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblStockID);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtStockID);
            Controls.Add(txtQty);
            Controls.Add(mnuStrip);
            MainMenuStrip = mnuStrip;
            Name = "FormAddStock";
            Text = "Add Stock";
            Load += FormAddStock_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtQty;
        private TextBox txtStockID;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnAdd;
        private MenuStrip mnuStrip;
        private ContextMenuStrip contextMenuStrip2;
        private Label lblStockID;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQty;
        private ToolStripMenuItem mnuStripBack;
        private ComboBox cboSupplier;
        private Label lblSupplier;
    }
}

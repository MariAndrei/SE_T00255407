namespace SuppliersApp
{
    partial class FormAddSupplier
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtStockID = new TextBox();
            txtQty = new TextBox();
            mnuStrip = new MenuStrip();
            mnuStripBack = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            lblQty = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            lblStockID = new Label();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(344, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(122, 251);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(122, 186);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 14;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(122, 123);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 13;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(122, 321);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 12;
            // 
            // mnuStrip
            // 
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuStripBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(800, 24);
            mnuStrip.TabIndex = 17;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuStripBack
            // 
            mnuStripBack.Alignment = ToolStripItemAlignment.Right;
            mnuStripBack.Name = "mnuStripBack";
            mnuStripBack.Size = new Size(44, 20);
            mnuStripBack.Text = "Back";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(45, 324);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 21;
            lblQty.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(45, 254);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(45, 189);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 19;
            lblDescription.Text = "Description";
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(45, 129);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(45, 15);
            lblStockID.TabIndex = 18;
            lblStockID.Text = "SuppID";
            // 
            // FormAddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtStockID);
            Controls.Add(txtQty);
            Controls.Add(mnuStrip);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblStockID);
            Name = "FormAddSupplier";
            Text = "FormAddSupplier";
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtStockID;
        private TextBox txtQty;
        private MenuStrip mnuStrip;
        private ToolStripMenuItem mnuStripBack;
        private ContextMenuStrip contextMenuStrip2;
        private Label lblQty;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblStockID;
    }
}
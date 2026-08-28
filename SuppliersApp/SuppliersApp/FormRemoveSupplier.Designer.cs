namespace SuppliersApp
{
    partial class FormRemoveSupplier
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
            txtSuppID = new TextBox();
            lblSuppID = new Label();
            btnRemove = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            grdSuppliers = new DataGridView();
            txtManufacturer = new TextBox();
            lblManufacturer = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).BeginInit();
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
            // txtSuppID
            // 
            txtSuppID.Location = new Point(135, 208);
            txtSuppID.Name = "txtSuppID";
            txtSuppID.Size = new Size(100, 23);
            txtSuppID.TabIndex = 25;
            // 
            // lblSuppID
            // 
            lblSuppID.AutoSize = true;
            lblSuppID.Location = new Point(29, 211);
            lblSuppID.Name = "lblSuppID";
            lblSuppID.Size = new Size(64, 15);
            lblSuppID.TabIndex = 23;
            lblSuppID.Text = "Supplier ID";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(350, 377);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(30, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(50, 15);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Supplier";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(99, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 16;
            // 
            // grdSuppliers
            // 
            grdSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSuppliers.Location = new Point(135, 61);
            grdSuppliers.Name = "grdSuppliers";
            grdSuppliers.Size = new Size(494, 129);
            grdSuppliers.TabIndex = 15;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(135, 326);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(100, 23);
            txtManufacturer.TabIndex = 30;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(29, 327);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 29;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 240);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 31;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 269);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 32;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(29, 301);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 33;
            lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 240);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 35;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 298);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 36;
            // 
            // FormRemoveSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(txtManufacturer);
            Controls.Add(lblManufacturer);
            Controls.Add(txtSuppID);
            Controls.Add(lblSuppID);
            Controls.Add(btnRemove);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(grdSuppliers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRemoveSupplier";
            Text = "FormRemoveSupplier";
            Load += FormRemoveSupplier_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private TextBox txtStockQty;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtSuppID;
        private TextBox txtStockID;
        private Label lblSuppID;
        private Label lblStockQty;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblSiID;
        private Button btnRemove;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView grdSuppliers;
        private TextBox txtManufacturer;
        private Label lblManufacturer;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
    }
}
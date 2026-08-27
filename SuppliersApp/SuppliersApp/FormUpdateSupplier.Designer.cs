namespace SuppliersApp
{
    partial class FormUpdateSupplier
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            grdSuppliers = new DataGridView();
            grpSupplier = new GroupBox();
            btnUpdate = new Button();
            lblManufacturer = new Label();
            txtManufacturer = new TextBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblEmail = new Label();
            lblName = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).BeginInit();
            grpSupplier.SuspendLayout();
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(41, 49);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(88, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Supplier";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // grdSuppliers
            // 
            grdSuppliers.AllowUserToAddRows = false;
            grdSuppliers.AllowUserToDeleteRows = false;
            grdSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSuppliers.Location = new Point(170, 87);
            grdSuppliers.Name = "grdSuppliers";
            grdSuppliers.Size = new Size(414, 93);
            grdSuppliers.TabIndex = 3;
            grdSuppliers.CellContentClick += grdSuppliers_CellContentClick;
            // 
            // grpSupplier
            // 
            grpSupplier.Controls.Add(btnUpdate);
            grpSupplier.Controls.Add(lblManufacturer);
            grpSupplier.Controls.Add(txtManufacturer);
            grpSupplier.Controls.Add(txtPhone);
            grpSupplier.Controls.Add(lblPhone);
            grpSupplier.Controls.Add(txtEmail);
            grpSupplier.Controls.Add(txtName);
            grpSupplier.Controls.Add(lblEmail);
            grpSupplier.Controls.Add(lblName);
            grpSupplier.Location = new Point(41, 209);
            grpSupplier.Name = "grpSupplier";
            grpSupplier.Size = new Size(602, 229);
            grpSupplier.TabIndex = 4;
            grpSupplier.TabStop = false;
            grpSupplier.Text = "Supplier";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(255, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(6, 148);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 11;
            lblManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(100, 145);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(100, 23);
            txtManufacturer.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(100, 107);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(6, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // FormUpdateSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpSupplier);
            Controls.Add(grdSuppliers);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormUpdateSupplier";
            Text = "FormUpdateSupplier";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSuppliers).EndInit();
            grpSupplier.ResumeLayout(false);
            grpSupplier.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBack;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView grdSuppliers;
        private GroupBox grpSupplier;
        private Label lblManufacturer;
        private TextBox txtManufacturer;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblEmail;
        private Label lblName;
        private Button btnUpdate;
    }
}
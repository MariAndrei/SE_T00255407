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
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtSupplierID = new TextBox();
            txtPhone = new TextBox();
            mnuStrip = new MenuStrip();
            mnuBack = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblSupplierID = new Label();
            lblManufacturer = new Label();
            txtManufacturer = new TextBox();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(337, 326);
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
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(152, 56);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(100, 23);
            txtSupplierID.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(152, 191);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 12;
            // 
            // mnuStrip
            // 
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(800, 24);
            mnuStrip.TabIndex = 17;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            mnuBack.Alignment = ToolStripItemAlignment.Right;
            mnuBack.Name = "mnuBack";
            mnuBack.Size = new Size(44, 20);
            mnuBack.Text = "Back";
            mnuBack.Click += mnuBack_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(42, 194);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 21;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 103);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Location = new Point(38, 62);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(45, 15);
            lblSupplierID.TabIndex = 18;
            lblSupplierID.Text = "SuppID";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(42, 239);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(92, 15);
            lblManufacturer.TabIndex = 22;
            lblManufacturer.Text = "lblManufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(152, 236);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(100, 23);
            txtManufacturer.TabIndex = 23;
            // 
            // FormAddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtManufacturer);
            Controls.Add(lblManufacturer);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtSupplierID);
            Controls.Add(txtPhone);
            Controls.Add(mnuStrip);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblSupplierID);
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
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtSupplierID;
        private TextBox txtPhone;
        private MenuStrip mnuStrip;
        private ToolStripMenuItem mnuBack;
        private ContextMenuStrip contextMenuStrip2;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblName;
        private Label lblSupplierID;
        private Label lblManufacturer;
        private TextBox txtManufacturer;
    }
}
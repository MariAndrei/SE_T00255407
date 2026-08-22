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
            lblStockID = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            txtStockID = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblStockID
            // 
            lblStockID.AutoSize = true;
            lblStockID.Location = new Point(44, 92);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(50, 15);
            lblStockID.TabIndex = 9;
            lblStockID.Text = "Stock ID";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(44, 149);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(44, 203);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(44, 267);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 12;
            lblQty.Text = "Quantity";
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(140, 89);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(100, 23);
            txtStockID.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(365, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtStockID);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblStockID);
            Name = "FormAddSale";
            Text = "Add Sale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStockID;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQty;
        private TextBox txtStockID;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
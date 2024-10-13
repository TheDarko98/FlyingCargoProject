namespace FlyingCargoProject.Gui
{
    partial class AddProductForm
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
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtStockQuantity = new TextBox();
            btnSubmit = new Button();
            rtbDescription = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(51, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 23);
            txtProductName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(51, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(51, 172);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(151, 23);
            txtStockQuantity.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(84, 348);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(51, 226);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(151, 96);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 50);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 102);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 154);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 8;
            label3.Text = "Stock Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 208);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 383);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbDescription);
            Controls.Add(btnSubmit);
            Controls.Add(txtStockQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtStockQuantity;
        private Button btnSubmit;
        private RichTextBox rtbDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
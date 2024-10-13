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
            txtDescription = new TextBox();
            txtStockQuantity = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(51, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(151, 23);
            txtProductName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(51, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(151, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(51, 126);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(151, 23);
            txtDescription.TabIndex = 2;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(51, 155);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.PlaceholderText = "Stock Quantity";
            txtStockQuantity.Size = new Size(151, 23);
            txtStockQuantity.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(87, 184);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 295);
            Controls.Add(btnSubmit);
            Controls.Add(txtStockQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtStockQuantity;
        private Button btnSubmit;
    }
}
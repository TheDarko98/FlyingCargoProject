namespace FlyingCargoProject.Gui
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            btnLoadProducts = new Button();
            btnAddProducts = new Button();
            btnUpdateProducts = new Button();
            btnDeleteProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(739, 192);
            dataGridView1.TabIndex = 0;
            // 
            // btnLoadProducts
            // 
            btnLoadProducts.Location = new Point(12, 298);
            btnLoadProducts.Name = "btnLoadProducts";
            btnLoadProducts.Size = new Size(114, 23);
            btnLoadProducts.TabIndex = 1;
            btnLoadProducts.Text = "Load Products";
            btnLoadProducts.UseVisualStyleBackColor = true;
            btnLoadProducts.Click += btnLoadProducts_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new Point(172, 298);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(111, 23);
            btnAddProducts.TabIndex = 2;
            btnAddProducts.Text = "Add Products";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnUpdateProducts
            // 
            btnUpdateProducts.Location = new Point(304, 298);
            btnUpdateProducts.Name = "btnUpdateProducts";
            btnUpdateProducts.Size = new Size(116, 23);
            btnUpdateProducts.TabIndex = 3;
            btnUpdateProducts.Text = "Update Products";
            btnUpdateProducts.UseVisualStyleBackColor = true;
            btnUpdateProducts.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Location = new Point(484, 298);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(143, 23);
            btnDeleteProducts.TabIndex = 4;
            btnDeleteProducts.Text = "Delete products";
            btnDeleteProducts.UseVisualStyleBackColor = true;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteProducts);
            Controls.Add(btnUpdateProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(btnLoadProducts);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLoadProducts;
        private Button btnAddProducts;
        private Button btnUpdateProducts;
        private Button btnDeleteProducts;
    }
}

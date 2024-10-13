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
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(672, 192);
            dataGridView1.TabIndex = 0;
            // 
            // btnLoadProducts
            // 
            btnLoadProducts.Location = new Point(6, 415);
            btnLoadProducts.Name = "btnLoadProducts";
            btnLoadProducts.Size = new Size(165, 23);
            btnLoadProducts.TabIndex = 1;
            btnLoadProducts.Text = "Load Products";
            btnLoadProducts.UseVisualStyleBackColor = true;
            btnLoadProducts.Click += btnLoadProducts_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new Point(177, 415);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(165, 23);
            btnAddProducts.TabIndex = 2;
            btnAddProducts.Text = "Add Products";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnUpdateProducts
            // 
            btnUpdateProducts.Location = new Point(348, 415);
            btnUpdateProducts.Name = "btnUpdateProducts";
            btnUpdateProducts.Size = new Size(165, 23);
            btnUpdateProducts.TabIndex = 3;
            btnUpdateProducts.Text = "Update Products";
            btnUpdateProducts.UseVisualStyleBackColor = true;
            btnUpdateProducts.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Location = new Point(519, 415);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(165, 23);
            btnDeleteProducts.TabIndex = 4;
            btnDeleteProducts.Text = "Delete products";
            btnDeleteProducts.UseVisualStyleBackColor = true;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 23);
            txtSearch.TabIndex = 7;
            txtSearch.Text = placeholderText;
            txtSearch.ForeColor = Color.Gray;  
            txtSearch.Enter += TxtSearch_Enter;  
            txtSearch.Leave += TxtSearch_Leave; 
            this.Controls.Add(txtSearch);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(177, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteProducts);
            Controls.Add(btnUpdateProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(btnLoadProducts);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLoadProducts;
        private Button btnAddProducts;
        private Button btnUpdateProducts;
        private Button btnDeleteProducts;
        private TextBox txtSearch;
        private Button btnSearch;
        private string placeholderText = "Search products...";


        #region Event handlers
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;  
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholderText;    
                txtSearch.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}

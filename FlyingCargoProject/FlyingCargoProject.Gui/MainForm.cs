using FlyingCargoProject.Api.DTOs;

namespace FlyingCargoProject.Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLoadProducts_Click(object sender, EventArgs e)
        {
            try
            {
                var productService = new ProductService();

                var products = await productService.GetProductsAsync();

                dataGridView1.DataSource = products.ToList();
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private async void btnAddProducts_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newProduct = new ProductDTO
                    {
                        ProductName = addProductForm.ProductName,
                        Price = addProductForm.Price,
                        Description = addProductForm.Description,
                        StockQuantity = addProductForm.StockQuantity
                    };

                    var productService = new ProductService();
                    await productService.AddProductAsync(newProduct);

                    await LoadProductsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding product: {ex.Message}");
                }
            }
        }
        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            try
            {
                int selectedProductId = (int)dataGridView1.SelectedRows[0].Cells["ProductId"].Value;

                var selectedProduct = new ProductDTO
                {
                    ProductId = selectedProductId,
                    ProductName = dataGridView1.SelectedRows[0].Cells["ProductName"].Value.ToString(),
                    Price = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Price"].Value),
                    Description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString(),
                    StockQuantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StockQuantity"].Value)
                };

                var updateForm = new AddProductForm();
                updateForm.SetProductData(selectedProduct);
                updateForm.SetProductId(selectedProductId);

                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    var updatedProduct = new ProductDTO
                    {
                        ProductId = updateForm.ProductId.Value,
                        ProductName = updateForm.ProductName,
                        Price = updateForm.Price,
                        Description = updateForm.Description,
                        StockQuantity = updateForm.StockQuantity
                    };

                    var productService = new ProductService();
                    await productService.UpdateProductAsync(updatedProduct);

                    await LoadProductsAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private async void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int selectedProductId = (int)dataGridView1.SelectedRows[0].Cells["ProductId"].Value;

            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var productService = new ProductService();
                    await productService.DeleteProductAsync(selectedProductId);

                    await LoadProductsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}");
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var searchTerm = txtSearch.Text.Trim(); 
                var productService = new ProductService();

                var products = await productService.GetProductsAsync(searchTerm);  

                dataGridView1.DataSource = products.ToList();
                CustomizeDataGridView(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        #region Helpers
        private async Task LoadProductsAsync()
        {
            try
            {
                var productService = new ProductService();

                var products = await productService.GetProductsAsync();

                dataGridView1.DataSource = products.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        private void CustomizeDataGridView()
        {
            dataGridView1.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns["Description"].Width = 200;
        }
        #endregion
    }
}
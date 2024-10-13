using FlyingCargoProject.Api.DTOs;

namespace FlyingCargoProject.Gui
{
    public partial class AddProductForm : Form
    {
        public int? ProductId { get; private set; }
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public int StockQuantity { get; private set; }

        public AddProductForm()
        {
            InitializeComponent();
        }

        public void SetProductId(int productId)
        {
            ProductId = productId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ProductName = txtProductName.Text;
                Price = decimal.Parse(txtPrice.Text);
                Description = rtbDescription.Text;
                StockQuantity = int.Parse(txtStockQuantity.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #region Helpers 

        // This method pre-fills the form with existing product data forr updates
        public void SetProductData(ProductDTO product)
        {
            txtProductName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString();
            rtbDescription.Text = product.Description;
            txtStockQuantity.Text = product.StockQuantity.ToString();

            SetProductId(product.ProductId);
        }

        #endregion
    }
}
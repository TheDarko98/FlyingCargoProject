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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;  
            }

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
        public void SetProductId(int productId)
        {
            ProductId = productId;
        }
        // This method pre-fills the form with existing product data forr updates
        public void SetProductData(ProductDTO product)
        {
            txtProductName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString();
            rtbDescription.Text = product.Description;
            txtStockQuantity.Text = product.StockQuantity.ToString();

            SetProductId(product.ProductId);
        }
        // Centralized validation method
        private bool ValidateForm()
        {
            var controlsToValidate = new Dictionary<string, Control>
            {
                { "Product Name", txtProductName },
                { "Price", txtPrice },
                { "Description", rtbDescription },
                { "Stock Quantity", txtStockQuantity }
            };

            foreach (var control in controlsToValidate)
            {
                if (string.IsNullOrWhiteSpace(control.Value.Text))
                {
                    MessageBox.Show($"{control.Key} is required.");
                    control.Value.Focus();
                    return false;
                }
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("A valid Price is required.");
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtStockQuantity.Text, out _))
            {
                MessageBox.Show("A valid Stock Quantity is required.");
                txtStockQuantity.Focus();
                return false;
            }

            return true;
        }

        #endregion
    }
}
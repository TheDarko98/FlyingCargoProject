using System.Net.Http.Json;
using FlyingCargoProject.Api.DTOs;

namespace FlyingCargoProject.Gui
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7204/api/") 
            };
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("products");

         
            response.EnsureSuccessStatusCode();

            var products = await response.Content.ReadFromJsonAsync<IEnumerable<ProductDTO>>();
            return products;
        }


        public async Task AddProductAsync(ProductDTO product)
        {
            var response = await _httpClient.PostAsJsonAsync("products", product);

            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProductAsync(ProductDTO product)
        {
            var response = await _httpClient.PutAsJsonAsync($"products/{product.ProductId}", product);

            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProductAsync(int productId)
        {
            var response = await _httpClient.DeleteAsync($"products/{productId}");

            response.EnsureSuccessStatusCode();
        }
    }
}
using System.Text.Json;
using VShop.Web.Models.Views;
using VShop.Web.Services.Interfaces;

namespace VShop.Web.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private const string apiEndpoint = "api/products";
        private readonly JsonSerializerOptions options;
        private ProductViewModel productVM;
        private IEnumerable<ProductViewModel> _productsVM;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            this.options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
        public Task<ProductViewModel> FindProductById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ProductViewModel> CreateProduct(ProductViewModel productVM)
        {
            throw new NotImplementedException();
        }
        public Task<ProductViewModel> UpdateProduct(ProductViewModel productVM)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

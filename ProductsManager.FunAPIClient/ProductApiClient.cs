using Microsoft.Extensions.Logging;
using ProductsManager.Core.Entities;
using ProductsManager.Core.Interfaces;
using ProductsManager.FunAPIClient.Dto;
using System.Net.Http.Json;

namespace ProductsManager.FunAPIClient
{
    public class ProductApiClient : IProductService
    {
        private readonly ILogger<ProductApiClient> _logger;
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        public readonly Uri _baseUri;
        public ProductApiClient(HttpClient httpClient, Uri baseUri, string apiKey, ILogger<ProductApiClient> logger)
        {
            ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

            _httpClient = httpClient;
            _baseUri = baseUri;
            _apiKey = apiKey;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            string apiUrl;
            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                apiUrl = $"{_baseUri}api/products";
            }
            else
            {
                apiUrl = $"{_baseUri}api/products?code={_apiKey}";
            }

            var response = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>(apiUrl);
            if (response != null && response.Any())
            {
                return response.Select(p => p.ToEntity());
            }
            return new List<Product>();
        }

        public Task<bool> UpdateProductStock(int id, int stock, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ProductsManager.Core.Interfaces;
using ProductsManager.FunAPIClient.Dto;

namespace ProductsManager.FuncAPI
{
    public class GetProducts
    {
        private readonly ILogger<GetProducts> _logger;
        private readonly IProductService _productsService;

        public GetProducts(IProductService productService, ILogger<GetProducts> logger)
        {
            _logger = logger;
            _productsService = productService;
        }

        [Function("GetProducts")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get",Route="products")] HttpRequest req)
        {
            _logger.LogInformation("Get products");

            var products = await _productsService.GetProductsAsync();

            return new OkObjectResult(products.Select(p=> new ProductDto(p)));
        }
    }
}

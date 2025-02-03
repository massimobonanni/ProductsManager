using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ProductsManager.Core.Interfaces;

namespace ProductsManager.FuncAPI
{
    public class OrderManager
    {
        private readonly ILogger<OrderManager> _logger;
        private readonly IProductService _productsService;
        public OrderManager(IProductService productService,ILogger<OrderManager> logger)
        {
            _logger = logger;
            _productsService = productService;
        }

        //[Function(nameof(OrderManager))]
        //public async Task Run([BlobTrigger("orders/{name}", Connection = "OrderStorageConnection")] Stream stream, string name)
        //{
        //    _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name}");

        //    using var blobStreamReader = new StreamReader(stream);
        //    var content = await blobStreamReader.ReadToEndAsync();

        //    // Split the content by lines
        //    var lines = content.Split('\n');

        //    // Remove the header row
        //    var dataLines = lines.Skip(1);

        //    foreach (var line in dataLines)
        //    {
        //        // Process each line of CSV data
        //        var columns = line.Split('|');

        //        if (columns.Length < 2)
        //        {
        //            _logger.LogWarning("Invalid data format.");
        //            continue;
        //        }

        //        if (int.TryParse(columns[0], out int productId) && int.TryParse(columns[1], out int unitsToRemove))
        //        {
        //            var success = await _productsService.UpdateProductStock(productId, -unitsToRemove);
        //            if (success)
        //            {
        //                _logger.LogInformation($"Updated product {productId} stock by removing {unitsToRemove} units.");
        //            }
        //            else
        //            {
        //                _logger.LogWarning($"Failed to update product {productId} stock.");
        //            }
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Invalid product ID or units to remove.");
        //        }
        //    }
        //}
    }
}

using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ProductsManager.Core.Interfaces;
using ProductsManager.FuncAPI.Messages;
using System.Text.Json;

namespace ProductsManager.FuncAPI
{
    public class UpdateStocksFromLogistics
    {
        private readonly ILogger<UpdateStocksFromLogistics> _logger;
        private readonly IProductService _productsService;

        public UpdateStocksFromLogistics(IProductService productService, ILogger<UpdateStocksFromLogistics> logger)
        {
            _logger = logger;
            _productsService = productService;
        }

        //[Function(nameof(UpdateStocksFromLogistics))]
        //public async Task Run([QueueTrigger("logisticsqueue", Connection = "LogisticStorageConnection")] QueueMessage message)
        //{
        //    _logger.LogInformation($"C# Queue trigger function processed: {message.MessageText}");

        //    try
        //    {
        //        var updateData = JsonSerializer.Deserialize<UpdateStocksFromLogisticsData>(message.MessageText);
        //        if (updateData != null)
        //        {
        //            // Process the updateData here
        //            _logger.LogInformation($"ProductId: {updateData.ProductId}, Stock: {updateData.Stock}");

        //            var result = await _productsService.UpdateProductStock(updateData.ProductId, updateData.Stock);

        //            if (!result)
        //                _logger.LogError($"Error updating stock for product {updateData.ProductId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Deserialized message is null.");
        //        }
        //    }
        //    catch (JsonException ex)
        //    {
        //        _logger.LogError($"Error deserializing message: {ex.Message}");
        //    }
        //}
    }
}

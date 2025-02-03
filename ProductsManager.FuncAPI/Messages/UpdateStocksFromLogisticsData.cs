using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductsManager.FuncAPI.Messages
{
    internal class UpdateStocksFromLogisticsData
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("stock")]
        public int Stock { get; set; }
    }
}

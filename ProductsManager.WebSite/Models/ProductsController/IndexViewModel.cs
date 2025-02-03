using ProductsManager.Core.Entities;

namespace ProductsManager.WebSite.Models.ProductsController
{
    public record class IndexViewModel
    {
        public string SourceType { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}

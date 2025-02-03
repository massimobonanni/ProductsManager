using ProductsManager.Core.Entities;

namespace ProductsManager.FunAPIClient.Dto
{
    public class ProductDto:DtoBase<Product>
    {
        public ProductDto():base()
        {

        }

        public ProductDto(Product product)
        {
            ArgumentNullException.ThrowIfNull(product, nameof(product));

            this.Id = product.Id;
            this.Name = product.Name;
            this.Description = product.Description;
            this.Price = product.Price;
            this.Stock = product.Stock;

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public override Product ToEntity()
        {
            return new Product
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Price = this.Price,
                Stock = this.Stock
            };
        }

    }
}

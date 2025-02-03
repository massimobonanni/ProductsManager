using ProductsManager.Core.Entities;
using ProductsManager.Core.Interfaces;

namespace ProductsManager.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private static readonly IEnumerable<Product> _products;

        static InMemoryProductService()
        {
            // Initialize with some sample products
            var productList = new List<Product>();

            for (int i = 4; i <= Faker.RandomNumber.Next(5, 10); i++)
            {
                productList.Add(new Product
                {
                    Id = i,
                    Name = Faker.Lorem.Words(1).First(),
                    Description = Faker.Lorem.Sentence(),
                    Price = Faker.RandomNumber.Next(1, 100),
                    Stock = Faker.RandomNumber.Next(1, 100)
                });
            }

            _products = productList;
        }


        public Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_products);
        }

        public Task<bool> UpdateProductStock(int id, int stock, CancellationToken cancellationToken = default)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Stock += stock;
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}

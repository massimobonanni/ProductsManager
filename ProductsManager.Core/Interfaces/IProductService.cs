using ProductsManager.Core.Entities;

namespace ProductsManager.Core.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieves the list of all products.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the list of products.
        /// </returns>
        Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the stock quantity of a specific product.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <param name="stock">The new stock quantity to be set.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a boolean value indicating whether the update was successful.
        /// </returns>
        Task<bool> UpdateProductStock(int id, int stock, CancellationToken cancellationToken = default);
    }
}

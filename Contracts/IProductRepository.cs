using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productsParameters, bool trackChanges);
        Task <Product> GetProductAsync(Guid productId, bool trackChanges);
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
    }
}

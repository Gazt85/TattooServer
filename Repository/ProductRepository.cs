using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {

        }

        public async Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await FindAll(trackChanges)
        .OrderBy(p => p.Price)
        .ToListAsync();

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }


        public async Task<Product> GetProductAsync(Guid productId, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(productId), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateProduct(Product product) => Create(product);


        public void DeleteProduct(Product product) => Delete(product);


    }
}

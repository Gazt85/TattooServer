using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BlogItemRepository : RepositoryBase<BlogItem>, IBlogItemRepository
    {
        public BlogItemRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<BlogItem>> GetAllBlogItemAsync(bool trackChanges) =>
           await FindAll(trackChanges)      
           .ToListAsync();

        public async Task<BlogItem> GetBlogItemAsync(Guid blogItemId, bool trackChanges) =>
        await FindByCondition(c => c.Id.Equals(blogItemId), trackChanges)
        .SingleOrDefaultAsync();

        public void CreateBlogItem(BlogItem blogItem) => Create(blogItem);      

        public void DeleteBlogItem(BlogItem blogItem) => Delete(blogItem);
     
    }
}

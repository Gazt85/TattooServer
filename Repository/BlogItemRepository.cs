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

        public void CreateBlogItem(BlogItem blogItem) => Create(blogItem);

        public async Task<BlogItem> GetBlogItemByBlogPostIdAsync(Guid BlogId, bool trackChanges) =>
            await FindByCondition(b => b.BlogPostId.Equals(BlogId), trackChanges)
            .SingleOrDefaultAsync();
    }
}

using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BlogPostRepository : RepositoryBase<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {

        }       

        public async Task<IEnumerable<BlogPost>> GetAllBlogPostAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(b => b.Pinned).ThenBy(b => b.Date)
            .ToListAsync();

        public async Task<BlogPost> GetBlogPostAsync(Guid blogPostId, bool trackChanges) =>
        await FindByCondition(c => c.Id.Equals(blogPostId), trackChanges)
        .SingleOrDefaultAsync();

        //public async Task<BlogPost> GetBlogPostByBlogItemAsync(Guid blogItemId, Guid id, bool trackChanges) =>
        //  await FindByCondition(b => b.Id.Equals(blogItemId) && b.Id.Equals(id), trackChanges)
        //  .SingleOrDefaultAsync();

        public void CreateBlogPost(BlogPost blogPost) => Create(blogPost);

        public void DeleteBlogPost(BlogPost blogPost) => Delete(blogPost);
    }
}

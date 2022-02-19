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

        public void CreateBlogPost(BlogPost blogPost) => Create(blogPost);

        public void DeleteBlogPost(BlogPost blogPost) => Delete(blogPost);

        public async Task<IEnumerable<BlogPost>> GetAllBlogPostAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(b => b.Pinned).ThenBy(b => b.Date)
            .ToListAsync();
    }
}

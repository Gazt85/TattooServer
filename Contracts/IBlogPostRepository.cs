using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public  interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPostAsync(bool trackChanges);
        Task<BlogPost> GetBlogPostAsync(Guid id, bool trackChanges);

        //Task<BlogPost> GetBlogPostByBlogItemAsync(Guid blogItemId, Guid id, bool trackChanges);
        void CreateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(BlogPost blogPost);
    }
}

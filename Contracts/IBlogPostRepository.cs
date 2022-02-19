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
        void CreateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(BlogPost blogPost);
    }
}

using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBlogItemRepository
    {
        Task<BlogItem> GetBlogItemByBlogPostIdAsync(Guid BlogId, bool trackChanges);
        void CreateBlogItem(BlogItem blogItem);
    }
}

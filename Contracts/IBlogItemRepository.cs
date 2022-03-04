using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBlogItemRepository
    {
        Task<IEnumerable<BlogItem>> GetAllBlogItemAsync(bool trackChanges);
        Task<BlogItem> GetBlogItemAsync(Guid id, bool trackChanges);           
        void CreateBlogItem(BlogItem blogItem);

        void DeleteBlogItem(BlogItem blogitem);
    }
}

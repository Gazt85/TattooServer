using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters,bool trackChanges);

        Task<PagedList<User>> GetAllClientsAsync(UserParameters userParameters,bool trackChanges);
        Task<User> GetUserAsync(Guid userId, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}

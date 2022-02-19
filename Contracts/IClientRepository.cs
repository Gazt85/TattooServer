using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClientsAsync(bool trackChanges);
        Task<Client> GetClientAsync(Guid userId, bool trackChanges);
        void CreateClient(Client client);
        void DeleteClient(Client client);
    }
}

using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext repositoryContext)
       : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync(bool trackChanges) =>
        await FindByCondition(c => !c.IsAdmin,trackChanges)
        .OrderBy(c => c.Email)
        .ToListAsync();

        public async Task<Client> GetClientAsync(Guid ClientId, bool trackChanges) =>
           await FindByCondition(c => c.Id.Equals(ClientId), trackChanges)
           .SingleOrDefaultAsync();

        public void CreateClient(Client Client) => Create(Client);

        public void DeleteClient(Client Client)
        {
            Delete(Client);
        }
    }
}

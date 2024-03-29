﻿using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {

        }

        public async Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await FindAll(trackChanges)
       .OrderBy(c => c.Email)
       .ToListAsync();

            return PagedList<User>
               .ToPagedList(users, userParameters.PageNumber, userParameters.PageSize);
        }


        public async Task<PagedList<User>> GetAllClientsAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await FindByCondition(c => !c.IsAdmin, trackChanges)
        .OrderBy(c => c.Email)
        .ToListAsync();

            return PagedList<User>
              .ToPagedList(users, userParameters.PageNumber, userParameters.PageSize);

        }

        public async Task<User> GetUserAsync(Guid userId, bool trackChanges) =>
           await FindByCondition(c => c.Id.Equals(userId), trackChanges)
           .SingleOrDefaultAsync();

        public void CreateUser(User user) => Create(user);

        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upesi.API.IRepository;
using upesi.API.Models;

namespace upesi.API.Repository
{
    public class UserRepository : IUserrepository
    {
        public Task<string> delete(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int obj)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUsernamePassword(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> Gets()
        {
            throw new NotImplementedException();
        }

        public Task<User> Save(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
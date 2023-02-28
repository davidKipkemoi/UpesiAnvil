using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upesi.API.Models;

namespace upesi.API.IRepository
{
    public interface IUserrepository
    {
        Task<User> Save(User obj);
        Task<User> Get(int obj);
         Task<List<User>> Gets();
          Task<User> GetByUsernamePassword(User user);
          Task<string> delete(User obj);

    }
}
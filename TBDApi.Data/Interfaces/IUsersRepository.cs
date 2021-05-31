using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBDApi.Data.Interfaces
{
    public interface IUsersRepository
    {
        IQueryable<User> GetUsers();

        void Update(User user);

        void Delete(User user);
        User GetUsersById(int id);
    }
}

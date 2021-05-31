using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TBDApi.Business.Services.Users.Interfaces
{
    public interface IUsersService
    {
        List<User> GetUsers();

        void Update(User user);
        void Delete(int id);

        User GetUsersById(int id);
    }
}

using Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TBDApi.Data.Data;
using TBDApi.Data.Interfaces;

namespace TBDApi.Data.Repositories
{
  public   class UsersRepository : IUsersRepository
    {
        private readonly DataContext _context;
        public UsersRepository(DataContext context)
        {
            _context = context;
        }

        public void Delete(User user)
        {
            _context.User.Remove(user);
        }

        public IQueryable<User> GetUsers() => _context.User;

        public User GetUsersById(int id)
        {
          return  _context.User.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

       
    }
}

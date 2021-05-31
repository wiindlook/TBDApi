using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TBDApi.Data.Data;
using TBDApi.Data.Interfaces;

namespace TBDApi.Data.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public User Login(User user)
        {
            _context.User.Add(user);
            return user;
        }

        public User Register(User user)
        {
            _context.User.Add(user);
            return user;
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges() > -1;
        }
    }
}

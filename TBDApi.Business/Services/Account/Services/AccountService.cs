using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TBDApi.Business.Services.Account.Interfaces;
using TBDApi.Data.Interfaces;

namespace TBDApi.Business.Services.Account.Services
{
    
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public User Create(User user)
        {
            var userCreated = _accountRepository.Register(user);
            _accountRepository.SaveChanges();
            return user;
        }

        public User Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}

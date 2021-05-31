using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TBDApi.Data.Interfaces
{
   public  interface IAccountRepository
    {
        User Register(User user);
        User Login(User user);

        public bool SaveChanges();

        
    }
}

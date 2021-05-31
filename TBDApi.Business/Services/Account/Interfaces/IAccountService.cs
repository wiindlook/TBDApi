using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TBDApi.Business.Services.Account.Interfaces
{
    public interface IAccountService
    {
        User Create(User user);
        User Login(User user);
    }
}

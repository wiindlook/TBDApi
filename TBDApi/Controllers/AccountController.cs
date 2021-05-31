using Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBDApi.Business.Services.Account.Interfaces;
using TBDApi.DTO;

namespace TBDApi.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public ActionResult Register(RegisterDto userDto)
        {
            var createdUser = new User
            {
                Username = userDto.Username,
                Password = userDto.Password,
                Age = userDto.Age,
                City = userDto.City,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                KnownAs = userDto.KnownAs

            };
            _accountService.Create(createdUser);

            return Ok(createdUser);
        }
    }
}


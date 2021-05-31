using Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBDApi.Business.Services.Users.Interfaces;
using TBDApi.DTO;

namespace TBDApi.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var result = _usersService.GetUsers();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult GetUsersById(int id)
        {
            var result = _usersService.GetUsersById(id);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id,[FromBody]UserDto userDto)
        {
            var user = _usersService.GetUsersById(id);

            user.Username = userDto.Username;
            user.Age = userDto.Age;
            user.KnownAs = userDto.KnownAs;
            user.FirstName = userDto.FirstName;
            user.City = userDto.City;
                user.LastName=userDto.LastName;
            user.Password = userDto.Password;
            

            _usersService.Update(user);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            _usersService.Delete(id);
            return Ok();
        }

    }
}

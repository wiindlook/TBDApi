using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TBDApi.Business.Services.Users.Interfaces;
using TBDApi.Data.Interfaces;

namespace TBDApi.Business.Services.Users.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _userRepository;
        private readonly ISaveChangesInDb _saveChanges;
        public UsersService(IUsersRepository usersRepository,ISaveChangesInDb saveChanges)
  
        {
            _userRepository = usersRepository;
            _saveChanges = saveChanges;
        }


        public void Delete(int id)
        {
            var user = GetUsersById(id);
            _userRepository.Delete(user);
            _saveChanges.SaveChanges();
        }

        public List<User> GetUsers() => _userRepository.GetUsers().ToList();

        public User GetUsersById(int id)
        {
            var user = _userRepository.GetUsersById(id);
            return user;
        }

        public void Update(User user)
        {
            var userFromDb = GetUsersById(user.Id);
            userFromDb.Age = user.Age;
            userFromDb.City = user.City;
            userFromDb.FirstName = user.FirstName;
            userFromDb.KnownAs = user.KnownAs;
            userFromDb.LastName = user.LastName;
            userFromDb.Password = user.Password;
            userFromDb.Username = user.Username;
            _userRepository.Update(userFromDb);
            _saveChanges.SaveChanges();
        }
    }
}

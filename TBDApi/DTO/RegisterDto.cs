using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBDApi.DTO
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public int Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KnownAs { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

    }
}

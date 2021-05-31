using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class User
    {
       public int Id { get; set; }
       public string Username { get; set; }
       public int Password { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string KnownAs { get; set; }
       public string City { get; set; }
       public int Age { get; set; }


    }
}

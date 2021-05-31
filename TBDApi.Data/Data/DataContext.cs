using Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TBDApi.Data.Data
{
  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<User> User { get; set; }

        
    }
}

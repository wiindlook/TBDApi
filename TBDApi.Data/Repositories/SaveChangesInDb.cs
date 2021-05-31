using System;
using System.Collections.Generic;
using System.Text;
using TBDApi.Data.Data;
using TBDApi.Data.Interfaces;

namespace TBDApi.Data.Repositories
{
    public class SaveChangesInDb : ISaveChangesInDb
    {
        private readonly DataContext _context;
        public SaveChangesInDb(DataContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() > -1;
        }
    }
}

using System;
using System.Collections.Generic;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class SetRepository : IRepository<Set>
    {
        private readonly ApplicationDbContext _context;

        public SetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void create(Set item)
        {
            _context.Set.Add(item);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Set item)
        {
            throw new NotImplementedException();
        }

        public List<Set> get()
        {
            throw new NotImplementedException();
        }

        public Set getByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void update(object newWork, Set item)
        {
            throw new NotImplementedException();
        }
    }
}

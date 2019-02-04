using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var set = _context.Set.Find(id);

            _context.Set.Remove(set);
        }

        public void delete(Set item)
        {
            throw new NotImplementedException();
        }

        public List<Set> get()
        {
            return _context.Set.ToList();
        }

        public Set getByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void update(Set set)
        {
            _context.Entry(set).State = EntityState.Modified;
        }
    }
}

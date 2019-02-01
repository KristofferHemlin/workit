using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class MuscleRepository : IRepository<Muscle>
    {
        private readonly ApplicationDbContext _context;

        public MuscleRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void create(Muscle item)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Muscle item)
        {
            throw new NotImplementedException();
        }

        public List<Muscle> get()
        {
            return _context.Muscles
                .Include(e => e.ExerciseTypes).ThenInclude(e => e.ExerciseType).ToList();
        }

        public Muscle getByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void update(object newWork, Muscle item)
        {
            throw new NotImplementedException();
        }
    }
}

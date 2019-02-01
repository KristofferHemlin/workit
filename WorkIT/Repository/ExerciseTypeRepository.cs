using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class ExerciseTypeRepository : IRepository<ExerciseType>
    {
        private readonly ApplicationDbContext _context;

        public ExerciseTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void create(ExerciseType item)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(ExerciseType item)
        {
            throw new NotImplementedException();
        }

        public List<ExerciseType> get()
        {
            return _context.ExerciseType
              .Include(w => w.Muscles).ThenInclude(e => e.Muscle).ToList();
        }

        public ExerciseType getByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void update(object newWork, ExerciseType item)
        {
            throw new NotImplementedException();
        }

    }
}

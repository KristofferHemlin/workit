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
            return _context.ExerciseType.ToList();
        }

        public ExerciseType getByID()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void update(ExerciseType item)
        {
            throw new NotImplementedException();
        }
    }
}

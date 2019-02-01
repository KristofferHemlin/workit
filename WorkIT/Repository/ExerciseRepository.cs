using System;
using System.Collections.Generic;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class ExerciseRepository : IRepository<Exercise>
    {
        private readonly ApplicationDbContext _context;

        public ExerciseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void create(Exercise item)
        {
            _context.Exercise.Add(item);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Exercise item)
        {
            throw new NotImplementedException();
        }

        public List<Exercise> get()
        {
            throw new NotImplementedException();
        }

        public Exercise getByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void update(object newWork, Exercise item)
        {
            throw new NotImplementedException();
        }
    }
}

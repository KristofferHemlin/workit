using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class WorkoutRepository : IRepository<Workout>
    {
        private readonly ApplicationDbContext _context;

        public WorkoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void create(Workout work)
        {
            _context.Workout.Add(work);
            _context.SaveChanges();
        }

        public void delete(int id)
        {
            var workout =  _context.Workout.Find(id);
          
            _context.Workout.Remove(workout);
            _context.SaveChangesAsync();
        }

        public void delete(Workout work)
        {
            throw new NotImplementedException();
        }

        public List<Workout> get()
        {
            return _context.Workout
                .Include(w => w.Exercises).ThenInclude(e => e.ExerciseType)
                .Include(e => e.Exercises).ThenInclude(s => s.Sets).ToList();
            
            //_context.Workout
            //    .Include(w => w.Exercises).ThenInclude(e => e.ExerciseType)
            //    .Include(w => w.Exercises).ThenInclude(e => e.Sets).ToList();
        }

        public Workout getByID()
        {
            //var todoItem = await _context.TodoItems.FindAsync(id);
            //var workout = _context.Workout.FindAsync(id);

            //if (todoItem == null)
            //{
            //    return NotFound();
            //}

            //return todoItem;
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
            
        }

        public void update(Workout work)
        {
            throw new NotImplementedException();
        }
    }
}

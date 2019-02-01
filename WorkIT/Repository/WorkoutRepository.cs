using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Repository
{
    public class WorkoutRepository : IRepository<Workout>
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Exercise> exerciseRepo;

        public WorkoutRepository(ApplicationDbContext context,
            IRepository<ExerciseRepository> exerciseRepo)
        {
            _context = context;
            this.exerciseRepo = exerciseRepo;
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
        }

        public List<Workout> get(Expression<Func<Workout, bool>> predicate)
        {
            return _context.Workout
                .Where(predicate)
                .Include(w => w.Exercises).ThenInclude(e => e.ExerciseType)
                .Include(e => e.Exercises).ThenInclude(s => s.Sets).ToList();
        }

        public Workout getByID(int id)
        {
            return _context.Workout
                .Include(w => w.Exercises).ThenInclude(e => e.ExerciseType)
                .Include(e => e.Exercises).ThenInclude(s => s.Sets)
                .Where(x => x.workoutId == id)
                .First();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();           
        }

        public void update(Workout work)
        {
<<<<<<< HEAD
            
            //_context.Entry(work).State = EntityState.Modified;
            _context.Update(newWork);
            
=======
            var oldExercises = exerciseRepo.get(x => x.WorkoutId == work.workoutId);
            var oldExercisesIds = oldExercises.Select(x => x.ExerciseId);
            var exercisesToDelete = oldExercises.Where(x => !work.Exercises.Any(y => y.ExerciseId == x.ExerciseId));

            foreach (var item in exercisesToDelete)
            {
                exerciseRepo.delete(item.ExerciseId);
            }

            var updateWork = _context.Workout.Update(work);

            //Console.WriteLine(updateWork.Equals(newWork));
>>>>>>> 99cf93b0d4495d08bf38c24b25e3e56593f053bf
        }
    }
}

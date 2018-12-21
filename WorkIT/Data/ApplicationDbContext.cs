using Microsoft.EntityFrameworkCore;
using WorkIT.Models;

namespace WorkIT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Workout> Workout { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Set> Set { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

    }
}

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
        public DbSet<MusclesExerciseType> MusclesExerciseType { get; set; }
        public DbSet<Muscle> Muscles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusclesExerciseType>().HasKey(t => new { t.exerciseTypeId, t.muscleId });

            modelBuilder.Entity<MusclesExerciseType>().HasOne(m => m.Muscle).WithMany(me => me.ExerciseTypes).HasForeignKey(mc => mc.muscleId);
            modelBuilder.Entity<MusclesExerciseType>().HasOne(m => m.ExerciseType).WithMany(me => me.Muscles).HasForeignKey(mc => mc.exerciseTypeId);
        }
        

    }
}

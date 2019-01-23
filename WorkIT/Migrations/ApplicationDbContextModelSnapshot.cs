﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkIT.Data;

namespace WorkIT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkIT.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Duration");

                    b.Property<int>("ExerciseTypeId");

                    b.Property<int>("WorkoutId");

                    b.HasKey("ExerciseId");

                    b.HasIndex("ExerciseTypeId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("WorkIT.Models.ExerciseType", b =>
                {
                    b.Property<int>("exerciseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("exerciseTypeId");

                    b.ToTable("ExerciseType");
                });

            modelBuilder.Entity("WorkIT.Models.Muscle", b =>
                {
                    b.Property<int>("muscleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("muscleId");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("WorkIT.Models.MusclesExerciseType", b =>
                {
                    b.Property<int>("exerciseTypeId");

                    b.Property<int>("muscleId");

                    b.HasKey("exerciseTypeId", "muscleId");

                    b.HasIndex("muscleId");

                    b.ToTable("MusclesExerciseType");
                });

            modelBuilder.Entity("WorkIT.Models.Set", b =>
                {
                    b.Property<int>("setId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("exerciseId");

                    b.Property<int>("repCount");

                    b.Property<int>("restTime");

                    b.Property<float>("weight");

                    b.HasKey("setId");

                    b.HasIndex("exerciseId");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("WorkIT.Models.Workout", b =>
                {
                    b.Property<int>("workoutId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("endDateTime");

                    b.Property<string>("name");

                    b.Property<DateTime>("startDateTime");

                    b.HasKey("workoutId");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("WorkIT.Models.Exercise", b =>
                {
                    b.HasOne("WorkIT.Models.ExerciseType", "ExerciseType")
                        .WithMany()
                        .HasForeignKey("ExerciseTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkIT.Models.Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkIT.Models.MusclesExerciseType", b =>
                {
                    b.HasOne("WorkIT.Models.ExerciseType", "ExerciseType")
                        .WithMany("MusclesExerciseTypes")
                        .HasForeignKey("exerciseTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkIT.Models.Muscle", "Muscle")
                        .WithMany("MusclesExerciseTypes")
                        .HasForeignKey("muscleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkIT.Models.Set", b =>
                {
                    b.HasOne("WorkIT.Models.Exercise")
                        .WithMany("Sets")
                        .HasForeignKey("exerciseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

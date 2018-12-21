﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkIT.Data;

namespace WorkIT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181219155318_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkIT.Models.Exercise", b =>
                {
                    b.Property<int>("exerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("duration");

                    b.Property<int>("exerciseTypeId");

                    b.Property<int>("workoutId");

                    b.HasKey("exerciseId");

                    b.HasIndex("workoutId");

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

            modelBuilder.Entity("WorkIT.Models.Set", b =>
                {
                    b.Property<int>("setId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("exerciseId");

                    b.Property<int>("repCount");

                    b.Property<int>("restTime");

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

                    b.Property<DateTime>("startDateTime");

                    b.HasKey("workoutId");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("WorkIT.Models.Exercise", b =>
                {
                    b.HasOne("WorkIT.Models.Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("workoutId")
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
using Microsoft.EntityFrameworkCore;
using EF_verkefni1.Models;

namespace EF_verkefni1.Data
{
    public class SchoolDB : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True");
        }
    }
}

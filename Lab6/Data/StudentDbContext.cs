using Microsoft.EntityFrameworkCore;
using Lab6.Models;


namespace Lab6.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.Entity<Student>().HasKey(s => s.ID);
            modelBuilder.Entity<Student>().Property(s => s.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.LastName).HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.Program).HasMaxLength(100);

            base.OnModelCreating(modelBuilder);

        }
    }
}

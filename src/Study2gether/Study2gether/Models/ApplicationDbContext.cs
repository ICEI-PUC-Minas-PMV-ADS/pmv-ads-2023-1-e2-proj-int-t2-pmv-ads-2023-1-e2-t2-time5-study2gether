using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Study2gether.Models;

namespace Study2gether.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Axis> Axis { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Microfoundation> Microfoundation { get; set; }

        public DbSet<Answer> Answers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasOne(c => c.User)
                .WithMany(p => p.Answers)
                .HasForeignKey(c => c.idUser)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}


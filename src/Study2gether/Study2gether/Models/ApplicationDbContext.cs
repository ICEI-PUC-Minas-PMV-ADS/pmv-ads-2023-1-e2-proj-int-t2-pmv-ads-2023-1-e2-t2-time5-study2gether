using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post_Axis>()
            .HasKey(bc => new { bc.idPost, bc.idAxis });
        modelBuilder.Entity<Post_Axis>()
            .HasOne(bc => bc.Post)
            .WithMany(b => b.Post_Axis)
            .HasForeignKey(bc => bc.idPost);
        modelBuilder.Entity<Post_Axis>()
            .HasOne(bc => bc.Axis)
            .WithMany(c => c.Post_Axis)
            .HasForeignKey(bc => bc.idAxis);

        modelBuilder.Entity<Post_Category>()
            .HasKey(bc => new { bc.idPost, bc.idCategory });
        modelBuilder.Entity<Post_Category>()
            .HasOne(bc => bc.Post)
            .WithMany(b => b.Post_Category)
            .HasForeignKey(bc => bc.idPost);
        modelBuilder.Entity<Post_Category>()
            .HasOne(bc => bc.Category)
            .WithMany(c => c.Post_Category)
            .HasForeignKey(bc => bc.idCategory);

        modelBuilder.Entity<Post_Microfoundation>()
            .HasKey(bc => new { bc.idPost, bc.idMicrofoundation });
        modelBuilder.Entity<Post_Microfoundation>()
            .HasOne(bc => bc.Post)
            .WithMany(b => b.Post_Microfoundation)
            .HasForeignKey(bc => bc.idPost);
        modelBuilder.Entity<Post_Microfoundation>()
            .HasOne(bc => bc.Microfoundation)
            .WithMany(c => c.Post_Microfoundation)
            .HasForeignKey(bc => bc.idMicrofoundation);

    }
}
}


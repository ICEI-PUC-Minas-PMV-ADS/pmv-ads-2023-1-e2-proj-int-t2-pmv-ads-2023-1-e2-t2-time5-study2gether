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
    }
}

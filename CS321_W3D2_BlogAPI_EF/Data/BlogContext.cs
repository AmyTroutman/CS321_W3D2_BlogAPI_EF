using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS321_W3D2_BlogAPI_EF.Models;

namespace CS321_W3D2_BlogAPI_EF.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogs.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, Title = "Post 1", Body = "Wordswordswordswords!"},
                new Post { Id = 2, Title = "Post 2", Body = "lalalalalalalalalalalalala"}
                );
        }

      
    }
}

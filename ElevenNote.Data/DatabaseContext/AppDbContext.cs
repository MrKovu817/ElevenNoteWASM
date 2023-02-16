using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Data.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Note> Notes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id=1,
                    Name="Happy People"
                },
                new Category
                {
                    Id=2,
                    Name="Sad People"
                },
                new Category
                {
                    Id=3,
                    Name="Art"
                },
                new Category
                {
                    Id=4,
                    Name="Music"
                },
                new Category
                {
                    Id=5,
                    Name="Video Games"
                }
            );
        }
    }
}
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace exercise.webapi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Library");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Author>().HasData(seeder.Authors);
            modelBuilder.Entity<Book>().HasData(seeder.Books);
            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);
            modelBuilder.Entity<Author>().HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
            modelBuilder.Entity<Publisher>().HasMany(x => x.Books).WithOne(x => x.Publisher).HasForeignKey(x => x.PublisherId);

            // Many to many class needs composite key, like primary key but composed of two properties instead of one
            modelBuilder.Entity<Author>().HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}

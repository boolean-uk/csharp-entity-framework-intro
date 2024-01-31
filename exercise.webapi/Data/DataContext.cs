using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace exercise.webapi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Library");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.AuthorId, ab.BookId });

            modelBuilder.Entity<Author>()
                .HasMany(a => a.AuthorBooks)
                .WithOne(ab => ab.Author)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.AuthorBooks)
                .WithOne(ab => ab.Book)
                .HasForeignKey(ab => ab.BookId);

            modelBuilder.Entity<Author>().HasData(seeder.Authors);
            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);

            // Avoid seeding Books directly, focus on seeding AuthorBook
            modelBuilder.Entity<AuthorBook>().HasData(seeder.AuthorBooks);

            // Optionally, you can also seed additional data for Books here if needed
            modelBuilder.Entity<Book>().HasData(seeder.Books);
        }

        public DbSet<Publisher> Publishers {get; set;}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        
    }
}

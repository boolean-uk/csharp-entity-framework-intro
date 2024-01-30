using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Library");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Author>().HasData(seeder.Authors);

            modelBuilder.Entity<Book>().HasData(seeder.Books);

            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);

            modelBuilder.Entity<BookAuthor>()
                .HasKey(bc => new { bc.AuthorId, bc.BookId });

            /**
            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Author)
                .WithMany(c => c.BookAuthors)
                .HasForeignKey(bc => bc.AuthorId); 
            **/

            modelBuilder.Entity<BookAuthor>().HasData(seeder.BookAuthors);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}

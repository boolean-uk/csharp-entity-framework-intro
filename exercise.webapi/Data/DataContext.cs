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
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Library");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Author>().HasData(seeder.Authors);
            modelBuilder.Entity<Book>().HasData(seeder.Books);

            //extension
            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);

            //extension many-to-many
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(a => a.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(c => c.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(a => a.Author)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(c => c.AuthorId);
           
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        //extension
        public DbSet<Publisher> Publishers { get; set; }
    }
}

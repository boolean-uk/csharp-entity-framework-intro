using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace exercise.webapi.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(x => x.Authors).WithMany(x => x.Books).UsingEntity<AuthorBook>();
            modelBuilder.Entity<Book>().HasOne(x => x.Publisher).WithMany(x => x.Books).HasForeignKey(x => x.PublisherId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<AuthorBook>().HasKey(x => new { x.AuthorId, x.BookId });
            modelBuilder.Entity<Checkout>().HasOne(x => x.Book).WithMany(x => x.Checkouts).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.SetNull);

            Seeder seeder = new Seeder();

            modelBuilder.Entity<Author>().HasData(seeder.Authors);
            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);
            modelBuilder.Entity<Book>().HasData(seeder.Books);
            modelBuilder.Entity<AuthorBook>().HasData(seeder.AuthorBooks);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

    }
}

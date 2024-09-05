﻿using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;

namespace exercise.webapi.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseInMemoryDatabase("Library");
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Publisher>().HasData(seeder.Publishers);
            modelBuilder.Entity<Author>().HasData(seeder.Authors);
            modelBuilder.Entity<Book>().HasData(seeder.Books);
            modelBuilder.Entity<BookAuthor>().HasData(seeder.BookAuthors);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.BookAuthors)
                .WithOne(ba => ba.Author)
                .HasForeignKey(ba => ba.AuthorId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.BookAuthors)
                .WithOne(ba => ba.Book)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<Publisher>()
                .HasMany(p => p.PublishedBooks)
                .WithOne(b => b.Publisher)
                .HasForeignKey(b => b.PublisherId);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}

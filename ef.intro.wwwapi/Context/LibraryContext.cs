using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Context
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Library");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(m => new { m.Id });
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}

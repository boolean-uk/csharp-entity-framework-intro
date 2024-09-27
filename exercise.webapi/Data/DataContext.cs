using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Data
{
    public class DataContext : DbContext
    {
        private string connectionString; 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connectionString = config.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
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
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}

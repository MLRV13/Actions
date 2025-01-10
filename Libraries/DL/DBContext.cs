using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DL
{
    public class DBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }
}

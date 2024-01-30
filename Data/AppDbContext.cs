using ExerciceContact.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciceContact.Data
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext() : base()
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\exerciceDB; Database=exerciceClient;");
        }
    }
}

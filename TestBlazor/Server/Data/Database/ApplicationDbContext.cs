using Microsoft.EntityFrameworkCore;
using TestBlazor.Shared.Models;

namespace TestBlazor.Server.Data.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>().HasData(
            new Developer { Id = Guid.NewGuid(), Username = "KingCoder", Cellnumber = "997", Email = "king@code.com" },
            new Developer { Id = Guid.NewGuid(), Username = "CodeFather", Cellnumber = "7896541230", Email = "cf@code.com" }
        );
        }
    }

}

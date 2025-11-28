
using ApiEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpresa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>()
            .HasOne(c => c.City)
            .WithMany()
            .HasForeignKey(c => c.IdCity)
            .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

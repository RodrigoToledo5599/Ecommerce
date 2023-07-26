using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Name = "Tv", Price = 3000 },
                new Produto { Id = 2, Name = "Celular", Price = 760 },
                new Produto { Id = 3, Name = "Pc Gamer", Price = 9000 },
                new Produto { Id = 4, Name = "Arduino Uno", Price = 50 },
                new Produto { Id = 5, Name = "Head Set Gamer Hyper X sem fio", Price = 650 }


            





                );
        }
    }
}
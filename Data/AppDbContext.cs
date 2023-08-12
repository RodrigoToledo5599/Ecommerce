using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Account> Account  { get; set; }

        





        //public virtual DbContextOptionsBuilder EnableSensitiveDataLogging(bool sensitiveDataLoggingEnabled = true);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Name = "Tv", Price = 3000,CategoriaId = 8 },
                new Produto { Id = 2, Name = "Celular", Price = 760, CategoriaId = 4 },
                new Produto { Id = 3, Name = "Pc Gamer", Price = 9000, }, // sem categoria
                new Produto { Id = 4, Name = "Arduino Uno", Price = 50, CategoriaId = 2 },
                new Produto { Id = 5, Name = "Esp-32", Price = 70, CategoriaId = 2 },
                new Produto { Id = 6, Name = "Head Set Gamer Hyper X sem fio", Price = 650, CategoriaId = 1 },
                new Produto { Id = 7, Name = "Smart Tv Sansung 50 polegadas UHD 4K", Price = 2400, CategoriaId = 8, Descricao= "Samsung Smart TV 50 Polegadas com Processador Crystal 4K, Tela sem limites, Visual Livre de Cabos e Alexa integrada\r\nCom design simples e visual livre de cabos, sua nova Smart TV 50 Polegada vai ser a Samsung Crystal 4K\r\n\r\nCom organização e elegância, a Samsung Smart TV 50 Polegadas possui sitema de organização de cabos que ficam ligados à TV que ficam ocultos dentro das canaletas localizadas atrás da TV, que permite um visual mais limpo e clean." }
                
                
                );


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name= "Fone de ouvido"},
                new Category { Id = 2, Name= "Placa Programável"},
                new Category { Id = 3, Name= "Monitor"},
                new Category { Id = 4, Name= "Smartphone"},
                new Category { Id = 5, Name= "Placa mãe"},
                new Category { Id = 6, Name= "Gpu"},
                new Category { Id = 7, Name= "Cpu"},
                new Category { Id = 8, Name= "TV"},
                new Category { Id = 9, Name= "Fonte de Alimentação"},
                new Category { Id = 10, Name= "Teclado"},
                new Category { Id = 11, Name= "Mouse"},
                new Category { Id = 12, Name= "SSD"},
                new Category { Id = 13, Name= "HD"}
                );



            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Cliente" },
                new Role { Id = 3, Name = "Vendedor" }

                
                
                
                );
        }
    }
}
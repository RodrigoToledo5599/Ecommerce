using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }





        //public virtual DbContextOptionsBuilder EnableSensitiveDataLogging(bool sensitiveDataLoggingEnabled = true);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Name = "Tv", Price = 3000 },
                new Produto { Id = 2, Name = "Celular", Price = 760 },
                new Produto { Id = 3, Name = "Pc Gamer", Price = 9000 },
                new Produto { Id = 4, Name = "Arduino Uno", Price = 50 },
                new Produto { Id = 5, Name = "Esp-32", Price = 70 },
                new Produto { Id = 6, Name = "Head Set Gamer Hyper X sem fio", Price = 650 },
                new Produto { Id = 7, Name = "Smart Tv Sansung 50 polegadas UHD 4K", Price = 2400 , Descricao= "Samsung Smart TV 50 Polegadas com Processador Crystal 4K, Tela sem limites, Visual Livre de Cabos e Alexa integrada\r\nCom design simples e visual livre de cabos, sua nova Smart TV 50 Polegada vai ser a Samsung Crystal 4K\r\n\r\nCom organização e elegância, a Samsung Smart TV 50 Polegadas possui sitema de organização de cabos que ficam ligados à TV que ficam ocultos dentro das canaletas localizadas atrás da TV, que permite um visual mais limpo e clean." }
                
                
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
        }
    }
}
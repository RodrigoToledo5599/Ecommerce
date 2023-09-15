using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Account> Account  { get; set; }
        public DbSet<Favoritos> Favoritos  { get; set; }
        public DbSet<ItemCarrinho> ItemCarrinho  { get; set; }
        public DbSet<ImagensProdutos> ImagensProdutos  { get; set; }





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
                new Produto { Id = 7, Name = "Smart Tv Sansung 50 polegadas UHD 4K", Price = 2400, CategoriaId = 8, Descricao= "Samsung Smart TV 50 Polegadas com Processador Crystal 4K, " +
                "Tela sem limites, Visual Livre de Cabos e Alexa integrada\r\nCom design simples e visual livre de cabos, sua nova Smart TV 50 Polegada vai ser a Samsung Crystal 4K\r\n\r\n" +
                "Com organização e elegância, a Samsung Smart TV 50 Polegadas possui sitema de organização de cabos que ficam ligados à TV que ficam ocultos dentro das canaletas localizadas atrás da TV, " +
                "que permite um visual mais limpo e clean." },
				new Produto { Id = 8, Name = "Head Set com fio RedDragon", Price = 219, CategoriaId = 1 },
				new Produto { Id = 9, Name = "Monitor gamer Husky 27'' QHD 165hz ", Price = 1300, CategoriaId = 3 },
				new Produto { Id = 10, Name = "Tv 8k Sansung", Price = 4500, CategoriaId = 8 },
				new Produto { Id = 11, Name = "placa b450m am4 ddr4 Terabyte ", Price = 580, CategoriaId =5 },
				new Produto { Id = 12, Name = "Motorola Moto E13 64GB 4GB RAM Camera 13MB", Price = 630, CategoriaId = 4 },
				new Produto { Id = 13, Name = "ryzen 5 3600X", Price = 800, CategoriaId = 7 },
				new Produto { Id = 14, Name = "Teclado Gamer Hyper X Alloy Core RGB ABNT2", Price = 200, CategoriaId = 10 },
				new Produto { Id = 15, Name = "SSD 2TB XPG S70 Blade", Price = 1040, CategoriaId = 12, Descricao= "PCIe GEN4x4\n Leitura: 7400 MB/s\nGravação: 6400 MB/s" }


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


            modelBuilder.Entity<Account>().HasData(
                new Account { Id= 1, Name ="123" ,Email= "123@gmail.com", Senha="123"}



                );














			//modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

		}
    }
}
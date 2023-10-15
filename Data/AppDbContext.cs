using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;

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
                new Produto { Id = 1, Name = "Smart TV 70 Polegadas Samsung UHD 4K, 3 HDMI, 1 USB, Bluetooth, Wi-Fi, Gaming Hub", Price = 3500,CategoriaId = 8 },
                new Produto { Id = 2, Name = "Celular", Price = 760, CategoriaId = 4 },
                new Produto { Id = 3, Name = "Pc Gamer", Price = 9000, },
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
				new Produto { Id = 15, Name = "SSD 2TB XPG S70 Blade", Price = 1040, CategoriaId = 12, Descricao= "PCIe GEN4x4\n Leitura: 7400 MB/s\nGravação: 6400 MB/s" },
				new Produto { Id = 16, Name = "Console Sony PlayStation 5 + Jogo EA Sports FC 24\r\nSony\r\n(0)\r\n", Price = 3905, CategoriaId = 16 },
				new Produto { Id = 17, Name = "Mouse Gamer Redragon Cobra, Chroma RGB, 12400DPI, 7 Botões, Preto", Price = 109, CategoriaId = 11 },
				new Produto { Id = 18, Name = "Smartphone Motorola Moto E13, 64GB, 4GB RAM, Octa Core, Câmera 13MP, Tela de 6.5, Grafite", Price = 770, CategoriaId = 4 },
				new Produto { Id = 19, Name = "Memória Gamer Husky Gaming Avalanche, 16GB, 3200MHz, DDR4", Price = 200, CategoriaId = 17 },
				new Produto { Id = 20, Name = "Processador AMD Ryzen 7 5700X, 3.4GHz (4.6GHz Max Turbo), Cache 36MB, AM4", Price = 1240, CategoriaId = 7 },
				new Produto { Id = 21, Name = "SSD 480 GB Adata Ultimate SU650, Leitura: 550MB/s e Gravação: 510MB/s", Price = 130, CategoriaId = 12 },
				new Produto { Id = 22, Name = "Smart TV 32 Polegadas AOC Roku HD LED, 3 HDMI, 1 USB, Wi-Fi", Price = 930, CategoriaId = 8 }


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
                new Category { Id = 13, Name= "HD"},
                new Category { Id = 14, Name= "Computador"},
                new Category { Id = 15, Name= "Notebook"},
                new Category { Id = 16, Name= "Console Video Game"},
                new Category { Id = 17, Name= "Memoria Ram"}
                );


            modelBuilder.Entity<Account>().HasData(
                new Account { Id= 1, Name ="123" ,Email= "123@gmail.com", Senha="123"},
                new Account { Id= 13, Name ="ADM" ,Email= "ADM@gmail.com", Senha="adm123",Role= Roles.Administrator}



                );














			//modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

		}
    }
}
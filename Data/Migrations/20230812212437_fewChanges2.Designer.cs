﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230812212437_fewChanges2")]
    partial class fewChanges2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(63)
                        .HasColumnType("nvarchar(63)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fone de ouvido"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Placa Programável"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Placa mãe"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Gpu"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cpu"
                        },
                        new
                        {
                            Id = 8,
                            Name = "TV"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Fonte de Alimentação"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Teclado"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 12,
                            Name = "SSD"
                        },
                        new
                        {
                            Id = 13,
                            Name = "HD"
                        });
                });

            modelBuilder.Entity("Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(511)
                        .HasColumnType("nvarchar(511)");

                    b.Property<string>("Imagem1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemPrincipal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 8,
                            Name = "Tv",
                            Price = 3000f
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 4,
                            Name = "Celular",
                            Price = 760f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pc Gamer",
                            Price = 9000f
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Name = "Arduino Uno",
                            Price = 50f
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Name = "Esp-32",
                            Price = 70f
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 1,
                            Name = "Head Set Gamer Hyper X sem fio",
                            Price = 650f
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 8,
                            Descricao = "Samsung Smart TV 50 Polegadas com Processador Crystal 4K, Tela sem limites, Visual Livre de Cabos e Alexa integrada\r\nCom design simples e visual livre de cabos, sua nova Smart TV 50 Polegada vai ser a Samsung Crystal 4K\r\n\r\nCom organização e elegância, a Samsung Smart TV 50 Polegadas possui sitema de organização de cabos que ficam ligados à TV que ficam ocultos dentro das canaletas localizadas atrás da TV, que permite um visual mais limpo e clean.",
                            Name = "Smart Tv Sansung 50 polegadas UHD 4K",
                            Price = 2400f
                        });
                });

            modelBuilder.Entity("Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(63)
                        .HasColumnType("nvarchar(63)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cliente"
                        },
                        new
                        {
                            Id = 3,
                            Name = ""
                        });
                });

            modelBuilder.Entity("Models.Account", b =>
                {
                    b.HasOne("Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Models.Produto", b =>
                {
                    b.HasOne("Models.Category", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}

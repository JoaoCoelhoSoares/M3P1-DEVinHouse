﻿// <auto-generated />
using System;
using DEVinCar.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DEVinCar.Migrations
{
    [DbContext(typeof(DEVInCarContext))]
    [Migration("20221019215526_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DEVinCar.Models.Caminhonete", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CapacidadeCacamba")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CpfComprador")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gasolisa")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroChassi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portas")
                        .HasColumnType("int");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Caminhonetes");

                    b.HasData(
                        new
                        {
                            Id = "CAM1",
                            CapacidadeCacamba = 300,
                            Cor = "Verde",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(6523),
                            Gasolisa = false,
                            Nome = "F1000",
                            NumeroChassi = "LAL97ZP13DWDU3FRW",
                            Placa = "YMP-1578",
                            Portas = 2,
                            Potencia = 1000,
                            Tipo = "Caminhonete",
                            Valor = 60000m
                        },
                        new
                        {
                            Id = "CAM2",
                            CapacidadeCacamba = 250,
                            Cor = "Cinza",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(9394),
                            Gasolisa = false,
                            Nome = "F500",
                            NumeroChassi = "JJGB28NVX7NNL0BDB",
                            Placa = "WNX-5313",
                            Portas = 2,
                            Potencia = 500,
                            Tipo = "Caminhonete",
                            Valor = 55000m
                        },
                        new
                        {
                            Id = "CAM3",
                            CapacidadeCacamba = 250,
                            Cor = "Preto",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(9425),
                            Gasolisa = true,
                            Nome = "F250",
                            NumeroChassi = "Z1X6JT9TYYWC54APJ",
                            Placa = "RUK-3804",
                            Portas = 2,
                            Potencia = 250,
                            Tipo = "Caminhonete",
                            Valor = 45000m
                        });
                });

            modelBuilder.Entity("DEVinCar.Models.Carro", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CpfComprador")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gasolisa")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroChassi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portas")
                        .HasColumnType("int");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carros");

                    b.HasData(
                        new
                        {
                            Id = "CAR1",
                            Cor = "Cinza",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 923, DateTimeKind.Local).AddTicks(4451),
                            Gasolisa = false,
                            Nome = "Ford Focus",
                            NumeroChassi = "ETSXA0PA6X2VSNT94",
                            Placa = "DXW-3713",
                            Portas = 4,
                            Potencia = 250,
                            Tipo = "Carro",
                            Valor = 45000m
                        },
                        new
                        {
                            Id = "CAR2",
                            Cor = "Branco",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(2472),
                            Gasolisa = false,
                            Nome = "Punto",
                            NumeroChassi = "FMHFG5BV3JSY06AS2",
                            Placa = "PYG-8555",
                            Portas = 2,
                            Potencia = 350,
                            Tipo = "Carro",
                            Valor = 47500m
                        },
                        new
                        {
                            Id = "CAR3",
                            Cor = "Azul",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(2616),
                            Gasolisa = false,
                            Nome = "Gol",
                            NumeroChassi = "UTGR9WV77HUNAPBA0",
                            Placa = "HML-3163",
                            Portas = 4,
                            Potencia = 200,
                            Tipo = "Carro",
                            Valor = 30000m
                        });
                });

            modelBuilder.Entity("DEVinCar.Models.MotoTriciclo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CpfComprador")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroChassi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<int>("Rodas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MotoTriciclos");

                    b.HasData(
                        new
                        {
                            Id = "MOT1",
                            Cor = "Vermelho",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(2193),
                            Nome = "CG150",
                            NumeroChassi = "HA36SE1RD8RLUVKTP",
                            Placa = "LKV-1418",
                            Potencia = 150,
                            Rodas = 2,
                            Tipo = "MotoTriciclo",
                            Valor = 8500m
                        },
                        new
                        {
                            Id = "MOT2",
                            Cor = "Branco",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(4897),
                            Nome = "Honda Biz",
                            NumeroChassi = "X15GUZEVBHXAMJB1D",
                            Placa = "ZJD-6083",
                            Potencia = 100,
                            Rodas = 2,
                            Tipo = "MotoTriciclo",
                            Valor = 5500m
                        },
                        new
                        {
                            Id = "MOT3",
                            Cor = "Azul",
                            CpfComprador = 0L,
                            DataFabricacao = new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(5003),
                            Nome = "Triciclo 3E",
                            NumeroChassi = "60A8JUCSADY6GWAGP",
                            Placa = "SSO-0834",
                            Potencia = 125,
                            Rodas = 3,
                            Tipo = "MotoTriciclo",
                            Valor = 11500m
                        });
                });

            modelBuilder.Entity("DEVinCar.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("CpfComprador")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VehicleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DEVinCar.Models.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "yan@email.com",
                            Nome = "Yan",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 2,
                            Email = "joao@email.com",
                            Nome = "Joao",
                            Password = "123123"
                        },
                        new
                        {
                            Id = 3,
                            Email = "support@email.com",
                            Nome = "Support",
                            Password = "123123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
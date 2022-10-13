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
    [Migration("20221012214202_InitialCreate")]
    partial class InitialCreate
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(5919),
                            Gasolisa = false,
                            Nome = "F1000",
                            NumeroChassi = "T0WYUN9A2FZVH2SK4",
                            Placa = "EJE-0043",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(8682),
                            Gasolisa = false,
                            Nome = "F500",
                            NumeroChassi = "09VY8CJ0W0M0NK9PM",
                            Placa = "VXO-5450",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(8722),
                            Gasolisa = true,
                            Nome = "F250",
                            NumeroChassi = "623MP639CG95VERS9",
                            Placa = "KHH-2000",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 397, DateTimeKind.Local).AddTicks(2485),
                            Gasolisa = false,
                            Nome = "Ford Focus",
                            NumeroChassi = "F9DNMSZH0XX30N91K",
                            Placa = "KAD-1316",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(1842),
                            Gasolisa = false,
                            Nome = "Punto",
                            NumeroChassi = "MB47871CMDEBMSF5Y",
                            Placa = "TPD-3335",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(1883),
                            Gasolisa = false,
                            Nome = "Gol",
                            NumeroChassi = "C9GJJ18EJU7P3HMEG",
                            Placa = "WRE-7266",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(1475),
                            Nome = "CG150",
                            NumeroChassi = "VSWZMHBLVUYUZ3XJR",
                            Placa = "ZDO-8508",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(4344),
                            Nome = "Honda Biz",
                            NumeroChassi = "B2R7SZB3J4V176YL5",
                            Placa = "RPA-8534",
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
                            DataFabricacao = new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(4431),
                            Nome = "Triciclo 3E",
                            NumeroChassi = "39T96H4FR7W9D3F9A",
                            Placa = "XKM-0053",
                            Potencia = 125,
                            Rodas = 3,
                            Tipo = "MotoTriciclo",
                            Valor = 11500m
                        });
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
                });
#pragma warning restore 612, 618
        }
    }
}
using DEVinCar.Models;
using DEVinCar.Seeds;
using Microsoft.EntityFrameworkCore;

namespace DEVinCar.Context
{
    public class DEVInCarContext : DbContext
    {
        public DEVInCarContext() { }

        public DEVInCarContext(DbContextOptions<DEVInCarContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Caminhonete> Caminhonetes { get; set; }
        public DbSet<MotoTriciclo> MotoTriciclos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Caminhonete>().HasData(VehiclesSeed.CaminhoneteSeeder);
        //    modelBuilder.Entity<Carro>().HasData(VehiclesSeed.CarroSeeder);
        //    modelBuilder.Entity<MotoTriciclo>().HasData(VehiclesSeed.MotoTricicloSeeder);
        //}
    }
}

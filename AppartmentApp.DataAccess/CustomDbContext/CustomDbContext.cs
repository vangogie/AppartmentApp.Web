using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using AppartmentApp.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppartmentApp.DataAccess.CustomDbContext
{
    public class CustomDbContext : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<AppartmentType> AppartmentTypes { get; set; }
        public DbSet<InternetProvider> InternetProviders { get; set; }
        //public DbSet<AppartmentAmenity> AppartmentAmenities { get; set; }

        public static string connectionString = "server=ACER\\SQLEXPRESS2019;database=AppartmentDB;trusted_connection=true";
        //public CustomDbContext() : base(DbOptions(connectionString))
        public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
        {
            Database.EnsureCreated(); //создание БД
        }

        public static DbContextOptions GetOptions(string connectionString)
        { 
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        private static DbContextOptions DbOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
    }
}

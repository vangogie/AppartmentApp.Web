﻿using System;
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
        public static string connectionString => ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public CustomDbContext() : base(DbOptions(connectionString))
        {
        }

        private static DbContextOptions DbOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<AppartmentType> AppartmentTypes { get; set; }
        public DbSet<InternetProvider> InternetProviders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AppartmentApp.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace AppartmentApp.DataAccess.CustomDbContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartment>().HasData(
                new Appartment() 
                { 
                    Id = 1, 
                    Name = "Hillton", 
                    Area = 124.5, 
                    Price = 1240, 
                    RoomsCount = 5, 
                    TypeOfAppartment = new AppartmentType() 
                    { 
                        Id = 1, 
                        TypeOfAppartment = "Отель" 
                    }, 
                    InternetProviderName = new InternetProvider() 
                    { 
                        Id = 1, 
                        Name = "Воля" 
                    }, 
                    CurrentAdress = new Adress 
                    { 
                        Id = 1, 
                        City = "Харьков", 
                        Country = "Украина", 
                        HouseNumber = "34-А" 
                    }, 
                    Amenities = new List<Amenity> 
                    { 
                        new Amenity 
                        { 
                            Id = 1, 
                            Name = "Холодильник" 
                        }, 
                        new Amenity 
                        { 
                            Id = 2, 
                            Name = "Микроволновка" 
                        } 
                    } 
                });
        }
    }
}

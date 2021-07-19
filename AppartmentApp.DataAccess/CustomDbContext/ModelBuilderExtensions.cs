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
            modelBuilder.Entity<InternetProvider>().HasData
                (
                new InternetProvider() { Id = 1, Name = "Воля" },
                new InternetProvider() { Id = 2, Name = "Триолан" },
                new InternetProvider() { Id = 3, Name = "Pritex" }
                );

            modelBuilder.Entity<Adress>().HasData
                (
                new Adress { Id = 1, Country = "Украина", Reqion = "Харьковская обл.", City = "Харьков", Street = "ул. Сумская", HouseNumber = "34-А", EntranceNumber = "1", FlatNumber = "55"},
                new Adress { Id = 2, Country = "Украина" , /*Reqion = "Харьковская обл.",*/ City = "Киев", Street = "ул. Сковороды", HouseNumber = "22" /*, EntranceNumber = "1", FlatNumber = "55"*/ },
                new Adress { Id = 3, Country = "Украина", /*Reqion = "Харьковская обл.",*/ City = "Ужгород", Street = "ул. Литовца", HouseNumber = "1" /*, EntranceNumber = "1", FlatNumber = "55"*/ }
                );

            modelBuilder.Entity<AppartmentType>().HasData
                (
                new AppartmentType() { Id = 1, TypeOfAppartment = "Отель"},
                new AppartmentType() { Id = 2, TypeOfAppartment = "Гостевой дом" },
                new AppartmentType() { Id = 3, TypeOfAppartment = "Квартира" }
                );

            modelBuilder.Entity<Amenity>().HasData
                (
                new Amenity { Id = 1, Name = "Холодильник" },
                new Amenity { Id = 2, Name = "Телевизор" },
                new Amenity { Id = 3, Name = "Микроволновая печь" },
                new Amenity { Id = 4, Name = "Фен" },
                new Amenity { Id = 5, Name = "Стиральная машинка" }
                );

            modelBuilder.Entity<Appartment>().HasData(
                new Appartment() 
                { 
                    Id = 1,
                    Name = "Hillton", 
                    Area = 124.5, 
                    Price = 1240, 
                    RoomsCount = 5, 
                    //TypeOfAppartment = 
                    //InternetProviderName = 
                    //CurrentAdress 
                    //Amenities =  
                });
        }
    }
}

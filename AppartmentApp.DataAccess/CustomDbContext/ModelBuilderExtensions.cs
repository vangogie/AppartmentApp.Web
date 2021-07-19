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
            //настройка отношения один ко многим (один провайдер может быть у многих квартир)
            modelBuilder.Entity<Appartment>()
            .HasOne(e => e.InternetProviderName)
            .WithMany(c => c.Appartments);
            //настройка отношения один ко многим (один провайдер может быть у многих квартир)


            //настройка отношения один ко многим (один тип квартиры может быть у многих квартир)
            modelBuilder.Entity<Appartment>()
            .HasOne(e => e.TypeOfAppartment)
            .WithMany(c => c.Appartments);
            //настройка отношения один ко многим (один тип квартиры может быть у многих квартир)

            //настройка отношения многих ко многим (у многих квартир может быть много доп.опций)
            /* modelBuilder.Entity<AppartmentAmenity>() //BookCategory
         .HasKey(bc => new { bc.AppartmentId, bc.AmenityId });
             modelBuilder.Entity<AppartmentAmenity>()
                 .HasOne(bc => bc.Appartment)
                 .WithMany(b => b.AppartmentAmenities)
                 .HasForeignKey(bc => bc.AppartmentId);
             modelBuilder.Entity<AppartmentAmenity>()
                 .HasOne(bc => bc.Amenity)
                 .WithMany(c => c.AppartmentAmenities)
                 .HasForeignKey(bc => bc.AmenityId);
             //настройка отношения многих ко многим (у многих квартир может быть много доп.опций)
            */


            var AP1 = new Appartment() { Id = 1, Name = "Rihanna Resort", Area = 342.5, Price = 2598, RoomsCount = 15 };
            modelBuilder.Entity<Appartment>().HasData(
                AP1, new Appartment()
                {
                    Id = 2,
                    Name = "Hillton",
                    Area = 124.5,
                    Price = 1240,
                    RoomsCount = 5,
                    //TypeOfAppartment = 
                    //InternetProviderName =
                    //CurrentAdress =
                    //Amenities =  
                });


            var IP1 = new InternetProvider() { Id = 1, Name = "Воля" };
            var IP2 = new InternetProvider() { Id = 2, Name = "Триолан" };
            var IP3 = new InternetProvider() { Id = 3, Name = "Pritex", Appartments = new List<Appartment> { AP1 } };
            modelBuilder.Entity<InternetProvider>().HasData
                (
                IP1, IP2, IP3
                );

            modelBuilder.Entity<Adress>().HasData
                (
                new Adress { Id = 1, Country = "Украина", Reqion = "Харьковская обл.", City = "Харьков", Street = "ул. Сумская", HouseNumber = "34-А", EntranceNumber = "1", FlatNumber = "55" },
                new Adress { Id = 2, Country = "Украина", /*Reqion = "Харьковская обл.",*/ City = "Киев", Street = "ул. Сковороды", HouseNumber = "22" /*, EntranceNumber = "1", FlatNumber = "55"*/ },
                new Adress { Id = 3, Country = "Украина", /*Reqion = "Харьковская обл.",*/ City = "Ужгород", Street = "ул. Литовца", HouseNumber = "1" /*, EntranceNumber = "1", FlatNumber = "55"*/ }
                );

            modelBuilder.Entity<AppartmentType>().HasData
                (
                new AppartmentType() { Id = 1, TypeOfAppartment = "Отель" },
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


            


        }
    }
}

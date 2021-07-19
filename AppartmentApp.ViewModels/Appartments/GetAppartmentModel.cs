using AppartmentApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.ViewModels.Appartments
{
    public class GetAppartmentModel
    {
        public int Id { get; set; } //id of appartment
        public double Price { get; set; } //price of appartments
        public string Name { get; set; } //name of appartments
        public int RoomsCount { get; set; } //how many rooms in appartments
        public double Area { get; set; } //area of appartments m2
        public IEnumerable<Amenity> Amenities { get; set; } = new List<Amenity>(); //amenities in appartment
        public AppartmentType TypeOfAppartment { get; set; }
        public InternetProvider InternetProviderName { get; set; }
        public Adress CurrentAdress { get; set; }
    }
}

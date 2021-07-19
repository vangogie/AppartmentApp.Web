using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class Appartment : BaseEntity
    {
        public double Price { get; set; } //price of appartments
        public string Name { get; set; } //name of appartments
        public int RoomsCount { get; set; } //how many rooms in appartments
        public double Area { get; set; } //area of appartments m2
                                         //public ICollection<AppartmentAmenity> AppartmentAmenities { get; set; } = new List<AppartmentAmenity>(); //many to many
        public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>(); //many to many
        public AppartmentType TypeOfAppartment { get; set; }
        public InternetProvider InternetProviderName { get; set; }
        public Adress CurrentAdress { get; set; }
    }
}

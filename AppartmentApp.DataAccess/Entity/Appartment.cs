using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class Appartment : BaseEntity
    {
        public double Price { get; set; } //price of appartments
        public string Name { get; set; } //name of appartments
        public int Rooms { get; set; } //how many rooms in appartments
        public double Area { get; set; } //area of appartments m2
        public IEnumerable<Amenity> Amenities { get; set; } = new List<Amenity>(); //amenities in appartment
        public AppartmentType Type { get; set; }
        public InternetProvider Provider { get; set; }
        public Adress CurrentAdress { get; set; }
    }
}

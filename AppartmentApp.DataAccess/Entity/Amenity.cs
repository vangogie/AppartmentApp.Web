using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class Amenity : BaseEntity
    {
        public string Name { get; set; }
        //public ICollection<AppartmentAmenity> AppartmentAmenities { get; set; } = new List<AppartmentAmenity>(); //many to many
        public ICollection<Appartment> Appartments { get; set; } = new List<Appartment>(); //many to many
    }
}

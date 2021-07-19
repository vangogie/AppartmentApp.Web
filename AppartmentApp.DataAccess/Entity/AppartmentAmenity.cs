using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class AppartmentAmenity
    {
        public int AppartmentId { get; set; }
        public Appartment Appartment { get; set; }
        public int AmenityId { get; set; }
        public Amenity Amenity { get; set; }
    }
}

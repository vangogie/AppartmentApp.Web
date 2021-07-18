using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class Amenity : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Appartment> Appartments { get; set; } = new List<Appartment>();
    }
}

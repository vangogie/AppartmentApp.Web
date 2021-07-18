using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class Adress : BaseEntity
    {
        public string Country { get; set; }
        public string Reqion { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public string EntranceNumber { get; set; }
        public string FlatNumber { get; set; }
    }
}

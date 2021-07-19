using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Entity
{
    public class AppartmentType : BaseEntity
    {
        public string TypeOfAppartment { get; set; }
        public ICollection<Appartment> Appartments { get; set; } //много квартир к одному типу (один ко многим)
    }
}

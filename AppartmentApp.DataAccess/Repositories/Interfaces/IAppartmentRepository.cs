using AppartmentApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.DataAccess.Repositories.Interfaces
{
    interface IAppartmentRepository
    {
        public IEnumerable<Appartment> Get();
    }
}

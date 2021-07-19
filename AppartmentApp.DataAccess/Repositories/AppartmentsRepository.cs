using AppartmentApp.DataAccess.Entity;
using AppartmentApp.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppartmentApp.DataAccess.Repositories
{
    public class AppartmentsRepository : IAppartmentRepository
    {
        private readonly CustomDbContext.CustomDbContext _dbContext;
        private readonly int limit = 100;
        public AppartmentsRepository()
        {
            string adress = CustomDbContext.CustomDbContext.connectionString;
            var builder = new DbContextOptionsBuilder<CustomDbContext.CustomDbContext>();
            _dbContext = new CustomDbContext.CustomDbContext(builder.UseSqlServer(adress).Options);
        }

        public IEnumerable<Appartment> Get()
        {
            return _dbContext.Appartments.Take(limit);
        }
    }
}

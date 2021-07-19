using AppartmentApp.DataAccess.Entity;
using AppartmentApp.DataAccess.Repositories;
using AppartmentApp.ViewModels.Appartments;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppartmentApp.Business.Services
{
    public class AppartmentService
    {
        private readonly AppartmentsRepository _appartmentRepository; //экземпляр класса Data Access
        public AppartmentService(AppartmentsRepository appartmentRepository)
        {
            _appartmentRepository = appartmentRepository;
        }

        public IEnumerable<GetAppartmentModel> Get()
        {
            var appartments = _appartmentRepository.Get();
            var models = new List<GetAppartmentModel>();
            foreach (var item in appartments)
            {
                models.Add(new GetAppartmentModel
                {
                    Id = item.Id,
                    Name = item.Name, 
                    Area = item.Area, 
                    Amenities = item.Amenities, 
                    CurrentAdress = item.CurrentAdress, 
                    InternetProviderName = item.InternetProviderName, 
                    Price = item.Price, 
                    RoomsCount = item.RoomsCount, 
                    TypeOfAppartment = item.TypeOfAppartment
                });
            }
            return models;
        }
    }
}

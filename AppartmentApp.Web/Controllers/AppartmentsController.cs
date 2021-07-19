using AppartmentApp.Business.Services;
using AppartmentApp.ViewModels.Appartments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppartmentApp.Web.Controllers
{
    [Route("api/[controller]")]
    public class AppartmentsController : Controller
    {
        public readonly AppartmentService _appartmentService;
        public AppartmentsController()
        {
            _appartmentService = new AppartmentService(new DataAccess.Repositories.AppartmentsRepository());
        }
        [HttpGet] //тип запроса на получение данных
        public IEnumerable<GetAppartmentModel> Get()
        {
            return _appartmentService.Get();
        }
    }
}

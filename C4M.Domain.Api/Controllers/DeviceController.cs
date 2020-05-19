using C4M.Api.Infrastructure;
using C4M.Domain.Entities;
using C4M.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C4M.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiConventionType(typeof(DeviceApiConventions))]
    public class DeviceController : ControllerBaseApi
    {
        private readonly IMongoRepository<Person> _peopleRepository;

        public DeviceController(IMongoRepository<Person> peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }


    }
}
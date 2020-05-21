using AutoMapper;
using C4M.Api.Infrastructure;
using C4M.Api.ViewModel;
using C4M.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C4M.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiConventionType(typeof(DeviceApiConventions))]
    public class DeviceController : ControllerBaseApi
    {
        private readonly IMapper _mapper;
        private readonly ILogger<DeviceController> _logger;
        private readonly IMongoRepository<Domain.Entities.Instrument> _deviceRepository;

        public DeviceController(IMongoRepository<Domain.Entities.Instrument> deviceRepository, ILogger<DeviceController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _deviceRepository = deviceRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instrument>>> GetAllAsync()
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepository.FilterBy(f => true);

            return Ok(_mapper.Map<IEnumerable<Instrument>>(devices));
        }

        [HttpGet]
        [Route("{deviceid:min(1)}")]
        public async Task<ActionResult<IEnumerable<Instrument>>> GetAsync(string id)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var device = await _deviceRepository.FilterBy(filter => filter.hardwareId == id);

            return Ok(_mapper.Map<IEnumerable<Instrument>>(device));
        }

        [HttpPost]
        public async Task<ActionResult> PostAllAsync([FromBody]DeviceCreate deviceCreate)
        {
            var devices = _mapper.Map<Domain.Entities.Device>(deviceCreate);

            await _deviceRepository.InsertManyAsync(devices.Devices);

            return Ok();
        }
    }
}
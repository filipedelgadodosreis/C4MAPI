using AutoMapper;
using C4M.Api.Infrastructure;
using C4M.Api.ViewModel;
using C4M.Domain.Entities;
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
        private readonly IMongoRepository<C4MEquipamentosMongo> _deviceRepository;

        public DeviceController(IMongoRepository<C4MEquipamentosMongo> deviceRepository, ILogger<DeviceController> logger, IMapper mapper)
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
        public async Task<ActionResult<IEnumerable<C4MEquipamentosMongo>>> GetAsync(string id)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var device = await _deviceRepository.FilterBy(filter => filter.hardwareId == id);

            return Ok(_mapper.Map<IEnumerable<C4MEquipamentosMongo>>(device));
        }

        [HttpPost]
        public async Task<ActionResult> PostAllAsync([FromBody]DeviceCreate deviceCreate)
        {
            var devices = _mapper.Map<List<C4MEquipamentosMongo>>(deviceCreate.Devices);

            await _deviceRepository.InsertManyAsync(devices);

            return Ok();
        }
    }
}
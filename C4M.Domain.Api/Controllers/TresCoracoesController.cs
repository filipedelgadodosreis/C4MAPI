using AutoMapper;
using C4M.Api.Infrastructure;
using C4M.Api.ViewModel;
using C4M.Domain.Entities;
using C4M.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C4M.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiConventionType(typeof(DeviceApiConventions))]
    public class TresCoracoesController : ControllerBaseApi
    {
        private readonly IMapper _mapper;
        private readonly ILogger<TresCoracoesController> _logger;
        private readonly IMongoRepository<TresCoracoesEquipamentos> _deviceRepository;

        public TresCoracoesController(IMongoRepository<TresCoracoesEquipamentos> deviceRepository, ILogger<TresCoracoesController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _deviceRepository = deviceRepository;
        }

        [HttpGet]
        public async Task<ActionResult<DeviceCreate>> GetAllAsync()
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepository.FilterBy(f => true);
            var lstDevices = _mapper.Map<IEnumerable<Instrument>>(devices);

            return Ok(new DeviceCreate() { Devices = lstDevices.ToList() });
        }

        [HttpPost]
        [Route("equipamentos")]
        public async Task<ActionResult> PostAllAsync([FromBody]DeviceCreate deviceCreate)
        {
            var devices = _mapper.Map<List<TresCoracoesEquipamentos>>(deviceCreate.Devices);

            await _deviceRepository.InsertManyAsync(devices);

            return Ok();
        }
    }
}
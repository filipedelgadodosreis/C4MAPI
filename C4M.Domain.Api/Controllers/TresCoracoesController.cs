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
        private readonly IMongoRepository<TresCoracoesDadosMinimos> _deviceRepositoryDadosMinimos;
        private readonly IMongoRepository<TresCoracoesEquipamentos> _deviceRepositoryDadosCompletos;

        public TresCoracoesController(IMongoRepository<TresCoracoesEquipamentos> deviceRepositoryDadosCompletos, ILogger<TresCoracoesController> logger, IMapper mapper, IMongoRepository<TresCoracoesDadosMinimos> deviceRepositoryDadosMinimos)
        {
            _mapper = mapper;
            _logger = logger;
            _deviceRepositoryDadosMinimos = deviceRepositoryDadosMinimos;
            _deviceRepositoryDadosCompletos = deviceRepositoryDadosCompletos;
        }

        [HttpGet("equipamentos/dadoscompletos")]
        public async Task<ActionResult<DeviceCreate>> GetAllFullDataAsync()
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosCompletos.FilterBy(f => true);
            var lstDevices = _mapper.Map<IEnumerable<Instrument>>(devices);

            return Ok(new DeviceCreate() { Devices = lstDevices.ToList() });
        }

        [HttpPost]
        [Route("equipamentos/dadoscompletos")]
        public async Task<ActionResult> PostAllFullDataAsync([FromBody]DeviceCreate deviceCreate)
        {
            var devices = _mapper.Map<List<TresCoracoesEquipamentos>>(deviceCreate.Devices);

            await _deviceRepositoryDadosCompletos.InsertManyAsync(devices);

            return Ok();
        }


        [HttpGet("equipamentos/dadosminimos")]
        public async Task<ActionResult<DeviceCreateDadosMinimos>> GetAllMinimumDataAsync()
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosMinimos.FilterBy(f => true);
            var lstDevices = _mapper.Map<IEnumerable<InstrumentDadosMinimos>>(devices);

            return Ok(new DeviceCreateDadosMinimos() { Devices = lstDevices.ToList() });
        }

        [HttpPost]
        [Route("equipamentos/dadosminimos")]
        public async Task<ActionResult> PostAllMinimumDataAsync([FromBody]DeviceCreateDadosMinimos deviceCreate)
        {
            var lstDevice = _mapper.Map<List<TresCoracoesDadosMinimos>>(deviceCreate.Devices);

            await _deviceRepositoryDadosMinimos.InsertManyAsync(lstDevice);

            return Ok();
        }
    }
}
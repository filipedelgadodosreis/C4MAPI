using AutoMapper;
using C4M.Api.Infrastructure;
using C4M.Api.ViewModel;
using C4M.Domain.Entities;
using C4M.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C4M.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiConventionType(typeof(DeviceApiConventions))]
    public class DevicesController : ControllerBaseApi
    {
        private readonly IMapper _mapper;
        private readonly ILogger<DevicesController> _logger;
        private readonly IMongoRepository<DadosMinimos> _deviceRepositoryDadosMinimos;
        private readonly IMongoRepository<Equipamentos> _deviceRepositoryDadosCompletos;

        public DevicesController(IMongoRepository<Equipamentos> deviceRepositoryDadosCompletos, ILogger<DevicesController> logger, IMapper mapper, IMongoRepository<DadosMinimos> deviceRepositoryDadosMinimos)
        {
            _mapper = mapper;
            _logger = logger;
            _deviceRepositoryDadosMinimos = deviceRepositoryDadosMinimos;
            _deviceRepositoryDadosCompletos = deviceRepositoryDadosCompletos;
        }

        [HttpGet("equipamentos/dadoscompletos")]
        public async Task<ActionResult<DeviceCreate>> GetAllFullDataAsync(string collectionName)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosCompletos.FilterBy(f => true, collectionName);
            var lstDevices = _mapper.Map<IEnumerable<Instrument>>(devices);

            return Ok(new DeviceCreate() { Devices = lstDevices.ToList(), CollectionName = collectionName });
        }

        [HttpGet("equipamentos/dadoscompletos/{dataLeitura:datetime}")]
        public async Task<ActionResult<DeviceCreate>> GetAllFullDatabyDateAsync(string collectionName, DateTime data)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosCompletos.FilterBy(f => f.DtLeitura == data, collectionName);
            var lstDevices = _mapper.Map<IEnumerable<Instrument>>(devices);

            return Ok(new DeviceCreate() { Devices = lstDevices.ToList(), CollectionName = collectionName });
        }

        [HttpPost]
        [Route("equipamentos/dadoscompletos")]
        public async Task<ActionResult> PostAllFullDataAsync([FromBody]DeviceCreate deviceCreate)
        {
            var devices = _mapper.Map<List<Equipamentos>>(deviceCreate.Devices);

            await _deviceRepositoryDadosCompletos.InsertManyAsync(devices, deviceCreate.CollectionName);

            return Ok();
        }


        [HttpGet("equipamentos/dadosminimos")]
        public async Task<ActionResult<DeviceCreateDadosMinimos>> GetAllMinimumDataAsync(string collectionName)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosMinimos.FilterBy(f => true, collectionName);
            var lstDevices = _mapper.Map<IEnumerable<InstrumentDadosMinimos>>(devices);

            return Ok(new DeviceCreateDadosMinimos() { Devices = lstDevices.ToList(), CollectionName = collectionName });
        }

        [HttpGet("equipamentos/dadosminimos/{dataLeitura:datetime}")]
        public async Task<ActionResult<DeviceCreateDadosMinimos>> GetAllMinimumDatabyDateAsync(string collectionName, DateTime data)
        {
            _logger.LogDebug("Obtendo todos os devices.");

            var devices = await _deviceRepositoryDadosMinimos.FilterBy(f => f.DtLeitura == data, collectionName);
            var lstDevices = _mapper.Map<IEnumerable<InstrumentDadosMinimos>>(devices);

            return Ok(new DeviceCreateDadosMinimos() { Devices = lstDevices.ToList(), CollectionName = collectionName });
        }

        [HttpPost]
        [Route("equipamentos/dadosminimos")]
        public async Task<ActionResult> PostAllMinimumDataAsync([FromBody]DeviceCreateDadosMinimos deviceCreate)
        {
            var lstDevice = _mapper.Map<List<DadosMinimos>>(deviceCreate.Devices);

            await _deviceRepositoryDadosMinimos.InsertManyAsync(lstDevice, deviceCreate.CollectionName);

            return Ok();
        }
    }
}
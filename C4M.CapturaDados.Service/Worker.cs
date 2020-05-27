using C4M.BackgroundTasks.Models;
using C4M.BackgroundTasks.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static C4M.BackgroundTasks.Settings.BackgroundTaskSettings;

namespace C4M.BackgroundTasks
{
    public class Worker : BackgroundService
    {
        public List<C4MSettings> Settings { get; }

        private readonly ILogger<Worker> _logger;
        private readonly IC4MService _c4mSvc;

        public Worker(ILogger<Worker> logger, List<C4MSettings> settings, IC4MService c4mSvc)
        {
            _c4mSvc = c4mSvc;
            Settings = settings;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Inicio do Processamento: {time}", DateTimeOffset.Now);


                var retorno = await ObterDadosCompletosTodosOsClientesAsync();

                var dm = await ObterDadosMinimosAsync();

                var obj = JsonConvert.DeserializeObject<List<Instrument>>(retorno, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), NullValueHandling = NullValueHandling.Ignore });

                try
                {
                    foreach (var item in obj)
                    {
                        item.IdEmpresa = 12;
                        item.DtLeitura = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {

                }

                var result = JsonConvert.SerializeObject(obj);

                await Task.Delay(1000, stoppingToken);
            }
        }

        private async Task<string> ObterDadosCompletosTodosOsClientesAsync()
        {
            return await _c4mSvc.ObterDadosCompletosTodosOsClientes(Settings.FirstOrDefault(x => x.Id == "12"));
        }

        private async Task<string> ObterDadosMinimosAsync()
        {
            return await _c4mSvc.ObterDadosMinimos(Settings.FirstOrDefault(x => x.Id == "1"));
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now}: Servico Iniciado.");


            await base.StartAsync(cancellationToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now}: Servico parado. ");


            await base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            _logger.LogInformation($"{DateTime.Now}:Worker disposed.");

            base.Dispose();
        }
    }
}

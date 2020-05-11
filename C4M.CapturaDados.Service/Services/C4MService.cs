using C4M.BackgroundTasks.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static C4M.BackgroundTasks.Settings.BackgroundTaskSettings;

namespace C4M.BackgroundTasks.Services
{
    public class C4MService : IC4MService
    {
        private readonly HttpClient _apiClient;
        private readonly ILogger<C4MService> _logger;

        private readonly Random Random = new Random();

        public C4MApiSettings Settings { get; }

        public C4MService(HttpClient httpClient, ILogger<C4MService> logger, C4MApiSettings settings)
        {
            _logger = logger;
            _apiClient = httpClient;

            Settings = settings;
        }

        public async Task<string> ObterDadosCompletosTodosOsClientes(C4MSettings dados)
        {
            _apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetBearerToken(Settings.UrlDadosCompletos, "GET", dados.ConsumerKey, dados.ConsumerSecret));
            var response = await _apiClient.GetAsync(Settings.UrlDadosCompletos);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().Result;

            return string.Empty;

            //Forçar o retorno de um status code incorreto
        }

        public string GetBearerToken(string url, string method, string consumerKey, string consumerSecret)
        {
            var jsonHttpAut = new JsonAuthentication
            {
                consumer_key = consumerKey,
                nonce = GetNonce(),
                timestamp = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
                version = "1.0"
            };

            jsonHttpAut.signature = CalcSha256Hash(consumerSecret, $"{consumerSecret}{jsonHttpAut.consumer_key}{jsonHttpAut.nonce}{jsonHttpAut.timestamp}" +
                $"{jsonHttpAut.version}{method.ToUpperInvariant()}{url.ToUpperInvariant()}");

            var token = JsonConvert.SerializeObject(jsonHttpAut);

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(token));
        }

        private string CalcSha256Hash(string key, string input)
        {
            using (var hmac256 = new HMACSHA256())
            {
                hmac256.Key = Encoding.UTF8.GetBytes(key);
                hmac256.Initialize();
                return
                    Convert.ToBase64String(
                        hmac256.ComputeHash(Encoding.UTF8.GetBytes(input)));
            }
        }

        private string GetNonce()
        {
            var random = BitConverter.GetBytes(GetRandomNumber(1, 1000));
            return Convert.ToBase64String(random);
        }

        private int GetRandomNumber(double minimum, double maximum)
        {
            return Convert.ToInt32(Random.NextDouble() * (maximum - minimum) + minimum);
        }
    }
}

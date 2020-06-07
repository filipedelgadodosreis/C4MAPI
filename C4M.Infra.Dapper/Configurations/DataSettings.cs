using C4M.Infra.Dapper.Interfaces;

namespace C4M.Infra.Dapper.Configurations
{
    public class DataSettings : IDataSettings
    {
        public string DefaultConnection { get; set; }
    }
}

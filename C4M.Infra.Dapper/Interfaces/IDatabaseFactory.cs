using System.Data;

namespace C4M.Infra.Dapper.Interfaces
{
    public interface IDatabaseFactory
    {
        IDbConnection GetDbConnection { get; }
    }
}

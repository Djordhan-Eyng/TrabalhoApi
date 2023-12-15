using AulaApi.Contracts.Repository;
using AulaApi.Entity;
using AulaApi.Infrastructure;
using Dapper;

namespace AulaApi.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM STATE";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }
    }
}

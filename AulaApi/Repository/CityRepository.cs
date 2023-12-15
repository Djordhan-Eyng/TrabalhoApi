using AulaApi.Contracts.Repository;
using AulaApi.Entity;
using AulaApi.Infrastructure;
using Dapper;

namespace AulaApi.Repository
{
    public class CityRepository : Connection, ICityRepository
    {
        public async Task<IEnumerable<CityEntity>> Get()
        {

            string sql = "SELECT * FROM CITY";
            return await GetConnection().QueryAsync<CityEntity>(sql);
        }
    }
}


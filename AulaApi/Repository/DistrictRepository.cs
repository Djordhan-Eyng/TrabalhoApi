using AulaApi.Contracts.Repository;
using AulaApi.Entity;
using AulaApi.Infrastructure;
using Dapper;

namespace AulaApi.Repository
{
    public class DistrictRepository : Connection, IDistrictRepository
    {
        public async Task<IEnumerable<DistrictEntity>> Get()
        {

            string sql = "SELECT * FROM DISTRICT";
            return await GetConnection().QueryAsync<DistrictEntity>(sql);
        }
    }
}

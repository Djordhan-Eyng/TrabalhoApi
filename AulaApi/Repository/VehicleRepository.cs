using AulaApi.Contracts.Repository;
using AulaApi.DTO;
using AulaApi.Entity;
using AulaApi.Infrastructure;
using Dapper;

namespace AulaApi.Repository
{
    public class VehicleRepository : Connection, IVehicleRepository
    {
        public async Task Add(VehicleDTO vehicle)
        {
            string sql = @"INSERT INTO VEHICLE(Name,Year,LicensePlate,Capacity)
                             VALUE(@Name,@Year,@LicensePlate,@Capacity)";

            await Execute(sql, vehicle);
        }

        public async Task Delete(int id)
        {
            string sql = @"DELETE FROM VEHICLE WHERE Id = @id";

            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<VehicleEntity>> Get()
        {
            string sql = "SELECT * FROM VEHICLE";

            return await GetConnection().QueryAsync<VehicleEntity>(sql);
        }

        public async Task<VehicleEntity> GetById(int id)
        {
            string sql = @"SELECT * FROM VEHICLE WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<VehicleEntity>(sql, new { id });

        }

        public async Task Update(VehicleEntity vehicle)
        {
            string sql = @"
                              UPDATE VEHICLE SET Name = @Name,
                                 Capacity = @Capacity,
                                    LicensePlate = @LicensePlate,
                                     Year = @Year 
                                       WHERE Id = @Id";
            await Execute(sql, vehicle);

        }
    }
}

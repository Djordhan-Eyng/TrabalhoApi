﻿using AulaApi.DTO;
using AulaApi.Entity;

namespace AulaApi.Contracts.Repository
{
    public interface IVehicleRepository
    {
        Task Add(VehicleDTO vehicle);
        Task Update(VehicleEntity vehicle);
        Task Delete(int id);
        Task<VehicleEntity> GetById(int id);
        Task<IEnumerable<VehicleEntity>> Get();
    }


}


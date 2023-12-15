using AulaApi.Contracts.Repository;
using AulaApi.DTO;
using AulaApi.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{


    [ApiController]
    [Route("vehicle")]

    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;


        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _vehicleRepository.Get());
        }

        [HttpPost]

        public async Task<IActionResult> Add(VehicleDTO vehicle)
        {
            await _vehicleRepository.Add(vehicle);
            return Ok();

        }
        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {
            await _vehicleRepository.Delete(id);
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Update(VehicleEntity vehicle)
        {
            await _vehicleRepository.Update(vehicle);
            return Ok();

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _vehicleRepository.GetById(id));
        }

    }
}


using AulaApi.Contracts.Repository;
using AulaApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{
    [ApiController]
    [Route("district")]


    public class DistrictController : ControllerBase
    {
        private readonly IDistrictRepository _districtRepository;

        public DistrictController(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

       [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _districtRepository.Get());
        }
    }
}


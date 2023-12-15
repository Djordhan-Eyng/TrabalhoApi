using AulaApi.Contracts.Repository;
using AulaApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{
    [ApiController]
    [Route("city")]


    public class CityController : ControllerBase
    {
            private readonly ICityRepository _cityRepository;

            public CityController(ICityRepository cityRepository)
            {
                _cityRepository = cityRepository;
            }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cityRepository.Get());
        }

    }
}

﻿using AulaApi.Contracts.Repository;
using AulaApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{
    [ApiController]
    [Route("state")]


    public class StateController : ControllerBase
    {
        private readonly IStateRepository _stateRepository;

        public StateController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _stateRepository.Get());
        }
    }
  
}



﻿using AulaApi.Contracts.Repository;
using AulaApi.DTO;
using AulaApi.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userRepository.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserDTO user)
        {
                await _userRepository.Add(user);  
                return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UserEntity user)
        {
            await _userRepository.Update(user);
            return Ok();
        }
        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {
              await _userRepository.Delete(id);
              return Ok();
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            
            return Ok(await _userRepository.GetById(id));
        }
    }
}

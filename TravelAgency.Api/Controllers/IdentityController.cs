using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Security;

namespace TravelAgency.Api.Controllers
{
    [ApiController]
    [Route("api/identity")]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> CreateUser(RegisterDto registerDto)
        {

<<<<<<< HEAD
            string userId = await _identityService.CreateUserAsync(registerDto);
            return Ok(userId);
=======
            var result = await _identityService.CreateUserAsync(registerDto);
            return Ok(result);
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
        }

        
           [HttpPost]
            [Route("login")]
        public async Task<IActionResult> LogUser(LoginDto loginDto)
        {
            var userId = await _identityService.CheckCredentialsAsync(loginDto);

            return Ok(userId);
        }
    }
}
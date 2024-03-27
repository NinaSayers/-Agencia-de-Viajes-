using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Authorization;
>>>>>>> master
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Agency;
<<<<<<< HEAD
=======
using TravelAgency.Domain.Constant;
>>>>>>> master
using TravelAgency.Domain.Entities;
using TravelAgency.Infrastructure;

namespace TravelAgency.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _agencyService;
        public AgencyController(IAgencyService agencyService)
        {
           _agencyService=agencyService;
        }

        [HttpPost]
        [Route("create")]
<<<<<<< HEAD
=======
        //[Authorize(Roles = "SuperAdmin")]
>>>>>>> master
        public async Task<IActionResult> CreateAgency(AgencyDto agency)
        {
            await _agencyService.CreateAgencyAsync(agency);
            return Ok();

        }

        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Agency>>> ListAgency()
        {
            var agencies = await _agencyService.ListAgencyAsync();

            return Ok(agencies);

        }

        // [HttpGet]
        // [Route("find")]
        // public async Task<IActionResult> FindAgency(Agency agency)
        // {
        //     var _agency = await _agencyContext.Agencies.FindAsync(agency.Id);

        //     if (_agency == null) return NotFound();

        //     return Ok(_agency);

        // }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> UpdateAgency(AgencyDto agency)
        {
            var _agency = await _agencyService.UpdateAgencyAsync(agency);
            return Ok(_agency);

        }

        [HttpDelete]
        [Route("delete")]

<<<<<<< HEAD
        public async Task<IActionResult> DeleteAgency(int agency)
        {
             _agencyService.DeleteAgencyAsync(agency);
           return Ok();
        }
        // public async Task<IActionResult> DeleteAgency(AgencyDto agency)
        // {
        //     System.Console.WriteLine("Entro al controller");
        //     _agencyService.DeleteAgencyAsync(agency);
        //     return Ok();

        // }
=======
        public async Task<IActionResult> DeleteAgency(int agencyId)
        {
            await _agencyService.DeleteAgencyByIdAsync(agencyId);
           return Ok();
        }
       
>>>>>>> master
    }


}
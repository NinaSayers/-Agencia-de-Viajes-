using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Agency;
using TravelAgency.Domain.Entities;

namespace TravelAgency.Application.ApplicationServices.IServices
{
    public interface IAgencyService
    {
        Task<AgencyDto> CreateAgencyAsync(AgencyDto agencyDto);
        Task<AgencyDto> UpdateAgencyAsync(AgencyDto agencyDto);
        Task<IEnumerable<AgencyDto>> ListAgencyAsync();
<<<<<<< HEAD
<<<<<<< HEAD
        Task DeleteAgencyAsync(int agencyDto);
=======
        Task DeleteAgencyByIdAsync(int agencyDto);
>>>>>>> master
=======
        Task DeleteAgencyByIdAsync(int agencyDto);
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}
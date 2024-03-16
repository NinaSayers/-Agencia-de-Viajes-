using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Agency;
using TravelAgency.Domain.Entities;
using TravelAgency.Infrastructure.DataAccess.IRepository;

namespace TravelAgency.Application.ApplicationServices.Services
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMapper _mapper;

        public AgencyService(IAgencyRepository agencyRepository,IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _mapper = mapper;
        }
        public async Task<AgencyDto> CreateAgencyAsync(AgencyDto agencyDto)
        {
            var agency = _mapper.Map<Domain.Entities.Agency>(agencyDto);
            await _agencyRepository.CreateAsync(agency);
            return _mapper.Map<AgencyDto>(agency);
        }
        public async Task DeleteAgencyAsync(int agencyDto)
        {
            await _agencyRepository.DeleteByIdAsync(agencyDto);
        }

        // public async Task DeleteAgencyAsync(AgencyDto agencyDto) //!Maybe we would need to define other dto to delete.
        // {
        //     // var agency = _mapper.Map<Domain.Entities.Agency>(agencyDto);
        //     // var agencyfinal = _agencyRepository.GetById(agency);
        //     await _agencyRepository.DeleteAsync(agencyfinal);
            
        // }

        public async Task<IEnumerable<AgencyDto>> ListAgencyAsync()
        {
            var agencies = await _agencyRepository.ListAgencyAsync();
            var list = agencies.ToList();
            List <AgencyDto> agenciesfinal = new();
            for (int i = 0; i < agencies.Count(); i++)
            {
                agenciesfinal.Add(_mapper.Map<AgencyDto>(list[i]));
            }
            return agenciesfinal;
        }

        public async Task<AgencyDto> UpdateAgencyAsync(AgencyDto agencyDto)
        {
            var agency = _mapper.Map<Domain.Entities.Agency>(agencyDto);
            await _agencyRepository.UpdateAsync(agency);
            return _mapper.Map<AgencyDto>(agency);
        }
    }
}
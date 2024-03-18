using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Agency;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Hotel;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Security;
using TravelAgency.Domain.Entities;
using TravelAgency.Infrastructure.Identity;

namespace TravelAgency.Application.ApplicationServices.Maps.Dtos
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
             
             CreateMap<User, UserDto>();
             CreateMap<RegisterDto, User>();
             CreateMap<LoginDto, User>();
             CreateMap<AgencyDto, Domain.Entities.Agency>();
             CreateMap<Domain.Entities.Agency, AgencyDto>();
             CreateMap<HotelDto, Domain.Entities.Hotel>();
             CreateMap<Domain.Entities.Hotel, HotelDto>();


        }
    }
}
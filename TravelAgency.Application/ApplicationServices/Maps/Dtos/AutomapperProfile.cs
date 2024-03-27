using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Agency;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Facility;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Hotel;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.LodgingOffer;
>>>>>>> master
=======
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Facility;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.Hotel;
using TravelAgency.Application.ApplicationServices.Maps.Dtos.LodgingOffer;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
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
<<<<<<< HEAD
<<<<<<< HEAD
             
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
             CreateMap<RegisterDto, User>();
             CreateMap<LoginDto, User>();

             CreateMap<FacilityDto, Domain.Entities.Facility>();
             CreateMap<Domain.Entities.Facility,FacilityDto>();

             CreateMap<AgencyDto, Domain.Entities.Agency>();
             CreateMap<Domain.Entities.Agency, AgencyDto>();

<<<<<<< HEAD
=======
             CreateMap<RegisterDto, User>();
             CreateMap<LoginDto, User>();

             CreateMap<FacilityDto, Domain.Entities.Facility>();
             CreateMap<Domain.Entities.Facility,FacilityDto>();

             CreateMap<AgencyDto, Domain.Entities.Agency>();
             CreateMap<Domain.Entities.Agency, AgencyDto>();

=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
             CreateMap<HotelDto, Domain.Entities.Hotel>();
             CreateMap<Domain.Entities.Hotel, HotelDto>();

             CreateMap<LodgingOfferDto, Domain.Entities.LodgingOffer>();
             CreateMap<Domain.Entities.LodgingOffer, LodgingOfferDto>();

             CreateMap<LodgingOfferDtoResponse, Domain.Entities.LodgingOffer>();
             CreateMap<Domain.Entities.LodgingOffer, LodgingOfferDtoResponse>();


<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        }
    }
}
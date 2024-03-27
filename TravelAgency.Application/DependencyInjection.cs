<<<<<<< HEAD
=======
using Microsoft.Extensions.Configuration;
>>>>>>> origin/real-Nanda's-Branch
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Services;
<<<<<<< HEAD
=======
using TravelAgency.Application.Authentication;
using TravelAgency.Application.Interfaces;
>>>>>>> origin/real-Nanda's-Branch

namespace TravelAgency.Application
{
    public static class DependencyInjection
{
<<<<<<< HEAD
    public static void AddApplicationServices(this IServiceCollection services)
    {
=======
    public static void AddApplicationServices(this IServiceCollection services,ConfigurationManager configurationManager)
    {
            services.Configure<JwtSettings>(configurationManager.GetSection(JwtSettings.SECTION_NAME));
>>>>>>> origin/real-Nanda's-Branch
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ITouristService, TouristService>();
            services.AddScoped<IFacilityService, FacilityService>();       
<<<<<<< HEAD
=======
            services.AddScoped<ILodgingOfferService, LodgingOfferService>();       
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();       
>>>>>>> origin/real-Nanda's-Branch
    }
}
}
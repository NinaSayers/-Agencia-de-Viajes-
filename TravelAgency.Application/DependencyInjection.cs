<<<<<<< HEAD
=======
using Microsoft.Extensions.Configuration;
>>>>>>> master
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
>>>>>>> master

namespace TravelAgency.Application
{
    public static class DependencyInjection
{
<<<<<<< HEAD
    public static void AddApplicationServices(this IServiceCollection services)
    {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
        
       
=======
    public static void AddApplicationServices(this IServiceCollection services,ConfigurationManager configurationManager)
    {
            services.Configure<JwtSettings>(configurationManager.GetSection(JwtSettings.SECTION_NAME));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ITouristService, TouristService>();
            services.AddScoped<IFacilityService, FacilityService>();       
            services.AddScoped<ILodgingOfferService, LodgingOfferService>();       
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();       
>>>>>>> master
    }
}
}
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Microsoft.Extensions.Configuration;
>>>>>>> master
=======
using Microsoft.Extensions.Configuration;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Services;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using TravelAgency.Application.Authentication;
using TravelAgency.Application.Interfaces;
>>>>>>> master
=======
using TravelAgency.Application.Authentication;
using TravelAgency.Application.Interfaces;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79

namespace TravelAgency.Application
{
    public static class DependencyInjection
{
<<<<<<< HEAD
<<<<<<< HEAD
    public static void AddApplicationServices(this IServiceCollection services)
=======
    public static void AddApplicationServices(this IServiceCollection services,ConfigurationManager configurationManager)
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    {
            services.Configure<JwtSettings>(configurationManager.GetSection(JwtSettings.SECTION_NAME));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
<<<<<<< HEAD
        
       
=======
    public static void AddApplicationServices(this IServiceCollection services,ConfigurationManager configurationManager)
    {
            services.Configure<JwtSettings>(configurationManager.GetSection(JwtSettings.SECTION_NAME));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ITouristService, TouristService>();
            services.AddScoped<IFacilityService, FacilityService>();       
            services.AddScoped<ILodgingOfferService, LodgingOfferService>();       
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();       
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}
}
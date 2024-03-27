<<<<<<< HEAD
=======
using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
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
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947

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
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
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
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
    }
}
}
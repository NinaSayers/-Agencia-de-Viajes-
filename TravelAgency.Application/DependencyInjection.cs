using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TravelAgency.Application.ApplicationServices.IServices;
using TravelAgency.Application.ApplicationServices.Services;

namespace TravelAgency.Application
{
    public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<ITouristService, TouristService>();
            services.AddScoped<IHotelService, HotelService>();  
        
       
    }
}
}
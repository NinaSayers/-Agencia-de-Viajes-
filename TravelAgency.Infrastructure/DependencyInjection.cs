using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelAgency.Infrastructure.DataAccess.IRepository;
using TravelAgency.Infrastructure.DataAccess.Repository;
using TravelAgency.Infrastructure.Identity;

namespace TravelAgency.Infrastructure
{

    public static class DependencyInjection
<<<<<<< HEAD
<<<<<<< HEAD
{
    public static void AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    {
        public static void AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var db = services.AddDbContext<TravelAgencyContext>(x =>
                    { x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); }
            services.AddScoped<IIdentityManager, IdentityManager>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<ITouristRepository, TouristRepository>();
            services.AddScoped<IFacilityRepository, FacilityRepository>();
            services.AddScoped<ILodgingOfferRepository, LodgingOfferRepository>();
            services.AddScoped<TravelAgencyContextInitializer>();

            services.AddAuthentication 

            services
            .AddIdentityCore<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<TravelAgencyContext>();
    
        }
    }
<<<<<<< HEAD
}
=======
    {
        public static void AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var db = services.AddDbContext<TravelAgencyContext>(x =>
                    { x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); }
            services.AddScoped<IIdentityManager, IdentityManager>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<ITouristRepository, TouristRepository>();
            services.AddScoped<IFacilityRepository, FacilityRepository>();
            services.AddScoped<ILodgingOfferRepository, LodgingOfferRepository>();
            services.AddScoped<TravelAgencyContextInitializer>();

            services.AddAuthentication 

            services
            .AddIdentityCore<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<TravelAgencyContext>();
    
        }
    }
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    
}


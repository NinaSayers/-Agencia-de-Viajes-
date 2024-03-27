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
    {
        public static void AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var db = services.AddDbContext<TravelAgencyContext>(x =>
<<<<<<< HEAD
                    { x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); });


=======
                    { x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); }
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
            services.AddScoped<IIdentityManager, IdentityManager>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<ITouristRepository, TouristRepository>();
            services.AddScoped<IFacilityRepository, FacilityRepository>();
<<<<<<< HEAD
            services.AddScoped<TravelAgencyContextInitializer>();

=======
            services.AddScoped<ILodgingOfferRepository, LodgingOfferRepository>();
            services.AddScoped<TravelAgencyContextInitializer>();

            services.AddAuthentication 

<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
            services
            .AddIdentityCore<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<TravelAgencyContext>();
    
        }
    }
    
}


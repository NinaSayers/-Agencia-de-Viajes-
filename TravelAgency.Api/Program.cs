<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Identity;
>>>>>>> master
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

<<<<<<< HEAD
services.AddApplicationServices();
=======
services.AddHttpContextAccessor();
services.AddApplicationServices(builder.Configuration);
 services.AddDefaultIdentity<IdentityUser>()
        .AddEntityFrameworkStores<TravelAgencyContext>();
>>>>>>> master
services.AddInfraestructureServices(builder.Configuration);
services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
<<<<<<< HEAD
    //await app.InitializeDatabaseAsync();
=======
    await app.InitializeDatabaseAsync();
>>>>>>> master
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
app.Run();


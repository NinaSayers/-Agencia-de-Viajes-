<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

=======
using Microsoft.AspNetCore.Identity;
>>>>>>> master
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
<<<<<<< HEAD
builder.Services.AddControllers();
=======
>>>>>>> master
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddHttpContextAccessor();
<<<<<<< HEAD
services.AddApplicationServices();
=======
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
    await app.InitializeDatabaseAsync();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
<<<<<<< HEAD
app.UseCors();
=======
>>>>>>> master
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
<<<<<<< HEAD
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
=======
>>>>>>> master
app.Run();


<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

=======
using Microsoft.AspNetCore.Identity;
>>>>>>> master
=======
using Microsoft.AspNetCore.Identity;
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddControllers();
=======
>>>>>>> master
=======
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddHttpContextAccessor();
<<<<<<< HEAD
<<<<<<< HEAD
services.AddApplicationServices();
=======
services.AddApplicationServices(builder.Configuration);
 services.AddDefaultIdentity<IdentityUser>()
        .AddEntityFrameworkStores<TravelAgencyContext>();
>>>>>>> master
=======
services.AddApplicationServices(builder.Configuration);
 services.AddDefaultIdentity<IdentityUser>()
        .AddEntityFrameworkStores<TravelAgencyContext>();
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
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
<<<<<<< HEAD
app.UseCors();
=======
>>>>>>> master
=======
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
<<<<<<< HEAD
<<<<<<< HEAD
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
=======
>>>>>>> master
=======
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
app.Run();


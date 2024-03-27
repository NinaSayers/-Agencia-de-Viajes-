<<<<<<< HEAD
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Identity;
>>>>>>> master
=======
using Microsoft.AspNetCore.Identity;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
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
<<<<<<< HEAD
services.AddApplicationServices();
=======
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
services.AddHttpContextAccessor();
services.AddApplicationServices(builder.Configuration);
 services.AddDefaultIdentity<IdentityUser>()
        .AddEntityFrameworkStores<TravelAgencyContext>();
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
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
<<<<<<< HEAD
    //await app.InitializeDatabaseAsync();
=======
    await app.InitializeDatabaseAsync();
>>>>>>> master
=======
    await app.InitializeDatabaseAsync();
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
app.Run();


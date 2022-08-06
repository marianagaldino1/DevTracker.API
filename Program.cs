using DevTrackR.API.Persistence.Repositories;
using DevTrackR.API.Persistence;
using Microsoft.EntityFrameworkCore;
using SendGrid.Extensions.DependencyInjection;
using DevTrackR.API.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DevTrackRCs");
builder.Services
   .AddDbContext<DevTrackRContext>(options => options.UseSqlServer(connectionString: connectionString));

  // builder.Services
    //.AddDbContext<DevTrackRContext>(o => o.UseInMemoryDatabase("DevTrackRDb"));

    builder.Services.AddScoped<IPackageRepository, PackageRepository>();

    var sendeGridApiKey = builder.Configuration.GetSection("SendGridApiKey").Value;

    builder.Services.AddSendGrid(o => o.ApiKey = sendeGridApiKey);


IMvcBuilder mvcBuilder = builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

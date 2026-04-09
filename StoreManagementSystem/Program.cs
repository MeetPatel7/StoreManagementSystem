using Microsoft.EntityFrameworkCore;
using SMS.Application.IServices;
using SMS.Application.Services;
using SMS.Domain.IRepository;
using SMS.Infrastructure.Repository;
using SMS.Infrastructure.StoreDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("SMS.Infrastructure")
    ));

builder.Services.AddControllers();
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

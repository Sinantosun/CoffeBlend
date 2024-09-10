using CoffeBlend.Application.Features.Mediator.Handlers.AboutHandlers;
using CoffeBlend.Application.Interfaces.CategoryRepository;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Application.Interfaces.MailRepositories;
using CoffeBlend.Application.Interfaces.ProductInterfaces;
using CoffeBlend.Application.Interfaces.ProductPricingRepositories;
using CoffeBlend.Application.Interfaces.ReservationRepositories;
using CoffeBlend.Application.Interfaces.TableRepositories;
using CoffeBlend.Persistance.Context;
using CoffeBlend.Persistance.Repositories.CategoryRepositories;
using CoffeBlend.Persistance.Repositories.GenericRepository;
using CoffeBlend.Persistance.Repositories.MailRepositories;
using CoffeBlend.Persistance.Repositories.ProductPricingRepositories;
using CoffeBlend.Persistance.Repositories.ProductRepositories;
using CoffeBlend.Persistance.Repositories.ReservationRepositories;
using CoffeBlend.Persistance.Repositories.TableRepositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(opts =>
{
    opts.RegisterServicesFromAssemblyContaining<GetAboutQueryHandler>();
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<ITableRepository, TableRepository>();
builder.Services.AddScoped<IProductPricingRepository, ProductPricingRepository>();
builder.Services.AddScoped<IMailRepository, MailRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<CoffeBlendContext>(opts =>
{
    opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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

using Microsoft.EntityFrameworkCore;
using PromotionBannerManagement;
using PromotionBannerManagement.Repositories;
using PromotionBannerManagement.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(p => p.UseNpgsql(builder.Configuration.GetConnectionString("Default_Connection")));
builder.Services.AddScoped<IBannerRepo, BannerRepo>();
builder.Services.AddScoped<ICompanyRepo, CompanyRepo>();

builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

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

using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DAL.v1.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<WbfsDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("WbfsDbConnection")));

builder.Services.AddTransient<IApplicantLoginRepository, ApplicantLoginRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();

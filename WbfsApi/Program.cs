using DateOnlyWebApiExample;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DAL.v1.Repository;
using WbfsApi.Helpers;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using WbfsApi.DAL.v1.IRepository.applicant;
using WbfsApi.DAL.v1.Repository.applicant;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<WbfsDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("WbfsDbConnection")));

builder.Services.AddTransient<IApplicantLoginRepository, ApplicantLoginRepository>();
builder.Services.AddTransient<IAdminLoginRepository, AdminLoginRepository>();
builder.Services.AddTransient<IApplicantRegistrationRepository, ApplicantRegistrationRepository>();
builder.Services.AddTransient<IDashboardRepository, DashboardRepository>();

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opt =>
    opt.MapType<DateOnly>(() => new OpenApiSchema
    {
        Type = "string",
        Format = "date",
        Example = new OpenApiString(DateTime.Today.ToString("yyyy-MM-dd"))
    })
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";

        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
        if (contextFeature != null)
        {
            var errorResponse = new ApiResponse<string>(context.Response.StatusCode, "An unexpected error occurred", null);
            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
        }
    });
});*/

app.UseAuthorization();

app.MapControllers();

app.Run();

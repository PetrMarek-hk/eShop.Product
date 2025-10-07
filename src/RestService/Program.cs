using eShop.Product.ApplicationLogic;
using eShop.Product.RestService.Initialization;
using Microsoft.OpenApi.Models;
using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(options =>
//{
//    //options.EnableAnnotations(); // This method is part of Swashbuckle.AspNetCore.Annotations
//    //options.OperationFilter<Kruk.LegalCasesManager.Types.Enumerations.TypeEnumOperationFilter>();

//    options.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Version = "v1",
//        Title = "eShop.Product.RestService",
//        Description = "Demo project",
//    });
//});
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "eShop.Product.Restervice V1", Version = "v1" });
    options.SwaggerDoc("v2", new OpenApiInfo { Title = "eShop.Product.Restervice V2", Version = "v2" });
});
// Add API versioning
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

builder.Services
    .AddApplicationLogicServices()
    .AddAutoMapperConfiguration();

var app = builder.Build();

app.UseSwaggerUI(options =>
{
    //options.SwaggerEndpoint("/swagger/v1/swagger.json", "eShop.Product.Restervice V1");
    options.SwaggerEndpoint("/swagger/v2/swagger.json", "eShop.Product.Restervice V2");
});


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

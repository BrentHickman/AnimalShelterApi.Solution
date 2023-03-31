using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Swagger;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddDbContext<AnimalShelterApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], 
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
builder.Services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerGenOptions>();
builder.Services.AddSwaggerGen();


var app = builder.Build();
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
{
    foreach (var description in provider.ApiVersionDescriptions)
    {
        o.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", 
            $"MyApi - {description.GroupName.ToUpper()}");
    }
});
}
else 
{
  app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

using F1API.DAOs;
using F1API.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<SeasonDAO>();
builder.Services.TryAddScoped<IAuthorizerService, AuthorizerService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "F1 API",
        Description = "An ASP.NET Core Web API that returns some Formula One data.",
        Contact = new OpenApiContact {
            Name = "Jean J. Michel",
            Url = new Uri("https://www.linkedin.com/in/jeanjmichel/")
        }
    });

    var XMLFile = "F1API.xml";
    var XMLPath = Path.Combine(AppContext.BaseDirectory, XMLFile);
    options.IncludeXmlComments(XMLPath);
});

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

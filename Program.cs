using Desafio.Services;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Injeção de dependência
builder.Services.AddScoped<IRandomService, RandomService>();
builder.Services.AddScoped<ICalculadoraService, CalculadoraService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Desafio API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio API v1");
    });
}

// ✅ Redireciona automaticamente para o Swagger
app.MapGet("/", () => Results.Redirect("/swagger"));

app.MapControllers();
app.Run();
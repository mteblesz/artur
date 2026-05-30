using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.UseHttpsRedirection();

app.MapGet("/hello", () =>
{
    return "Hello, World! Greetings from Raspberry Pi!";
})
.WithName("GetHello");

app.Run();

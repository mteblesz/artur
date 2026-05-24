var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/hello", () =>
{
    return "<h1>Hello, Kinga! Greeting from Raspberry Pi!</h1>";
})
.WithName("GetHello");

app.Run();

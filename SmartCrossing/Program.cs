using SmartCrossing.Application;
using SmartCrossing.Application.Interfaces;
using SmartCrossing.Infrastructure;
using SmartCrossing.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new WeatherTypeConverter());
    });

//injeçao de dependencias
builder.Services.AddScoped<ICrossingService, CrossingService>();
builder.Services.AddScoped<IMockDataGenerator, MockDataGenerator>();


var app = builder.Build();

/*
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

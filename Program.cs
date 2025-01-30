

using client1.Services;

var builder = WebApplication.CreateBuilder(args);

// builder.Configuration.AddUserSecrets<Program>(); // Added secret manager to configuration



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddHttpClient();
// Register a Http call to the weather api

builder.Services.AddScoped<WeatherService>();

// Register the service



var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();
app.Run();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDevClient",
      builder =>
      {
          builder
          .WithOrigins("http://localhost:4200")
          .AllowAnyHeader()
          .AllowAnyMethod();
      });
    options.AddPolicy("AllowAngularClient",
      builder =>
      {
          builder
          .WithOrigins("http://localhost")
          .AllowAnyHeader()
          .AllowAnyMethod();
      });
});

var app = builder.Build();

app.UseCors("AllowAngularDevClient");
app.UseCors("AllowAngularClient");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

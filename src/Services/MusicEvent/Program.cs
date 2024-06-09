using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MusicEvent.Data;
using MusicEvent.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MusicEventDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MeeTikDB")));

builder.Services.AddScoped<IMusicEventRepository, MusicEventRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

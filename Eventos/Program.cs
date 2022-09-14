using Eventos.Context;
using Eventos.Evento.Interface;
using Eventos.Evento.Repostorie;
using Eventos.Evento.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


///////////////////////////////////////////////////////////////////////////////////////////
builder.Services.AddControllers();
builder.Services.AddDbContext<ContextEvento>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

//AutoMapper

//IUsuario
builder.Services.AddTransient<IEvento, SEvento>();
builder.Services.AddTransient<REvento>();

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

using EvaluacionA.Evaluacion.Interface;
using EvaluacionA.Evaluacion.Service;
using Eventos.Controllers;
using Microsoft.EntityFrameworkCore;
using Usuarios.Context;
using Usuarios.Controllers;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Repositorie;
using Usuarios.Usuario.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<UsuarioController, UsuarioController>();
builder.Services.AddTransient<IEvaluacion, SEvaluacion>();


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


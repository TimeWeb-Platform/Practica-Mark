using Evaluacion.Evaluacion.Interface;
using Evaluacion.Evaluacion.Service;
using Eventos.Evento.Interface;
using Eventos.Evento.Repostorie;
using Eventos.Evento.Service;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Repositorie;
using Usuarios.Usuario.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

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

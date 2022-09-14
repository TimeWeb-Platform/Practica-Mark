using Usuarios.Context;
using Microsoft.EntityFrameworkCore;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Service;

var builder = WebApplication.CreateBuilder(args);

///////////////////////////////////////////////////////////////////////////////////////////
builder.Services.AddControllers();
builder.Services.AddDbContext<ContextUsuario>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

//AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

//IUsuario
builder.Services.AddTransient<IUsuario,SUsuario>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//////////////////////////////////////////////////////////////


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

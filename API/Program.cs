using Core._01Service;
using Core._02Entidades;
using Core.Data;
using Core.Interfaces.Repository;
using Core.Interfaces.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBD.Inializador();
InicializadorBD.Inializador();
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Carro
builder.Services.AddScoped<ICarroRepository, CarroRepository>();
builder.Services.AddScoped<ICarroService, CarroService>();
//Caminhao
builder.Services.AddScoped<ICaminhaoService, CaminhaoService>();
builder.Services.AddScoped<ICaminhaoRepository, CaminhaoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

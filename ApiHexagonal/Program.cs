using Aplicacion.CasosDeUso;
using Aplicacion.Interfaces;
using Aplicacion.Queries;
using Dominio.Repositorios;
using Infraestructura.Persistencia;
using Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexión a SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Inyección de dependencias
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<ObtenerPedidoUseCase>();
builder.Services.AddScoped<IUsuariosReactRepository, UsuarioReactRepository>();
builder.Services.AddScoped<ObtenerUsuariosReactUseCase>();
//Interfaz de aplicacion y repositorio de Infraestructura
builder.Services.AddScoped<IUsuarioReactToAdoRepository, UsuarioReactToAdoRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ObtenerUsuariosReactToAdoQuery).Assembly));




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();

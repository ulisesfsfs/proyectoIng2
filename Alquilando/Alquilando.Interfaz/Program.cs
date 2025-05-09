using Alquilando.Interfaz.Components;
using Syncfusion.Blazor;
using Microsoft.Extensions.DependencyInjection;
using Alquilando.Aplicacion.Interfaces;
using Alquilando.Repositorios;
using Alquilando.Aplicacion.Casos_de_Uso;
using Alquilando.Aplicacion.Servicios;

AlquilandoSqlite.Inicializar();

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSyncfusionBlazor();





builder.Services.AddTransient<IRepositorioUsuarios, UsuariosSql>();
builder.Services.AddTransient<RegistrarUsuarioCliente>();
builder.Services.AddTransient<ServicioRegistrarUsuario>();
builder.Services.AddScoped<IServicioEmail,ServicioEmail>();
builder.Services.AddTransient<IRepositorioInmueble, InmuebleSqlite>();
builder.Services.AddScoped<CargarInmueble>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

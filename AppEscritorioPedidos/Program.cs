using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Datos.Context; 
using System.Configuration;
using Entidades;
using Datos.Repositorios;
using Controlador;

namespace AppEscritorioPedidos
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // Leer configuración desde App.config


            string cadena = ConfigurationManager.ConnectionStrings["Sql_conexion"].ConnectionString;


            // Registrar servicios
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(cadena));

            // Aquí puedes agregar más servicios (repositorios, controladores, etc.)
            services.AddScoped<Usuario>();
            services.AddScoped<IngresarRepo>();
            services.AddScoped<Ingresar_Usua>();
            services.AddScoped<RecuContrasenaRepo>();
            services.AddScoped<Recuperar_Usua>();
            services.AddScoped<ValidaMenuRepo>();
            services.AddScoped<ValidacionMenu>();
            

            // Construir proveedor
            ServiceProvider = services.BuildServiceProvider();

            // Inicializar app
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }
    }
}

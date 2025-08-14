    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Datos.Context;
    using Entidades;
    using Microsoft.EntityFrameworkCore;
    namespace Datos.Repositorios;

    public class GestionUsuarioRepo
    {

        public AppDbContext _db;
        public GestionUsuarioRepo(AppDbContext db)
        {
            _db = db;

        }

        public async Task<List<Usuario>> MostrarUsua()
        {
            return await _db.Usuarios
                            .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                            .TolistAsync();
        }

        public async Task<List<Usuario>> MostrarActivo()
        {

            return await _db.Usuarios
                            .Where(u => u.Activo == 1)
                            .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                            .TolistAsync();
        }

        public async Task<List<Usuario>> MostrarDesactivados()
        {
            return await _db.Usuarios
                            .Where(u => u.Activo == 0)
                            .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                            .TolistAsync();
        }
    }
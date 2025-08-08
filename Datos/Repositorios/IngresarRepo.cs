using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Context;
using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Datos.Repositorios
{
    public class IngresarRepo
    {
        public AppDbContext _db;
        public IngresarRepo(AppDbContext db)
        {
            var _db = db;
            
        }

        public async Task<Usuario?> Buscarusua_repo(int id, string claveencript)
        {
            return await _db.Usuarios
                   .AsNoTracking()
                   .FirstOrDefaultAsync(u => u.id == id &&  u.Contrasena == claveencript);
    
        }

        public async Task<bool> Activo(int usuario)
        {
            var valida = await _db.Usuarios
                .AsNoTracking()
                .AnyAsync(u => u.id == usuario && u.Activo == 1 );
            return valida ;
        }

    }
}

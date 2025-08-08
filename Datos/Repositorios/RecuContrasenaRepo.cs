using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Context;
using Entidades;

namespace Datos.Repositorios
{
    public class RecuContrasenaRepo
    {
        private AppDbContext _db;

        public RecuContrasenaRepo(AppDbContext db) 
        {
            _db=db;
        }

        public async Task cambiarClave(int id, string clave)
        {
            var cambio = await _db.Usuarios.FindAsync(id);
            if (cambio is not null)
            {
                cambio.Contrasena = clave;
                await _db.SaveChangesAsync();
            }
        }


    }
}

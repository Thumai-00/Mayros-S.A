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
    public class ValidaMenuRepo
    {
        public AppDbContext _db;

        public ValidaMenuRepo( AppDbContext db)
        {
                _db=db; 
        }

        public async Task<bool> validarPedido(int usuario)
        {

            var permisosValidos = new[] { 1, 2, 3, 4 }; // Lista de permisos aceptados

            return await _db.Usuarios
                .AnyAsync(u => u.id == usuario &&
                               u.Tip_Usuarios.Any(t =>
                                   permisosValidos.Contains(t.IdTip_usuario) // Busca en la lista
                                 ));
        }




        public async Task<bool> validarUsuarios(int usuario)
        {

            var permisosValidos = new[] { 1, 2, 3}; // Lista de permisos aceptados

            return await _db.Usuarios
                .AnyAsync(u => u.id == usuario &&
                               u.Tip_Usuarios.Any(t =>
                                   permisosValidos.Contains(t.IdTip_usuario) // Busca en la lista
                                 ));

        }


        public async Task<bool> validarBarridos(int usuario)
        {

           var permisosValidos = new[] { 1, 2, 3, 4}; // Lista de permisos aceptados

            return await _db.Usuarios
                .AnyAsync(u => u.id == usuario &&
                               u.Tip_Usuarios.Any(t =>
                                   permisosValidos.Contains(t.IdTip_usuario) // Busca en la lista
                                 ));

        }


        public async Task<bool> validarReportes(int usuario)
        {

            var permisosValidos = new[] { 1, 2, 3, 4 }; // Lista de permisos aceptados

            return await _db.Usuarios
                .AnyAsync(u => u.id == usuario &&
                               u.Tip_Usuarios.Any(t =>
                                   permisosValidos.Contains(t.IdTip_usuario) // Busca en la lista
                                 ));

        }

        
        


    }


    
}

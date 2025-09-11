using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS;
using Datos.Context;
using Entidades;
using Microsoft.EntityFrameworkCore;
 

namespace Datos.Repositorios
{
    public class GestionPedidosRepo
    {
        public AppDbContext _db;
        public GestionPedidosRepo(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<PedidosDTO>> MostrarPedidos()
        {
            return await _db.Pedidos
                .Include(p => p.Tienda)
                .Include(p => p.Compania_Envios)
                .Include(p => p.Estado_Envio)
                .Select(p => new PedidosDTO
                {
                    N_guia = p.N_guia,
                    Nombre_Tienda = p.Tienda.Nombre_Tienda,
                    Nombre_Compania = p.Compania_Envios.Nombre_Compania,
                    Estado = p.Estado_Envio.Estado,
                    Usuario = p.Usuario
                })
                .ToListAsync();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Context;
using Entidades;

namespace Datos.Repositorios
{
    public class GestionPedidosRepo
    {
        public AppDbContext _db;
        public GestionPedidosRepo(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Pedido>> MostrarPedidos()
        {
            return await _db.Pedidos.
                Select(p => new { p.N_guia,p.Fecha_Creacion, })
        }

    }
}

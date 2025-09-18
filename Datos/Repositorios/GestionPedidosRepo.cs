using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS;
using Datos.Context;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;


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

        public async Task<bool> ModiPedido(int id, int Estado, int Tienda, string UltiFecha)
        {
            var pedido = _db.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                pedido.Estado = Estado;
                pedido.Tienda = Tienda;
                pedido.Ultima_Mofi = UltiFecha;

                return await _db.Pedidos.SaveChangesAsync;
            }
            else
            {
                return false;

            }


        }


        public async Task<bool> IngresarPedido(Pedido pedido)
        {

            _db.Pedidos.Add(pedido);
            _db.Pedidos.SaveChangesAsync();
            return true;
        }

        public async Task pedido()
        {
            
        }


    }
}

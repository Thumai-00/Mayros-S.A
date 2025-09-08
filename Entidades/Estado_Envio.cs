using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estado_Envio
    {
        public int id {  get; set; }
        public string Estado {  get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}

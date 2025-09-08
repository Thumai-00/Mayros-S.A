using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public string N_guia {  get; set; }
        public string Barcode { get; set; }
        public Tienda Tienda { get; set; } 
        public Compania_Envios Compania_Envios { get; set; }
        public string Fecha_Creacion { get; set; }
        public string Ultima_Mofi { get; set; }
        public string Descripcion {  get; set; }    

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public int Rut { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }
        public int Activo { get; set; }
        public ICollection<Tipos_Usuarios> Tip_Usuarios { get; set; } = new List<Tipos_Usuarios>();
    }
}

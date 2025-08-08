using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Tipos_Usuarios
    {
        public int IdTip_usuario { get; set; }
        public int Tip_Permiso { get; set; }
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    }
}

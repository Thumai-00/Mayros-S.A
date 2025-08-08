using System.Data.SqlTypes;
using Datos.Repositorios;
using Entidades;

namespace Controlador
{
    public class Recuperar_Usua
    {
        public RecuContrasenaRepo _recuperar;
        public Recuperar_Usua(RecuContrasenaRepo recuperar)
        {
            _recuperar=recuperar;
        }

    public Task cambiasContraseña(int id, string clave)
        {
            return _recuperar.cambiarClave(id, clave);
        }



    }
}

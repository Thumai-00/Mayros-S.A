using System.ComponentModel;
using Datos.Repositorios;
using Entidades;

namespace Controlador
{
    public class GestionUsuarios
    {
        public GestionUsuarioRepo _gestion;
        public GestionUsuarios(GestionUsuarioRepo gestion)
        {
            _gestion = gestion;
        }

        public async Task<List<Usuario>> Mostrar()
        {
            return await _gestion.MostrarUsua();
        }

        public async Task<List<Usuario>> MostrarActi()
        {
            return await _gestion.MostrarActivo();
        }

        public async Task<List<Usuario>> MostrarDesacti()
        {
            return await _gestion.MostrarDesactivados();
        }


        public async Task<bool> ModiUsuario(int id, string Nombre, string Apellido, int Rut, long Telefono, string Correo, int Activo)
        {
            return await _gestion.ModificarUsua(id, Nombre, Apellido, Rut, Telefono, Correo, Activo);
        }

        public async Task<bool> activa_DesactivaUsu(int id, string Activo)
        {
            if (!int.TryParse(Activo, out int activo))
            {
                return false;
            }
            return await _gestion.Act_Desa_Usua(id, activo);
        }

        public async Task<bool> CrearUsua(Usuario usuario)
        {
            return await _gestion.CrearUsuario(usuario);
        }


    }

}
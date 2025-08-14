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

    }




}
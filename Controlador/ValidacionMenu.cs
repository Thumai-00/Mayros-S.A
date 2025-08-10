using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositorios;

namespace Controlador
{
    public class ValidacionMenu

    {
        public ValidaMenuRepo _validacion;
        public ValidacionMenu(ValidaMenuRepo validacion)
        {
            _validacion = validacion;
                
        }

        public async Task<bool> ValidaPedido( string usuario)
        {
            if (!int.TryParse(usuario, out int Usuario)) {

                return false;  
                           
            }

            return await _validacion.validarPedido(Usuario);

        
        
        }
        public async Task<bool> ValidaUsuario(string usuario)
        {
            if (!int.TryParse(usuario, out int Usuario))
            {

                return false;

            }

            return await _validacion.validarUsuarios(Usuario);



        }

        public async Task<bool> ValidaBarrido(string usuario)
        {
            if (!int.TryParse(usuario, out int Usuario))
            {

                return false;

            }

            return await _validacion.validarBarridos(Usuario);



        }

        public async Task<bool> ValidaReportes(string usuario)
        {
            if (!int.TryParse(usuario, out int Usuario))
            {

                return false;

            }

            return await _validacion.validarReportes(Usuario);



        }
    }
}

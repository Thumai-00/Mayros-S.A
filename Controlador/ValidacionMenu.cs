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

        public async Task<bool> ValidaPedido( int usuario)
        {
            
            return await _validacion.validarPedido(usuario);

        
        
        }
        public async Task<bool> ValidaUsuario(int usuario)
        {
            

            return await _validacion.validarUsuarios(usuario);



        }

        public async Task<bool> ValidaBarrido(int usuario)
        {
            

            return await _validacion.validarBarridos(usuario);



        }

        public async Task<bool> ValidaReportes(int usuario)
        {
         

            return await _validacion.validarReportes(usuario);



        }
    }
}

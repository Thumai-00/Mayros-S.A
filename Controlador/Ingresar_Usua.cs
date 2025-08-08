using System.ComponentModel;
using Datos.Repositorios;
using Entidades;


namespace Controlador
{
    public class Ingresar_Usua
    {
       public IngresarRepo _ingreso;

        public  Ingresar_Usua (IngresarRepo ingreso) // crea un constructor y llama la clase Ingresar_Usua
        {
            _ingreso = ingreso;
        }



        public async Task<Usuario> Ingresar(int id, string clave) // lo que esta hace esta funcion es que arroja un buleano donde las validacion sean correctas y llama una funcion  de la capa de datos para insertar
        {
            
            return await _ingreso.Buscarusua_repo(id, clave);
           
        }

        public async Task<bool> validarActivo(int id)
        {

            return await _ingreso.Activo(id);
        }

    }
}

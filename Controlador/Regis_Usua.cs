using System.Security.Cryptography;
using System.Text;
using Datos.Repositorios;
using Entidades;



namespace Controlador
{
    public class Regis_Usua
    {
        private Registrar_db _insertar; // se crea un variable para poder manejar funciones de la capa de Dtos 

        public Regis_Usua() // se crea un variable en el constructo para que solo se pueda manejar este esta clase para manejar funciones de la capa de Dtos 
        {
            _insertar = new Registrar_db();
        }

        public string Encriptar(string contraseña) // Esta funcion es un encriptador y descriptador para validar las constraseñas.
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }

        }

        public bool inserta_Usu(Registrar registrar) // Esta funcion lo que hace es validar si en los campos de  si estan vacios y si lo estan retorna un false pero si no lo encripta 
                                                     // y lo guarda en la variable de la entidad de Contraseña
        {
            try
            {
                if (string.IsNullOrEmpty(registrar.Contraseña) || string.IsNullOrEmpty(registrar.Correo))
                {
                    return false;
                }
                else
                {
                    registrar.Contraseña = Encriptar(registrar.Contraseña);
                    return _insertar.Registrar_usuario(registrar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("En el controlador hubo un error", ex);
            }

        }

    }
}

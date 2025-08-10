using System.Configuration;
using System.Threading.Tasks;
using Controlador;
using Entidades;
using Microsoft.Data.SqlClient;
using Vistas;

namespace AppEscritorioPedidos

{
    public partial class Login : Form
    {
        public Ingresar_Usua _ingreso;
        public Recuperar_Usua _recuperar;
        public Login(Ingresar_Usua ingreso, Recuperar_Usua recuperar)
        {
            InitializeComponent();
            Contraseña.UseSystemPasswordChar = true;
            _ingreso = ingreso;
            _recuperar = recuperar;
        }




        private async void BtonIngresar(object sender, EventArgs e)
        {
            var id = IdUsuario.Text;
            var Clave = Contraseña.Text;

            if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(Clave))
            {
                MessageBox.Show("ADVERTENCIA!! \n Debes llenar los campos  ");

            }

            if (!int.TryParse(id, out int id_usuario))
            {
                MessageBox.Show("ERROR! Su usuario debe tener solo numero");
                id = null;
                Clave = null;
            }
            else
            {

                if (!await _ingreso.validarActivo(id_usuario))
                {
                    MessageBox.Show("ERROR! Su usuario se encuentra eliminado  \n Validar con Supervisor");
                    id = null;
                    Clave = null;
                }

                var usuario = _ingreso.Ingresar(id_usuario, Clave);
                if (usuario != null)
                {
                    MessageBox.Show("Bienvenido a la App de Pedidos ");
                    this.Hide();
                    Menu_Principal v2 = new Menu_Principal();
                    v2.Show();
                }
                

            }





        }



        private async void MostrarVentanaCambiarContrasena()
        {
            Form ventana = new Form();
            ventana.Text = "Cambiar Contraseña";
            ventana.Size = new Size(350, 260);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
            ventana.MaximizeBox = false;

            // 🔷 Labels
            Label lblCorreo = new Label() { Text = "Correo:", Location = new Point(30, 20), AutoSize = true };
            Label lblNueva = new Label() { Text = "Nueva Contraseña:", Location = new Point(30, 70), AutoSize = true };
            Label lblRepetir = new Label() { Text = "Repetir Contraseña:", Location = new Point(30, 120), AutoSize = true };

            // 🔷 Campos de texto
            TextBox txtUsuario = new TextBox() { Location = new Point(170, 20), Width = 140 };
            TextBox txtNueva = new TextBox() { Location = new Point(170, 70), Width = 140, UseSystemPasswordChar = true };
            TextBox txtRepetir = new TextBox() { Location = new Point(170, 120), Width = 140, UseSystemPasswordChar = true };

            // 🔷 Botones
            Button btnCambiar = new Button() { Text = "Cambiar", Location = new Point(60, 170), Width = 100 };
            Button btnCerrar = new Button() { Text = "Cerrar", Location = new Point(180, 170), Width = 100 };

            // Evento cerrar
            btnCerrar.Click += (s, e) => ventana.Close();

            // Evento cambiar
            btnCambiar.Click += async (s, e) =>
            {


                if (!int.TryParse(txtUsuario.Text, out int usuario))
                {
                    MessageBox.Show("ERROR!! Su usuario debe tener solo numero");
                    txtUsuario.Text = null;
                    txtNueva.Text = null;
                    txtRepetir.Text = null;
                }
                var activo = await _ingreso.validarActivo(usuario);
                if (!activo)
                {
                    MessageBox.Show("ERROR!! Su usuario se encuentra eliminado  \n Validar con Supervisor");
                    txtUsuario.Text = null;
                    txtNueva.Text = null;
                    txtRepetir.Text = null;

                }

                await _recuperar.cambiasContraseña(usuario, txtRepetir.Text);
                MessageBox.Show("OK!! \n Se realiza el cambio de contraseña correctamente  ");
                ventana.Close();

            };

            // 🔷 Agregar controles
            ventana.Controls.Add(lblCorreo);
            ventana.Controls.Add(lblNueva);
            ventana.Controls.Add(lblRepetir);
            ventana.Controls.Add(txtUsuario);
            ventana.Controls.Add(txtNueva);
            ventana.Controls.Add(txtRepetir);
            ventana.Controls.Add(btnCambiar);
            ventana.Controls.Add(btnCerrar);

            // Mostrar la ventana
            ventana.ShowDialog();
        }

        private void linkRecupera_contra(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MostrarVentanaCambiarContrasena();
        }

       
    }
}

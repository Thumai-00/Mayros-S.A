using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vistas
{
    public partial class Menu_Principal : Form
    {
        public Usuario _usuarios;
        public ValidacionMenu _validar;
        public Menu_Principal(Usuario usuario, ValidacionMenu validar = null)
        {
            InitializeComponent();
            this.Size = new Size(1024, 768);        // Tamaño fijo
            this.MaximumSize = new Size(1024, 768); // Tamaño máximo
            this.MinimumSize = new Size(1024, 768); // Tamaño mínimo
            this.StartPosition = FormStartPosition.CenterScreen; // Centrado en pantalla\
            _usuarios = usuario;
            _validar = validar;
        }

        private async void pictureBox1_Pedidos(object sender, EventArgs e)
        {
            bool Pedidos = await _validar.ValidaPedido(_usuarios.id);

            if (!Pedidos)
            {
                MessageBox.Show("No tienes acceso a esta opcion");
            }

        }

        private async void pictureBox2_Usuario(object sender, EventArgs e)
        {
            bool Usuarios = await _validar.ValidaUsuario(_usuarios.id);

            if (!Usuarios)
            {
                MessageBox.Show("No tienes acceso a esta opcion");
            }
        }

        private async void pictureBox3_Barridos(object sender, EventArgs e)
        {
            bool Barridos = await _validar.ValidaUsuario(_usuarios.id);

            if (!Barridos)
            {
                MessageBox.Show("No tienes acceso a esta opcion");
            }
        }

        private async void pictureBox4_Reportes(object sender, EventArgs e)
        {
            bool Reportes = await _validar.ValidaUsuario(_usuarios.id);

            if (!Reportes)
            {
                MessageBox.Show("No tienes acceso a esta opcion");
            }
        }
    }
}

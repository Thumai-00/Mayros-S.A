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
        public Menu_Principal(Usuario usuario, ValidacionMenu validar)
        {
            InitializeComponent();
            this.Size = new Size(1024, 768);        // Tamaño fijo
            this.MaximumSize = new Size(1024, 768); // Tamaño máximo
            this.MinimumSize = new Size(1024, 768); // Tamaño mínimo
            this.StartPosition = FormStartPosition.CenterScreen; // Centrado en pantalla\
            _usuarios = usuario;
            _validar = validar; 
        }

        private async void  pictureBox1_pedidos(object sender, EventArgs e)
        {
            return await _validar.ValidaPedido(_usuarios.id);

        }
    }
}

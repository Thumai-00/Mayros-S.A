using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            this.Size = new Size(1024, 768);        // Tamaño fijo
            this.MaximumSize = new Size(1024, 768); // Tamaño máximo
            this.MinimumSize = new Size(1024, 768); // Tamaño mínimo
            this.StartPosition = FormStartPosition.CenterScreen; // Centrado en pantalla
        }

        
    }
}

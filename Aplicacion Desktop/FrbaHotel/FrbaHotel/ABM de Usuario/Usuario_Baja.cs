using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class Usuario_Baja : Form
    {
        private static Usuario_Baja _instancia;

        public static Usuario_Baja ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Usuario_Baja();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Usuario_Baja()
        {
            InitializeComponent();
        }
    }
}

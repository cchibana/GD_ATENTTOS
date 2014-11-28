using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Rol_Baja : Form
    {
        private static Rol_Baja _instancia;

        public static Rol_Baja ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Rol_Baja();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private Rol_Baja()
        {
            InitializeComponent();
        }
    }
}

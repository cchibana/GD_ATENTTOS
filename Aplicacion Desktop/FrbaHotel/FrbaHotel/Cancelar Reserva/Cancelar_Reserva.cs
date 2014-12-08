using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class Cancelar_Reserva : Form
    {
        private static Cancelar_Reserva _instancia;

        public static Cancelar_Reserva ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Cancelar_Reserva();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Cancelar_Reserva()
        {
            InitializeComponent();
        }
    }
}

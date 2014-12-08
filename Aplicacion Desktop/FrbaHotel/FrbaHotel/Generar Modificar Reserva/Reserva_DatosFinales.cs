using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class Reserva_DatosFinales : Form
    {
        private static Reserva_DatosFinales _instancia;

        public static Reserva_DatosFinales ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_DatosFinales();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_DatosFinales()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            resGen.Show();
            this.Close();
        }
    }
}

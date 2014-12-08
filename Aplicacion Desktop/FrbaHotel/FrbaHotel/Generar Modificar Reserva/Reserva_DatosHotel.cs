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
    public partial class Reserva_DatosHotel : Form
    {
        private static Reserva_DatosHotel _instancia;

        public static Reserva_DatosHotel ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_DatosHotel();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_DatosHotel()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            resGen.Show();
            this.Close();
        }
    }
}

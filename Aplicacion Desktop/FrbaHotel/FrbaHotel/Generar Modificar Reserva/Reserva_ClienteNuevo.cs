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
    public partial class Reserva_ClienteNuevo : Form
    {
        private static Reserva_ClienteNuevo _instancia;

        public static Reserva_ClienteNuevo ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_ClienteNuevo();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_ClienteNuevo()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Reserva_ClienteBusqueda newCliBusqueda = Reserva_ClienteBusqueda.ObtenerInstancia();
            newCliBusqueda.Show();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            resGen.Show();
            this.Close();
        }
    }
}

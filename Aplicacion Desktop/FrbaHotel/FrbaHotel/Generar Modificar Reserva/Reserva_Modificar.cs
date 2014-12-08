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
    public partial class Reserva_Modificar : Form
    {
        private static Reserva_Modificar _instancia;

        public static Reserva_Modificar ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_Modificar();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_Modificar()
        {
            InitializeComponent();
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {
            string nroReserva = txt_NroReserva.Text;
            Dominio.Reserva res1 = new Dominio.Reserva();
            DataTable dtReserva = res1.ObtenerDatosReserva(nroReserva);
            DataTable dtCliente = res1.ObtenerDatosCliente(nroReserva);
            DataTable dtHabitaciones = res1.ObtenerDatosHabitaciones(nroReserva);
        }
    }
}

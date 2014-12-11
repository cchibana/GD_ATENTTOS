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
    public partial class LogReservas : Form
    {
        private static LogReservas _instancia;

        public static LogReservas ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new LogReservas();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public LogReservas()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            DataTable dt = res1.ObtenerLogReserva(txt_NroReserva.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados para el número de reserva ingresado");
            }
            else
            {
                dgv_LogReservas.DataSource = dt;
                dgv_LogReservas.Columns[0].Width = 100;
                dgv_LogReservas.Columns[1].Width = 100;
                dgv_LogReservas.Columns[2].Width = 120;
                dgv_LogReservas.Columns[3].Width = 100;
                dgv_LogReservas.Columns[4].Width = 120;
                dgv_LogReservas.Columns[5].Width = 200;
            } 
        }
    }
}

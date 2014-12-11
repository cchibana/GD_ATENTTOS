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
    public partial class Reserva_Regimenes : Form
    {
        private static Reserva_Regimenes _instancia;

        public static Reserva_Regimenes ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_Regimenes();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_Regimenes()
        {
            InitializeComponent();
        }

        public void CargarGrid(int HotelIdSeleccionado)
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            DataTable dt_Regimenes = res1.ListarRegimenes(HotelIdSeleccionado);
            dgv_Regimenes.DataSource = dt_Regimenes;
            dgv_Regimenes.Columns[0].Width = 100;
            dgv_Regimenes.Columns[1].Width = 150;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

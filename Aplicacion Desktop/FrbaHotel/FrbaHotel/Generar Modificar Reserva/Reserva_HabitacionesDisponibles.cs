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
    public partial class Reserva_HabitacionesDisponibles : Form
    {
        private static Reserva_HabitacionesDisponibles _instancia;

        public static Reserva_HabitacionesDisponibles ObtenerInstancia(DataTable dt)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_HabitacionesDisponibles(dt);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_HabitacionesDisponibles(DataTable dt)
        {
            InitializeComponent();
            CargarDgv(dt);
        }

        private void CargarDgv(DataTable dt)
        {
            dgv_HabitacionesDisponibles.DataSource = dt;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarAReserva_Click(object sender, EventArgs e)
        {

            if (dgv_HabitacionesDisponibles.CurrentRow != null)
            {
                Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
                resGen.AgregarHabitacion(dgv_HabitacionesDisponibles.CurrentRow.Cells[0].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[1].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[2].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[3].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[4].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[5].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[6].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[7].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[8].Value.ToString(),
                                            dgv_HabitacionesDisponibles.CurrentRow.Cells[9].Value.ToString());
                //dataGridView2.Rows[index].Cells[0].Value


            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitación");
            }

        }
    }
}

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
        int NroReservaBuscado;

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
            gb_Cliente.Visible = false;
            gb_Importes.Visible = false;
            gb_Reserva.Visible = false;
            txt_motivo.Visible = false;
            lbl_Motivo.Visible = false;
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {
            if (txt_NroReserva.Text != "")
            {
                Limpiar();
                string nroReserva = txt_NroReserva.Text;
                this.NroReservaBuscado = Convert.ToInt32(nroReserva);
                Dominio.Reserva res1 = new Dominio.Reserva();
                DataTable dtReserva = res1.ObtenerDatosReserva(nroReserva);
                if (dtReserva.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para el número de reserva ingresado");
                }
                else
                {
                    CargarDatosReserva(dtReserva);

                    DateTime fechaReservaInicio = Convert.ToDateTime(dtReserva.Rows[0][3].ToString());
                    DataTable dtCliente = res1.ObtenerDatosCliente(nroReserva);
                    CargarDatosCliente(dtCliente);
                    DataTable dtHabitaciones = res1.ObtenerDatosHabitaciones(nroReserva);
                    CargarDatosHabitaciones(dtHabitaciones);
                    gb_Cliente.Visible = true;
                    gb_Reserva.Visible = true;
                    gb_Importes.Visible = true;
                    txt_motivo.Visible = false;
                    lbl_Motivo.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de Reserva");
            }
        }
        private void CargarDatosReserva(DataTable dtReserva)
        {
            txt_CiudadReserva.Text = dtReserva.Rows[0][0].ToString();
            txt_HotelReserva.Text = dtReserva.Rows[0][1].ToString();
            txt_TipoRegimenReserva.Text = dtReserva.Rows[0][6].ToString();
            txt_FechaIngresoReserva.Text = Convert.ToDateTime(dtReserva.Rows[0][3].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            txt_FechaEgresoReserva.Text = Convert.ToDateTime(dtReserva.Rows[0][4].ToString()).ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void CargarDatosCliente(DataTable dtCliente)
        {
            txt_NroCliente.Text = dtCliente.Rows[0][0].ToString();
            txt_ApellidoCliente.Text = dtCliente.Rows[0][1].ToString();
            txt_NombreCliente.Text = dtCliente.Rows[0][2].ToString();
            txt_TipoIdentificacionCliente.Text = dtCliente.Rows[0][3].ToString();
            txt_NroIdentificacionCliente.Text = dtCliente.Rows[0][4].ToString();
            txt_MailCliente.Text = dtCliente.Rows[0][5].ToString();
        }

        private void CargarDatosHabitaciones(DataTable dtHabitaciones)
        {
            txt_ImporteDia.Text = "0";
            txt_ImporteTotal.Text = "0";
            for (int i = 0; i < dtHabitaciones.Rows.Count; i++)
            {
                dgv_HabitacionesReserva.Rows.Add();

                dgv_HabitacionesReserva.Rows[i].Cells["Reg_Descripcion"].Value = dtHabitaciones.Rows[i][0].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Reg_Codigo"].Value = dtHabitaciones.Rows[i][1].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["FechaInicio"].Value = Convert.ToDateTime(dtHabitaciones.Rows[i][2].ToString());
                dgv_HabitacionesReserva.Rows[i].Cells["FechaFin"].Value = Convert.ToDateTime(dtHabitaciones.Rows[i][3].ToString());
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Numero"].Value = dtHabitaciones.Rows[i][4].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Descripcion"].Value = dtHabitaciones.Rows[i][8].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Piso"].Value = dtHabitaciones.Rows[i][6].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Ubicacion"].Value = dtHabitaciones.Rows[i][7].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Tipo_Habitacion"].Value = dtHabitaciones.Rows[i][5].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hab_Hot_Codigo"].Value = dtHabitaciones.Rows[i][9].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Hot_Nombre"].Value = dtHabitaciones.Rows[i][10].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["Precio_por_dia"].Value = dtHabitaciones.Rows[i][11].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["cantNoches"].Value = dtHabitaciones.Rows[i][12].ToString();
                dgv_HabitacionesReserva.Rows[i].Cells["PrecioTotalHab"].Value = dtHabitaciones.Rows[i][13].ToString();

                txt_ImporteDia.Text = (Convert.ToDecimal(txt_ImporteDia.Text.ToString()) + Convert.ToDecimal(dtHabitaciones.Rows[i][11].ToString())).ToString();
                txt_ImporteTotal.Text = (Convert.ToDecimal(txt_ImporteTotal.Text.ToString()) + Convert.ToDecimal(dtHabitaciones.Rows[i][13].ToString())).ToString();
                txt_CantNoches.Text = dtHabitaciones.Rows[i][12].ToString();
            }
        }

        private void Limpiar()
        {
            txt_CiudadReserva.Text = null;
            txt_HotelReserva.Text = null;
            txt_TipoRegimenReserva.Text = null;
            txt_FechaIngresoReserva.Text = Dominio.UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss");
            txt_FechaEgresoReserva.Text = Dominio.UsuarioLogin.TheInstance.getFechaSistema().AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
            txt_NroCliente.Text = null;
            txt_ApellidoCliente.Text = null;
            txt_NombreCliente.Text = null;
            txt_TipoIdentificacionCliente.Text = null;
            txt_NroIdentificacionCliente.Text = null;
            txt_MailCliente.Text = null;
            txt_ImporteDia.Text = "0";
            txt_ImporteTotal.Text = "0";
            txt_CantNoches.Text = "0";
            dgv_HabitacionesReserva.Rows.Clear();
        }

        private void btn_CancelarReserva_Click(object sender, EventArgs e)
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            string usuario;
            string motivo;
            if (Dominio.UsuarioLogin.TheInstance.getUsuario() == null)
            {
                usuario = "guest";
                if (txt_motivo.Text == "")
                {
                    motivo = "Cancelada por el usuario";
                }
                else
                {
                    motivo = "Usuario: " + txt_motivo.Text;
                }
            }
            else
            {
                usuario = Dominio.UsuarioLogin.TheInstance.getUsuario();
                if (txt_motivo.Text == "")
                {
                    motivo = "Cancelada por la recepción";
                }
                else
                {
                    motivo = "Recepción: " + txt_motivo.Text;
                }
            }
            if (res1.CancelarReserva(NroReservaBuscado, usuario, motivo))
            {
                MessageBox.Show("Se ha cancelado la reserva " + NroReservaBuscado.ToString());
            }
            else
            {
                MessageBox.Show("Se ha producido un error al dar de baja la reserva" + NroReservaBuscado.ToString());
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

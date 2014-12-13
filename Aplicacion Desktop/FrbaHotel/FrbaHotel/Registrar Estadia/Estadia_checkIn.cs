using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Estadia_checkIn : Form
    {

        private static Estadia_checkIn _instancia;

        public static Estadia_checkIn ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Estadia_checkIn();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Estadia_checkIn()
        {
            InitializeComponent();

            int idHotel = Dominio.UsuarioLogin.TheInstance.getHotel();
            txt_hotel.Text = idHotel.ToString();

            string idUser = Dominio.UsuarioLogin.TheInstance.getUsuario();
            txt_usuario.Text = idUser.ToString();
        }

        private void Limpiar()
        {            
            txt_regimen.Text = null;
            dtp_FechaIngreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema();
            dtp_FechaEgreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema().AddDays(1);
            txt_NroCliente.Text = null;
            txt_ApellidoCliente.Text = null;
            txt_NombreCliente.Text = null;
            txt_TipoIdentificacionCliente.Text = null;
            txt_NroIdentificacionCliente.Text = null;
            txt_MailCliente.Text = null;            
            dgv_HabitacionesReserva.Rows.Clear();
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {
            if (txt_NroReserva.Text != "")
            {
                Limpiar();
                string nroReserva = txt_NroReserva.Text;
                Dominio.Reserva res1 = new Dominio.Reserva();
                DataTable dtReserva = res1.ObtenerDatosReserva(nroReserva);
                if (dtReserva.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para el número de reserva ingresado");
                }
                else
                {
                    CargarDatosReserva(dtReserva);
                    DataTable dtCliente = res1.ObtenerDatosCliente(nroReserva);
                    CargarDatosCliente(dtCliente);                    
                    DataTable dtHabitaciones = res1.ObtenerDatosHabitaciones(nroReserva);
                    CargarDatosHabitaciones(dtHabitaciones);
                    gb_Cliente.Visible = true;
                    gb_Reserva.Visible = true;
                    gb_Estadia.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de Reserva");
            }
        }

        private void CargarDatosReserva(DataTable dtReserva)
        {                       
            dtp_FechaIngreso.Value = Convert.ToDateTime(dtReserva.Rows[0][3].ToString());
            dtp_FechaEgreso.Value = Convert.ToDateTime(dtReserva.Rows[0][4].ToString());
            txt_regimen.Text = dtReserva.Rows[0][5].ToString();       
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

        private void CargarDatosEstadia(DataTable dtEstadia)
        {
            txt_NroCliente.Text = dtEstadia.Rows[0][0].ToString();
            txt_ApellidoCliente.Text = dtEstadia.Rows[0][1].ToString();
            txt_NombreCliente.Text = dtEstadia.Rows[0][2].ToString();
            txt_TipoIdentificacionCliente.Text = dtEstadia.Rows[0][3].ToString();
            txt_NroIdentificacionCliente.Text = dtEstadia.Rows[0][4].ToString();
            txt_MailCliente.Text = dtEstadia.Rows[0][5].ToString();
        }

        private void CargarDatosHabitaciones(DataTable dtHabitaciones)
        {
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

                txt_CantNoches.Text = dtHabitaciones.Rows[i][12].ToString();
                txt_tipoHab.Text = dtHabitaciones.Rows[i][5].ToString();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            Dominio.Estadia est1 = new Dominio.Estadia();
            if (est1.verificaReservaCod(txt_NroReserva.Text))
            {
                if (est1.RegistrarEnTablaEstadias(txt_NroReserva.Text, txt_CantNoches.Text, txt_usuario.Text) &&
                   est1.CambiarEstadoReserva(txt_NroReserva.Text))
                {
                    MessageBox.Show("Se registró correctamente la estadía");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la estadía");
                }
            }
            else
            {
                MessageBox.Show("Error, ya se ha realizado el check In de la reserva.");
            }
        }

    }
}

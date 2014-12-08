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
    public partial class Reserva_Generar : Form
    {
        private static Reserva_Generar _instancia;

        public static Reserva_Generar ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_Generar();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_Generar()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        private void InicializarCiudadHotel()
        {
            if (Dominio.UsuarioLogin.TheInstance.getHotelNombre() != null)
            {
                Dominio.Reserva res1 = new Dominio.Reserva();
                DataTable dt_Ciudades = res1.BuscarCiudadDelHotel(Dominio.UsuarioLogin.TheInstance.getHotel());
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_Ciudades.Rows[0][1].ToString();
                item.Value = dt_Ciudades.Rows[0][0].ToString();
                cb_Ciudad.Items.Add(item);
                Dominio.ComboBoxItem itemHotel = new Dominio.ComboBoxItem();
                itemHotel.Text = Dominio.UsuarioLogin.TheInstance.getHotelNombre().ToString();
                itemHotel.Value = Dominio.UsuarioLogin.TheInstance.getHotel().ToString();

                cb_Hotel.Items.Add(itemHotel);
                cb_Ciudad.SelectedIndex = 0;
                cb_Hotel.SelectedIndex = 0;
            }
            else
            {
                InicializarComboBoxCiudad();
            }
        }

        private void InicializarComboBoxCiudad()
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            DataTable dt_Ciudades = res1.ListarCiudades();

            for (int i = 0; i < dt_Ciudades.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_Ciudades.Rows[i][1].ToString();
                item.Value = dt_Ciudades.Rows[i][0].ToString();

                cb_Ciudad.Items.Add(item);
            }
            cb_Ciudad.SelectedIndex = 0;
        }



        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            InicializarCiudadHotel();
            dtp_FechaEgreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema().AddDays(1);
            dtp_FechaIngreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema();
            dgv_HabitacionesReserva.Rows.Clear();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (dgv_HabitacionesReserva.Rows.Count > 1)
            {
                string primerRegimen = dgv_HabitacionesReserva.Rows[0].Cells[7].Value.ToString();
                bool mismoTipoRegimen = true;
                for (int i = 0; i < dgv_HabitacionesReserva.Rows.Count - 1; i++)
                {
                    if (dgv_HabitacionesReserva.Rows[i].Cells[7].Value.ToString() != primerRegimen)
                    {
                        MessageBox.Show("Todas las habitaciones de la reserva deben tener el mismo tipo de régimen.");
                        mismoTipoRegimen = false;
                        break;
                    }
                }
                if (mismoTipoRegimen)
                {
                    Reserva_ClienteBusqueda cliRes = Reserva_ClienteBusqueda.ObtenerInstancia();
                    cliRes.Show();
                    this.Hide();
                }   
            }
        }

        private void btn_VerDisponibilidad_Click(object sender, EventArgs e)
        {
            if (dtp_FechaIngreso.Value < dtp_FechaEgreso.Value)
            {
                Dominio.Reserva res1 = new Dominio.Reserva();

                Dominio.ComboBoxItem itemCb_Ciudad = (Dominio.ComboBoxItem)cb_Ciudad.SelectedItem;
                Dominio.ComboBoxItem itemCb_HotelID = (Dominio.ComboBoxItem)cb_Hotel.SelectedItem;
                Dominio.ComboBoxItem itemCb_RegimenID = (Dominio.ComboBoxItem) cb_Regimen.SelectedItem;
                Dominio.ComboBoxItem itemCb_TipoHabitacion = (Dominio.ComboBoxItem)cb_TipoHabitacion.SelectedItem;

                DataTable dt_HabitacionesDisponibles = res1.ListarHabitacionesDisponibles(  Convert.ToInt32(itemCb_HotelID.Value.ToString()),
                                                                                            itemCb_RegimenID.Value,
                                                                                            Convert.ToInt32(itemCb_TipoHabitacion.Value.ToString()),
                                                                                            dtp_FechaIngreso.Value,
                                                                                            dtp_FechaEgreso.Value) ;

                Reserva_HabitacionesDisponibles habDisp = Reserva_HabitacionesDisponibles.ObtenerInstancia(dt_HabitacionesDisponibles);
                habDisp.Show();
            }
            else
            {
                MessageBox.Show("La fecha de Ingreso debe ser anterior a la fecha de Egreso.");
            }


        }

        private void btn_DatosHotel_Click(object sender, EventArgs e)
        {
            Reserva_DatosHotel resDatosHotel = Reserva_DatosHotel.ObtenerInstancia();
            resDatosHotel.Show();
        }

        private void cb_Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dominio.UsuarioLogin.TheInstance.getHotelNombre() == null)
            {
                Dominio.Reserva res1 = new Dominio.Reserva();
                Dominio.ComboBoxItem itemCb_Ciudad = (Dominio.ComboBoxItem)cb_Ciudad.SelectedItem;
                DataTable dt_Hoteles = res1.ListarHoteles(itemCb_Ciudad.Value.ToString());

                cb_Hotel.Items.Clear();

                for (int i = 0; i < dt_Hoteles.Rows.Count; i++)
                {
                    Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                    item.Text = dt_Hoteles.Rows[i][1].ToString();
                    item.Value = dt_Hoteles.Rows[i][0].ToString();

                    cb_Hotel.Items.Add(item);
                }
                cb_Hotel.SelectedIndex = 0;
            }
        }

        private void cb_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            Dominio.ComboBoxItem itemCb_Hotel = (Dominio.ComboBoxItem)cb_Hotel.SelectedItem;
            DataTable dt_Regimenes = res1.ListarRegimenes(Convert.ToInt32(itemCb_Hotel.Value.ToString()));

            cb_Regimen.Items.Clear();

            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cb_Regimen.Items.Add(item0);

            for (int i = 0; i < dt_Regimenes.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_Regimenes.Rows[i][1].ToString();
                item.Value = dt_Regimenes.Rows[i][0].ToString();
                cb_Regimen.Items.Add(item);
            }

            cb_Regimen.SelectedIndex = 0;

            DataTable dt_TiposHabitaciones = res1.ListarTiposHabitaciones(Convert.ToInt32(itemCb_Hotel.Value.ToString()));

            cb_TipoHabitacion.Items.Clear();

            for (int i = 0; i < dt_TiposHabitaciones.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_TiposHabitaciones.Rows[i][1].ToString();
                item.Value = dt_TiposHabitaciones.Rows[i][0].ToString();
                cb_TipoHabitacion.Items.Add(item);
            }

            cb_TipoHabitacion.SelectedIndex = 0;
        }

        internal void AgregarHabitacion(string Hab_Numero, string Hab_Descripcion, string Hab_Piso, string Hab_Ubicacion, string Hab_Tipo_Habitacion, string Hab_Hot_Codigo, string Hot_Nombre, string Reg_Codigo, string Reg_Descripcion, string precioPorDia)
        {
            bool found = false;
            if (dgv_HabitacionesReserva.Rows.Count > 1)
            {
                for (int i = 0; i < dgv_HabitacionesReserva.Rows.Count - 1; i++)
                {
                    if (dgv_HabitacionesReserva.Rows[i].Cells[0].Value.ToString() == Hab_Numero && dgv_HabitacionesReserva.Rows[i].Cells[5].Value.ToString() == Hab_Hot_Codigo && dgv_HabitacionesReserva.Rows[i].Cells[6].Value.ToString() == Reg_Codigo)
                    {
                        found = true;
                        MessageBox.Show("Ya se ha agregado a la habitación seleccionada");
                        break;
                    }
                }
                if (!found)
                {
                    dgv_HabitacionesReserva.Rows.Add(Hab_Numero, Hab_Descripcion, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion, Hab_Hot_Codigo, Hot_Nombre, Reg_Codigo, Reg_Descripcion, precioPorDia);
                }
            }
            else
            {
                dgv_HabitacionesReserva.Rows.Add(Hab_Numero, Hab_Descripcion, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion, Hab_Hot_Codigo, Hot_Nombre, Reg_Codigo, Reg_Descripcion, precioPorDia);
            }
        }

        private void btn_BorrarHabitacion_Click(object sender, EventArgs e)
        {
            if (dgv_HabitacionesReserva.CurrentRow != null && dgv_HabitacionesReserva.CurrentRow.Cells[0] != null)
            {
                dgv_HabitacionesReserva.Rows.RemoveAt(dgv_HabitacionesReserva.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna habitación");
            }
        }
    }
}

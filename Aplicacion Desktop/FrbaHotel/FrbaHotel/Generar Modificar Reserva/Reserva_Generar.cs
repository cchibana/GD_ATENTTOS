﻿using System;
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
        int inicial;

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
                inicial = 0;
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
            inicial = 0;
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
                inicial = 0;
            }
        }

        private void cb_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dominio.Reserva res1 = new Dominio.Reserva();
            Dominio.ComboBoxItem itemCb_Hotel = (Dominio.ComboBoxItem)cb_Hotel.SelectedItem;
            DataTable dt_Regimenes = res1.ListarRegimenes(Convert.ToInt32(itemCb_Hotel.Value.ToString()));

            cb_Regimen.Items.Clear();
            inicial = 0;

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



        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            InicializarCiudadHotel();
            dtp_FechaEgreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema().AddDays(1);
            dtp_FechaIngreso.Value = Dominio.UsuarioLogin.TheInstance.getFechaSistema();
            dgv_HabitacionesReserva.Rows.Clear();
            txt_CantNoches.Text = null;
            txt_ImporteDia.Text = null;
            txt_ImporteTotal.Text = null;
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (dgv_HabitacionesReserva.Rows.Count > 1)
            {
                string primerRegimen = dgv_HabitacionesReserva.Rows[0].Cells[1].Value.ToString();
                bool mismoTipoRegimen = true;
                for (int i = 0; i < dgv_HabitacionesReserva.Rows.Count - 1; i++)
                {
                    if (dgv_HabitacionesReserva.Rows[i].Cells[1].Value.ToString() != primerRegimen)
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
            else
            {
                MessageBox.Show("Debe seleccionar alguna habitación para realizar la reserva");
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

                Reserva_HabitacionesDisponibles habDisp = Reserva_HabitacionesDisponibles.ObtenerInstancia('A');
                habDisp.CargarDgv(dt_HabitacionesDisponibles);
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

        internal void AgregarHabitacion(string Reg_Descripcion, string Reg_Codigo, string fechaInicio, string fechaFin, string Hab_Numero, string Hab_Descripcion, string Hab_Piso, string Hab_Ubicacion, 
                                        string Hab_Tipo_Habitacion, string Hab_Hot_Codigo, string Hot_Nombre, 
                                         string precioPorDia, string cantidadNoches, string precioTotalHabitacion)
        {
            bool found = false;
            if (dgv_HabitacionesReserva.Rows.Count > 1)
            {
                DateTime fechaInicio1 = Convert.ToDateTime(dgv_HabitacionesReserva.Rows[0].Cells[2].Value.ToString());
                DateTime fechaFin1 = Convert.ToDateTime(dgv_HabitacionesReserva.Rows[0].Cells[3].Value.ToString());
                for (int i = 0; i < dgv_HabitacionesReserva.Rows.Count - 1; i++)
                {
                    if (dgv_HabitacionesReserva.Rows[i].Cells[4].Value.ToString() == Hab_Numero && dgv_HabitacionesReserva.Rows[i].Cells[9].Value.ToString() == Hab_Hot_Codigo && dgv_HabitacionesReserva.Rows[i].Cells[1].Value.ToString() == Reg_Codigo)
                    {
                        found = true;
                        MessageBox.Show("Ya se ha agregado a la habitación seleccionada");
                        break;
                    }

                    if (Convert.ToDateTime(dgv_HabitacionesReserva.Rows[0].Cells[3].Value.ToString()) != Convert.ToDateTime(fechaFin) || Convert.ToDateTime(dgv_HabitacionesReserva.Rows[0].Cells[2].Value.ToString()) != Convert.ToDateTime(fechaInicio))
                    {
                        found = true;
                        MessageBox.Show("Todas las reservas de habitaciones deben tener las mismas fechas de inicio y fin.");
                        break;
                    }

                    if (dgv_HabitacionesReserva.Rows[0].Cells[9].Value.ToString() != Hab_Hot_Codigo)
                    {
                        found = true;
                        MessageBox.Show("Todas las reservas de habitaciones deben pertenecer al mismo hotel.");
                        break;
                    }
                }
                if (!found)
                { 
                    dgv_HabitacionesReserva.Rows.Add(Reg_Descripcion,  Reg_Codigo,  fechaInicio,  fechaFin,  Hab_Numero,  Hab_Descripcion, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion,  Hab_Hot_Codigo,  Hot_Nombre, precioPorDia,  cantidadNoches,  precioTotalHabitacion);
                    txt_ImporteDia.Text = (Convert.ToDecimal(txt_ImporteDia.Text.ToString()) + Convert.ToDecimal(precioPorDia)).ToString();
                    txt_ImporteTotal.Text = (Convert.ToDecimal(txt_ImporteTotal.Text.ToString()) + Convert.ToDecimal(precioTotalHabitacion)).ToString();
                    txt_CantNoches.Text = (fechaFin1 - fechaInicio1).Days.ToString();
                }
            }
            else
            {
                dgv_HabitacionesReserva.Rows.Add(Reg_Descripcion, Reg_Codigo, fechaInicio, fechaFin, Hab_Numero, Hab_Descripcion, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion, Hab_Hot_Codigo, Hot_Nombre, precioPorDia, cantidadNoches, precioTotalHabitacion);
                txt_ImporteDia.Text = (Convert.ToDecimal(precioPorDia)).ToString();
                txt_ImporteTotal.Text = Convert.ToDecimal(precioTotalHabitacion).ToString();
                txt_CantNoches.Text = cantidadNoches;
            }
        }

        private void btn_BorrarHabitacion_Click(object sender, EventArgs e)
        {
            if (dgv_HabitacionesReserva.CurrentRow != null && dgv_HabitacionesReserva.CurrentRow.Cells[0].Value != null)
            {
                if (Convert.ToDecimal(txt_ImporteTotal.Text) != 0)
                {
                    txt_ImporteDia.Text = (Convert.ToDecimal(txt_ImporteDia.Text) - Convert.ToDecimal(dgv_HabitacionesReserva.CurrentRow.Cells[11].Value.ToString())).ToString();
                    txt_ImporteTotal.Text = (Convert.ToDecimal(txt_ImporteTotal.Text) - Convert.ToDecimal(dgv_HabitacionesReserva.CurrentRow.Cells[13].Value.ToString())).ToString();                    
                }
                dgv_HabitacionesReserva.Rows.RemoveAt(dgv_HabitacionesReserva.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna habitación");
            }
        }

        public List<string> ObtenerHabitacionesAgregadasEnReserva() 
        {
            
            List<string> listaHabitaciones = new List<string>();
            for (int i = 0;i < dgv_HabitacionesReserva.Rows.Count - 1; i++)
            {
                listaHabitaciones.Add(dgv_HabitacionesReserva.Rows[i].Cells[4].Value.ToString());
            }
            return listaHabitaciones;
        }

        public int ObtenerHotelIdReserva()
        {
            string cadena = dgv_HabitacionesReserva.Rows[0].Cells[9].Value.ToString();
            return Convert.ToInt32(cadena);
        }

        public int ObtenerRegimenIdReserva()
        {
            string cadena = dgv_HabitacionesReserva.Rows[0].Cells[1].Value.ToString();
            return Convert.ToInt32(cadena);
        }

        public DateTime ObtenerFechaIngresoReserva()
        {
            return Convert.ToDateTime(dgv_HabitacionesReserva.Rows[0].Cells[2].Value);
        }

        public int ObtenerCantidadNochesReserva() 
        {
            return Convert.ToInt32(txt_CantNoches.Text);
        }

        public decimal ObtenerImportePorDia() 
        {
            return Convert.ToDecimal(txt_ImporteDia.Text);
        }

        public decimal ObtenerImporteTotal()
        {
            return Convert.ToDecimal(txt_ImporteTotal.Text);
        }

        private void cb_Regimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicial == 0)
            {
                inicial = 1;
            }
            else
            {
                if (dgv_HabitacionesReserva.Rows.Count > 1)
                {
                    txt_ImporteDia.Text = "0";
                    txt_ImporteTotal.Text = "0";
                    txt_CantNoches.Text = "0";

                    var listaHabNuevoReg = new List<FrbaHotel.Dominio.Reserva.itemsNuevoReg>();
                    for (int i = 0; i < (dgv_HabitacionesReserva.Rows.Count-1); i++)
                    {
                        int hotelID = Convert.ToInt32(dgv_HabitacionesReserva.Rows[i].Cells[9].Value.ToString());
                        Dominio.ComboBoxItem itemCb_RegimenID = (Dominio.ComboBoxItem)cb_Regimen.SelectedItem;
                        int regimenID = Convert.ToInt32(itemCb_RegimenID.Value.ToString());
                        DateTime fechaIngreso = Convert.ToDateTime(dgv_HabitacionesReserva.Rows[i].Cells[2].Value);
                        DateTime fechaEgreso = Convert.ToDateTime(dgv_HabitacionesReserva.Rows[i].Cells[3].Value);
                        int habNumero = Convert.ToInt32(dgv_HabitacionesReserva.Rows[i].Cells[4].Value);
                        listaHabNuevoReg.Add(new Dominio.Reserva.itemsNuevoReg {hotelID = hotelID, regimenID = regimenID, fechaIngreso = fechaIngreso, fechaEgreso = fechaEgreso, habNumero = habNumero});

                    }
                    dgv_HabitacionesReserva.Rows.Clear();
                    Dominio.Reserva res1 = new Dominio.Reserva();
                    int indice = 0 ;
                    foreach (var item in listaHabNuevoReg)
                    {
                        DataTable dt_HabitacionesConNuevoRegimen = res1.CambiarRegimenEnHabitacionesSeleccionadas(item.hotelID, item.regimenID, item.fechaIngreso, item.fechaEgreso, item.habNumero);
                        CargarDatosHabitaciones(dt_HabitacionesConNuevoRegimen, indice);
                        indice = indice + 1;
                    }

                }

            }
        }

        private void CargarDatosHabitaciones(DataTable dtHabitaciones, int indice)
        {

            dgv_HabitacionesReserva.Rows.Add();
            dgv_HabitacionesReserva.Rows[indice].Cells["Reg_Descripcion"].Value = dtHabitaciones.Rows[0][0].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Reg_Codigo"].Value = dtHabitaciones.Rows[0][1].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["FechaInicio"].Value = Convert.ToDateTime(dtHabitaciones.Rows[0][2].ToString());
            dgv_HabitacionesReserva.Rows[indice].Cells["FechaFin"].Value = Convert.ToDateTime(dtHabitaciones.Rows[0][3].ToString());
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Numero"].Value = dtHabitaciones.Rows[0][4].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Descripcion"].Value = dtHabitaciones.Rows[0][8].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Piso"].Value = dtHabitaciones.Rows[0][6].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Ubicacion"].Value = dtHabitaciones.Rows[0][7].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Tipo_Habitacion"].Value = dtHabitaciones.Rows[0][5].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hab_Hot_Codigo"].Value = dtHabitaciones.Rows[0][9].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Hot_Nombre"].Value = dtHabitaciones.Rows[0][10].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["Precio_por_dia"].Value = dtHabitaciones.Rows[0][11].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["cantNoches"].Value = dtHabitaciones.Rows[0][12].ToString();
            dgv_HabitacionesReserva.Rows[indice].Cells["PrecioTotalHab"].Value = dtHabitaciones.Rows[0][13].ToString();

            txt_ImporteDia.Text = (Convert.ToDecimal(txt_ImporteDia.Text.ToString()) + Convert.ToDecimal(dtHabitaciones.Rows[0][11].ToString())).ToString();
            txt_ImporteTotal.Text = (Convert.ToDecimal(txt_ImporteTotal.Text.ToString()) + Convert.ToDecimal(dtHabitaciones.Rows[0][13].ToString())).ToString();
            txt_CantNoches.Text = dtHabitaciones.Rows[0][12].ToString();
        }

        private void btn_RegHotel_Click(object sender, EventArgs e)
        {

            Dominio.ComboBoxItem itemCb_HotelID = (Dominio.ComboBoxItem)cb_Hotel.SelectedItem;
            int HotelIDSeleccionado = Convert.ToInt32(itemCb_HotelID.Value.ToString());
            Reserva_Regimenes resReg = Reserva_Regimenes.ObtenerInstancia();
            resReg.CargarGrid(HotelIDSeleccionado);
            resReg.Show();
        }
    }

}

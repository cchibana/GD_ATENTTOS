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
    public partial class Reserva_ClienteBusqueda : Form
    {
        private static Reserva_ClienteBusqueda _instancia;

        public static Reserva_ClienteBusqueda ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_ClienteBusqueda();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_ClienteBusqueda()
        {
            InitializeComponent();
            InicializarComboBoxTipoDocumento();
        }

        private void InicializarComboBoxTipoDocumento()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            DataTable dt_TipoDoc = usu1.ListarTodosLosTiposDocumentos();
            for (int i = 0; i < dt_TipoDoc.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_TipoDoc.Rows[i][0].ToString();
                item.Value = dt_TipoDoc.Rows[i][0].ToString();

                cb_tipoIdentificacionCliente.Items.Add(item);
            }
            cb_tipoIdentificacionCliente.SelectedIndex = 0;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            resGen.Show();
            this.Close();
        }

        private void btn_AltaNuevoCliente_Click(object sender, EventArgs e)
        {
            Reserva_ClienteNuevo resCliNuevo = Reserva_ClienteNuevo.ObtenerInstancia();
            resCliNuevo.Show();
            this.Hide();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {

        }


        private void KeyPressAlfa(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorAlfa(e.KeyChar);
        }

        private void KeyPressNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorNumerico(e.KeyChar);
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            if (txt_Mail.Text != null && txt_NroIdentificacion != null)
            {
                Dominio.Reserva res1 = new Dominio.Reserva();
                DataTable dt = res1.BuscarCliente(cb_tipoIdentificacionCliente.SelectedItem.ToString(), txt_NroIdentificacion.Text, txt_Mail.Text);

                dgv_ClienteReserva.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos de búsqueda");
            }
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (dgv_ClienteReserva.CurrentRow != null && dgv_ClienteReserva.CurrentRow.Cells[0].Value != null)
            {

                Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
                Dominio.Reserva res1 = new Dominio.Reserva();
                int nroReserva = res1.ObtenerSiguienteNumeroDeReserva();
                int hotelID = resGen.ObtenerHotelIdReserva();
                int clienteID = Convert.ToInt32(dgv_ClienteReserva.CurrentRow.Cells[0].Value.ToString());
                DateTime fechaIngreso = resGen.ObtenerFechaIngresoReserva();
                int cantidadNoches = resGen.ObtenerCantidadNochesReserva();
                int regimenID = resGen.ObtenerRegimenIdReserva();
                decimal costoPorDia = resGen.ObtenerImportePorDia();
                decimal costoTotal = resGen.ObtenerImporteTotal();
                string usuario = Dominio.UsuarioLogin.TheInstance.getUsuario();
                if (usuario == null)
                {
                    usuario = "guest";
                }

                if (res1.RegistrarReservaTablaReservas(nroReserva,hotelID,clienteID,fechaIngreso,cantidadNoches,regimenID,costoPorDia,costoTotal,usuario))
                {
                    if (RegistrarEnTablaHabitacionesPorReservas(nroReserva, hotelID))
                    {
                        if (res1.RegistrarEnTablaLogRegistros(nroReserva, usuario, 'G', "Nueva Reserva"))
                        {
                            MessageBox.Show("La reserva ha sido exitosa. Su número de reserva es: " + nroReserva);
                            resGen.LimpiarCampos();
                            resGen.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar la reserva en la tabla Log");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar las habitaciones de la reserva.");
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar la reserva.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algún cliente");
            }
        }

        private bool RegistrarEnTablaHabitacionesPorReservas(int nroReserva, int hotelID)
        {

            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            Dominio.Reserva res1 = new Dominio.Reserva();
            List<string> listaHabitacionesAReservar = resGen.ObtenerHabitacionesAgregadasEnReserva();
            if (listaHabitacionesAReservar != null)
            {
                foreach (var nroHabitacion in listaHabitacionesAReservar)
                {
                    if (!res1.RegistrarReservaTablaHabitacionesPorReservas(nroReserva.ToString(), hotelID.ToString(), nroHabitacion))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

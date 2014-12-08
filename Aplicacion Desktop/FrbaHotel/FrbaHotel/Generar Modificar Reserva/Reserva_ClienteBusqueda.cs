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


        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preguntar por si quiere confirmar la reserva. si dice si, se registra y se muestra el número de reserva. Sino, vuelve a la pantalla anterior.");
            this.Close();
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
    }
}

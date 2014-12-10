using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class Habitacion_Modificacion : Form
    {

        private static Habitacion_Modificacion _instancia;

        private long? Hab_NumeroBD;

        public static Habitacion_Modificacion ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Habitacion_Modificacion();
            }
            _instancia.BringToFront();
            return _instancia;
        }


        public Habitacion_Modificacion()
        {
            InitializeComponent();
            InicializarCBoxEstadoHab();

            int idHotel = Dominio.UsuarioLogin.TheInstance.getHotel();
            txt_hotel.Text = idHotel.ToString();

        }

        private void InicializarCBoxEstadoHab()
        {
            Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
            item.Text = "Disponible";
            item.Value = "True";
            cbox_estado.Items.Add(item);
        }

        private void CambiarUbicacion (object sender, EventArgs e)
        {
            txt_ubicacion.Text = cbox_ubicacion.SelectedItem.ToString();
        }

        private void CambiarEstado(object sender, EventArgs e)
        {
            txt_estado.Text = cbox_estado.SelectedItem.ToString();
        }


        private void Habitacion_Modificacion_Load(object sender, EventArgs e)
        {
            Dominio.Habitacion ubicacion1 = new Dominio.Habitacion();
            DataTable ubicacion = ubicacion1.ListarUbicaciones();

            for (int i = 0; i < ubicacion.Rows.Count; i++)
            {
                cbox_ubicacion.Items.Add(ubicacion.Rows[i][0]);
            }

            Hab_NumeroBD = Convert.ToInt64(txt_numero.Text);
        }

        private void LlenarDescHab(object sender, EventArgs e)
        {
            Dominio.Habitacion descHab1 = new Dominio.Habitacion();
            string tipoHab = txt_tipohab.Text;

            DataTable dt_descHab = descHab1.RecuperaDescripHab(tipoHab);
            txt_descripcion.Text = dt_descHab.Rows[0][0].ToString();
        }

        private void LlenarPorcentualHab(object sender, EventArgs e)
        {
            Dominio.Habitacion porcentHab1 = new Dominio.Habitacion();
            string porcentHab = txt_tipohab.Text;

            DataTable dt_porcentHab = porcentHab1.RecuperaPorcentualHab(porcentHab);
            txt_porcentual.Text = dt_porcentHab.Rows[0][0].ToString();
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_numero.Text) ||
                string.IsNullOrEmpty(this.txt_piso.Text) ||
                string.IsNullOrEmpty(this.txt_ubicacion.Text) ||
                string.IsNullOrEmpty(this.txt_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                bool estadoModificaciones = true;
                Dominio.Habitacion hab1 = new Dominio.Habitacion();

                if (estadoModificaciones)
                {
                    if (this.Hab_NumeroBD != Convert.ToInt64(txt_numero.Text))
                    {
                        if (!hab1.verificarNroHAbitacionValido(txt_numero.Text))
                        {
                            MessageBox.Show("Ya existe una Habitación con el número ingresado");
                            estadoModificaciones = false;
                        }
                    }
                }

                if (estadoModificaciones)
                {
                    if (!hab1.ModificarDatosHabitaciones(txt_hotel.Text, txt_numero.Text, txt_piso.Text, txt_ubicacion.Text, txt_estado.Text))
                    {
                        MessageBox.Show("Error en la modificación de datos de la habitación");
                        estadoModificaciones = false;
                    }
                }

                if (estadoModificaciones)
                {
                    MessageBox.Show("Se han guardado los cambios correctamente");
                    this.Hide();
                    this.Close();
                }
            }

        }
    }
}

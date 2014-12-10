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
    public partial class Habitacion_Alta : Form
    {

        public Habitacion_Alta()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
        }

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            txt_porcentual.Text = "";
            cbox_ubicacion.SelectedItem = null;
            cbox_tipo_hab.SelectedItem = 0;
            cbox_estado.SelectedItem = null;
        }

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Disponible";
            item0.Value = "1";
            cbox_estado.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "No Disponible";
            item1.Value = "0";
            cbox_estado.Items.Add(item1);
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

        private void Habitacion_Alta_Load(object sender, EventArgs e)
        {
            Dominio.Habitacion ubicacion1 = new Dominio.Habitacion();
            DataTable ubicacion = ubicacion1.ListarUbicaciones();

            for (int i = 0; i < ubicacion.Rows.Count; i++)
            {
                cbox_ubicacion.Items.Add(ubicacion.Rows[i][0]);
            }

            Dominio.Habitacion tipoHab1 = new Dominio.Habitacion();
            DataTable tipoHab = tipoHab1.ListarTiposHab();

            for (int i = 0; i < tipoHab.Rows.Count; i++)
            {
                cbox_tipo_hab.Items.Add(tipoHab.Rows[i][0]);
            }

            int idHotel = Dominio.UsuarioLogin.TheInstance.getHotel();
            txt_hotel.Text = idHotel.ToString();
            
        }


        private void LlenarDescHab(object sender, EventArgs e)
        {
            Dominio.Habitacion descHab1 = new Dominio.Habitacion();
            string tipoHab = cbox_tipo_hab.SelectedItem.ToString();

            DataTable dt_descHab = descHab1.RecuperaDescripHab(tipoHab);
            txt_descripcion.Text = dt_descHab.Rows[0][0].ToString();
        }

        private void LlenarPorcentualHab(object sender, EventArgs e)
        {
            Dominio.Habitacion porcentHab1 = new Dominio.Habitacion();
            string porcentHab = cbox_tipo_hab.SelectedItem.ToString();

            DataTable dt_porcentHab = porcentHab1.RecuperaPorcentualHab(porcentHab);
            txt_porcentual.Text = dt_porcentHab.Rows[0][0].ToString();
        }

        
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Dominio.Habitacion hab1 = new Dominio.Habitacion();
                if (hab1.verificarNroHAbitacionValido(txt_numero.Text))
                {
                    if (hab1.InsertarDatosEnTablaHabitaciones(txt_hotel.Text, txt_numero.Text, txt_piso.Text, cbox_ubicacion.SelectedItem.ToString(), cbox_tipo_hab.SelectedItem.ToString(), txt_descripcion.Text, cbox_estado.SelectedItem.ToString()))
                    {
                        DialogResult Result;
                        Result = MessageBox.Show("Alta de Habitación Exitosa. Desea Ingresar otra?", " ", MessageBoxButtons.OKCancel);

                        if (Result != DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido dar de alta la nueva Habitación");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una habitación con el número ingresado");
                }                
            }         
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_numero.Text) ||
                string.IsNullOrEmpty(this.txt_piso.Text) ||
                string.IsNullOrEmpty(this.cbox_ubicacion.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.cbox_tipo_hab.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.txt_descripcion.Text) ||
                string.IsNullOrEmpty(this.cbox_estado.SelectedItem.ToString()))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }

    }
}

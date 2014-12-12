using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class Hotel_Modificacion : Form
    {

        private string Hot_calleBD;
        private long? Hot_NumeroBD;

        public Hotel_Modificacion()
        {
            InitializeComponent();
            InicializarComboBoxEstrellas();
            InicializarComboBoxEstado();
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

        private void InicializarComboBoxEstrellas()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "1";
            item1.Value = "1";
            cbox_estrellas.Items.Add(item1);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "2";
            item2.Value = "2";
            cbox_estrellas.Items.Add(item2);

            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "3";
            item3.Value = "3";
            cbox_estrellas.Items.Add(item3);

            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "4";
            item4.Value = "4";
            cbox_estrellas.Items.Add(item4);

            Dominio.ComboBoxItem item5 = new Dominio.ComboBoxItem();
            item5.Text = "5";
            item5.Value = "5";
            cbox_estrellas.Items.Add(item5);

            cbox_estrellas.SelectedIndex = 0;
        }

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Habilitado";
            item0.Value = "1";
            cbox_estado.Items.Add(item0);
        }

        private void Hotel_Modificacion_Load(object sender, EventArgs e)
        {
            Dominio.Hotel pais1 = new Dominio.Hotel();
            DataTable pais = pais1.ListarPaises();

            for (int i = 0; i < pais.Rows.Count; i++)
            {
                cbox_pais.Items.Add(pais.Rows[i][0]);
            }

            Dominio.Hotel ciudad1 = new Dominio.Hotel();
            DataTable ciudad = ciudad1.ListarCiudades();

            for (int i = 0; i < ciudad.Rows.Count; i++)
            {
                cbox_ciudad.Items.Add(ciudad.Rows[i][0]);
            }

            Hot_calleBD = txt_calle.Text;
            Hot_NumeroBD = Convert.ToInt64(txt_numero.Text);
        } 

        private void CambiarEstrellas(object sender, EventArgs e)
        {
            txt_estrellas.Text = cbox_estrellas.SelectedItem.ToString();
        }

        private void CambiarEstado(object sender, EventArgs e)
        {
            txt_estado.Text = cbox_estado.SelectedItem.ToString();
        }

        private void CambiarPais(object sender, EventArgs e)
        {
            txt_pais.Text = cbox_pais.SelectedItem.ToString();
        }

        private void CambiarCiudad(object sender, EventArgs e)
        {
            txt_ciudad.Text = cbox_ciudad.SelectedItem.ToString();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_nombre.Text) ||
                string.IsNullOrEmpty(this.txt_mail.Text) ||
                string.IsNullOrEmpty(this.txt_telefono.Text) ||
                string.IsNullOrEmpty(this.txt_calle.Text) ||
                string.IsNullOrEmpty(this.txt_numero.Text) ||
                string.IsNullOrEmpty(this.txt_ciudad.Text) ||
                string.IsNullOrEmpty(this.txt_pais.Text) ||
                string.IsNullOrEmpty(this.date_creacion.Value.ToString()) ||
                string.IsNullOrEmpty(this.txt_estrellas.Text) ||
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
                Dominio.Hotel hot1 = new Dominio.Hotel();

                if (estadoModificaciones)
                {                
                    Dominio.Hotel ciudadId1 = new Dominio.Hotel();
                    DataTable dt_ciudadId = ciudadId1.RecuperaIdCiudad(txt_ciudad.Text);
                    string ciudadId = dt_ciudadId.Rows[0][0].ToString();

                    if (!hot1.ModificarDatosHoteles(txt_nombre.Text, txt_mail.Text, txt_telefono.Text, txt_calle.Text, txt_numero.Text, ciudadId, txt_pais.Text, txt_estrellas.Text, date_creacion.Value.ToString("yyyy-MM-dd"), txt_estado.Text))
                    {
                        MessageBox.Show("Error en la modificación de datos del hotel");
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

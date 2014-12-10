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
    public partial class Hotel_Alta : Form
    {
        public Hotel_Alta()
        {
            InitializeComponent();
            InicializarComboBoxRegimen();
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

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            cbox_estrellas.SelectedItem = null;
            date_creacion.Value = DateTime.Now;
            cbox_estado.SelectedItem = null;
        }

        private void InicializarComboBoxEstrellas()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "1";
            item0.Value = "1";
            cbox_estado.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "2";
            item1.Value = "2";
            cbox_estado.Items.Add(item1);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "3";
            item2.Value = "3";
            cbox_estado.Items.Add(item2);

            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "4";
            item3.Value = "4";
            cbox_estado.Items.Add(item3);

            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "5";
            item4.Value = "5";
            cbox_estado.Items.Add(item4);            
        }


        private void InicializarComboBoxRegimen()
        {
            Dominio.Hotel hot1 = new Dominio.Hotel();
            DataTable dt_Regimen = hot1.ListarRegimenes();
            for (int i = 0; i < dt_Regimen.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_Regimen.Rows[i][0].ToString();
                item.Value = dt_Regimen.Rows[i][0].ToString();

                cbox_regimen.Items.Add(item);
            }
            cbox_regimen.SelectedIndex = 0;
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


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_nombre.Text) ||
                string.IsNullOrEmpty(this.txt_mail.Text) ||
                string.IsNullOrEmpty(this.txt_telefono.Text) ||
                string.IsNullOrEmpty(this.txt_calle.Text) ||
                string.IsNullOrEmpty(this.txt_numero.Text) ||
                string.IsNullOrEmpty(this.txt_ciudad.Text) ||
                string.IsNullOrEmpty(this.txt_pais.Text) ||
                string.IsNullOrEmpty(this.cbox_estrellas.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.date_creacion.Value.ToString()) ||
                string.IsNullOrEmpty(this.cbox_regimen.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.cbox_estado.SelectedItem.ToString()))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }
        

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Dominio.Hotel hot1 = new Dominio.Hotel();

                if (hot1.verificarCalleYNumeroValido(txt_calle.Text, txt_numero.Text))
                {
                    if (hot1.InsertarDatosEnTablaHoteles(txt_nombre.Text, txt_mail.Text, txt_telefono.Text, txt_calle.Text, txt_numero.Text, txt_ciudad.Text, txt_pais.Text, cbox_estrellas.SelectedItem.ToString(), date_creacion.Value.ToString("yyyy-MM-dd"), cbox_regimen.SelectedItem.ToString(), cbox_estado.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Alta de Hotel Exitosa");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido dar de alta al nuevo Hotel");
                    }

                }
                else
                {
                    MessageBox.Show("Ya existe un hotel en ese domicilio");
                }
            }
        }


    }
}

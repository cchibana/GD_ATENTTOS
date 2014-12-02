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
            chkBox_all_incl.Checked = false;
            chkBox_desayuno.Checked = false;
            chkBox_media_pens.Checked = false;
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}

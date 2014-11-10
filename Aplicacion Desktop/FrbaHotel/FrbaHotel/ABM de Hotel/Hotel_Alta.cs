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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            cbox_estrellas.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            cbox_estado.SelectedItem = "Habilitado";
        }

         private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

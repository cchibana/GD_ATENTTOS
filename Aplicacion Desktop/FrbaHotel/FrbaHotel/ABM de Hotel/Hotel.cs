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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_estrellas_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel_Alta hotel_Alta = new FrbaHotel.ABM_de_Hotel.Hotel_Alta();
            hotel_Alta.Show(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel_Modificacion hotel_modificacion = new FrbaHotel.ABM_de_Hotel.Hotel_Modificacion();
            hotel_modificacion.Show(this);
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel_Baja hotel_Baja = new FrbaHotel.ABM_de_Hotel.Hotel_Baja();
            hotel_Baja.Show(this);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            cbox_estrellas.SelectedItem = null;
          
        }

        private void cbox_estrellas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

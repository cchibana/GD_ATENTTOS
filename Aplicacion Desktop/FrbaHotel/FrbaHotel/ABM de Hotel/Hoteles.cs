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
    public partial class Hoteles : Form
    {
        Dominio.Hotel hotel1 = new Dominio.Hotel();


        public Hoteles()
        {
            InitializeComponent();
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

 
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Se usa el metodo Listar de hotel y mostrandolo en el DataGridView
            dgv_hoteles.DataSource = hotel1.Listar();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificacion.Enabled = true;
            btn_baja.Enabled = true;
        }

 
    }
}

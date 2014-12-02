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

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            cbox_estrellas.SelectedItem = null;
        }

        public void KeyPressAlfa(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorAlfa(e.KeyChar);
        }

        public void KeyPressNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorNumerico(e.KeyChar);
        }


        private void btn_alta_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel_Alta hotel_Alta = new FrbaHotel.ABM_de_Hotel.Hotel_Alta();
            hotel_Alta.Show(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
         {
             ABM_de_Hotel.Hotel_Modificacion hotel_modificacion = new FrbaHotel.ABM_de_Hotel.Hotel_Modificacion();

             hotel_modificacion.txt_nombre.Text = dgv_hoteles.CurrentRow.Cells[0].Value.ToString();
             hotel_modificacion.txt_mail.Text = dgv_hoteles.CurrentRow.Cells[1].Value.ToString();
             hotel_modificacion.txt_telefono.Text = dgv_hoteles.CurrentRow.Cells[2].Value.ToString();
             hotel_modificacion.txt_calle.Text = dgv_hoteles.CurrentRow.Cells[3].Value.ToString();
             hotel_modificacion.txt_numero.Text = dgv_hoteles.CurrentRow.Cells[4].Value.ToString();
             hotel_modificacion.txt_ciudad.Text = dgv_hoteles.CurrentRow.Cells[5].Value.ToString();
             hotel_modificacion.txt_pais.Text = dgv_hoteles.CurrentRow.Cells[6].Value.ToString();
             hotel_modificacion.cbox_estrellas.Items.Add(dgv_hoteles.CurrentRow.Cells[7].Value.ToString());
             hotel_modificacion.date_creacion.Text = dgv_hoteles.CurrentRow.Cells[8].Value.ToString();
             hotel_modificacion.cbox_estado.Items.Add(dgv_hoteles.CurrentRow.Cells[9].Value.ToString());
            
             hotel_modificacion.Show();
         }


        private void btn_baja_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel_Baja hotel_Baja = new FrbaHotel.ABM_de_Hotel.Hotel_Baja();
           
            hotel_Baja.txt_nombre.Text = dgv_hoteles.CurrentRow.Cells[0].Value.ToString();
            hotel_Baja.txt_mail.Text = dgv_hoteles.CurrentRow.Cells[1].Value.ToString();
            hotel_Baja.txt_telefono.Text = dgv_hoteles.CurrentRow.Cells[2].Value.ToString();
            hotel_Baja.txt_calle.Text = dgv_hoteles.CurrentRow.Cells[3].Value.ToString();
            hotel_Baja.txt_numero.Text = dgv_hoteles.CurrentRow.Cells[4].Value.ToString();
            hotel_Baja.txt_ciudad.Text = dgv_hoteles.CurrentRow.Cells[5].Value.ToString();
            hotel_Baja.txt_pais.Text = dgv_hoteles.CurrentRow.Cells[6].Value.ToString();
            hotel_Baja.cbox_estrellas.Items.Add(dgv_hoteles.CurrentRow.Cells[7].Value.ToString());
            hotel_Baja.date_creacion.Text = dgv_hoteles.CurrentRow.Cells[8].Value.ToString();
            hotel_Baja.cbox_estado.Items.Add(dgv_hoteles.CurrentRow.Cells[9].Value.ToString());
    
            hotel_Baja.Show();

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

 
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgv_hoteles.DataSource = hotel1.Listar();

            if (dgv_hoteles.RowCount == 0)
            {
                DialogResult Result;
                Result = MessageBox.Show("No se encontró el Hotel. Desea darlo de alta?", " ", MessageBoxButtons.OKCancel);

                if (Result == DialogResult.OK)
                {
                    ABM_de_Hotel.Hotel_Alta hab_Alta = new FrbaHotel.ABM_de_Hotel.Hotel_Alta();
                    hab_Alta.Show(this);
                }
                else
                {
                    return;
                }
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificacion.Enabled = true;
            btn_baja.Enabled = true;
        }

 
    }
}

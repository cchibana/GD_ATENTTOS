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
            InicializarComboBoxEstado();
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

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cbox_estrellas.Items.Add(item0);

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
            Dominio.Hotel hotel1 = new Dominio.Hotel();

            try
            {
                Dominio.ComboBoxItem itemCbox_estrellas = (Dominio.ComboBoxItem)cbox_estrellas.SelectedItem;

                if (itemCbox_estrellas.Value == null)
                {
                    itemCbox_estrellas.Value = "";
                }

                DataTable dt = hotel1.BuscarHoteles(txt_nombre.Text, txt_ciudad.Text, txt_pais.Text, itemCbox_estrellas.Value.ToString());

                if (dt.Rows.Count == 0)
                {
                    DialogResult Result;
                    Result = MessageBox.Show("No se encontró el hotel. Desea darlo de alta?", " ", MessageBoxButtons.OKCancel);

                    if (Result == DialogResult.OK)
                    {
                        ABM_de_Hotel.Hotel_Alta hotel_Alta = new FrbaHotel.ABM_de_Hotel.Hotel_Alta();
                        hotel_Alta.Show(this);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    dgv_hoteles.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar la búsqueda");
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificacion.Enabled = true;
            btn_baja.Enabled = true;
        }

 
    }
}

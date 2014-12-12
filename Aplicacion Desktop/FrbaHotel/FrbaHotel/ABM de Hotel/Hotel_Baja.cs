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
    public partial class Hotel_Baja : Form
    {
        public Hotel_Baja()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
            btn_guardar.Enabled = false;
        }
        
        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Inhabilitado";
            item0.Value = "0";
            cbox_estado.Items.Add(item0);
        }

        private void CambiarEstado(object sender, EventArgs e)
        {
            if (txt_estado.Text != cbox_estado.SelectedItem.ToString())
            {
                txt_estado.Text = cbox_estado.SelectedItem.ToString();
                btn_guardar.Enabled = true;
            }           
        }
        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Dominio.Hotel hot1 = new Dominio.Hotel();

            if (hot1.CambiarEstadoHotel(txt_calle.Text, txt_numero.Text, 0))
            {
                MessageBox.Show("Se ha dado de baja el Hotel: " + txt_nombre.Text);
            }
            else
            {
                MessageBox.Show("Error al dar de baja el hotel");
            }
            this.Hide();
            this.Close(); 
        } 
    }
}

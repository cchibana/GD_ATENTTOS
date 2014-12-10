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
    public partial class Habitacion_Baja : Form
    {
        public Habitacion_Baja()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
            btn_guardar.Enabled = false;

            int idHotel = Dominio.UsuarioLogin.TheInstance.getHotel();
            txt_hotel.Text = idHotel.ToString();
        }

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "No Disponible";
            item1.Value = "0";
            cbox_estado.Items.Add(item1);
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
            Dominio.Habitacion hab1 = new Dominio.Habitacion();

            if (hab1.CambiarEstadoHabitacion(txt_hotel.Text, txt_numero.Text, 0))
            {
                MessageBox.Show("Se ha dado de baja la Habitación nro." + txt_numero.Text);
            }
            else
            {
                MessageBox.Show("Error al dar de baja la habitación");
            }
            this.Hide();
            this.Close();    
        }


    }
}

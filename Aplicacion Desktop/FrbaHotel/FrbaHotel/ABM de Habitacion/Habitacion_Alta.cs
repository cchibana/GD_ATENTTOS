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
    public partial class Habitacion_Alta : Form
    {
        public Habitacion_Alta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            cbox_ubicacion.SelectedItem = null;
            cbox_tipo_hab.SelectedItem = null;
            cbox_estado.SelectedItem = "Libre";
        }
    }
}

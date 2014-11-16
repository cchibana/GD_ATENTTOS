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
    public partial class Habitaciones : Form
    {
        Dominio.Habitacion habitacion1 = new Dominio.Habitacion();

        public Habitaciones()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Alta hab_Alta = new FrbaHotel.ABM_de_Habitacion.Habitacion_Alta();
            hab_Alta.Show(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Modificacion hab_Modificacion = new FrbaHotel.ABM_de_Habitacion.Habitacion_Modificacion();
            hab_Modificacion.Show(this);
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Baja hab_Baja = new FrbaHotel.ABM_de_Habitacion.Habitacion_Baja();
            hab_Baja.Show(this);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            cbox_tipo_hab.SelectedItem = null;
            cbox_ubicacion.SelectedItem = null;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Se usa el metodo Listar de hotel y mostrandolo en el DataGridView
            dgv_habitacion.DataSource = habitacion1.Listar();
        }
    }
}

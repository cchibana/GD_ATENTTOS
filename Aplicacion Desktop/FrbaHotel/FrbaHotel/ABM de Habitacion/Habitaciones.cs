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

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            cbox_tipo_hab.SelectedItem = null;
            cbox_ubicacion.SelectedItem = null;
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


        private void btn_alta_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Alta hab_Alta = new FrbaHotel.ABM_de_Habitacion.Habitacion_Alta();
            hab_Alta.Show(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Modificacion hab_Modificacion = new FrbaHotel.ABM_de_Habitacion.Habitacion_Modificacion();

            //se pasan los datos de la fila seleccionada a la pantalla de modificación
            hab_Modificacion.txt_numero.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            hab_Modificacion.txt_piso.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            hab_Modificacion.cbox_ubicacion.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();
            hab_Modificacion.cbox_tipo_hab.Text = dgv_habitacion.CurrentRow.Cells[3].Value.ToString();
            hab_Modificacion.txt_descripcion.Text = dgv_habitacion.CurrentRow.Cells[4].Value.ToString();
         
            hab_Modificacion.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Baja hab_Baja = new FrbaHotel.ABM_de_Habitacion.Habitacion_Baja();

            //se pasan los datos de la fila seleccionada a la pantalla de baja
            hab_Baja.txt_numero.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            hab_Baja.txt_piso.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            hab_Baja.cbox_ubicacion.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();
            hab_Baja.cbox_tipo_hab.Text = dgv_habitacion.CurrentRow.Cells[3].Value.ToString();
            hab_Baja.txt_descripcion.Text = dgv_habitacion.CurrentRow.Cells[4].Value.ToString();
            hab_Baja.cbox_estado.Text = dgv_habitacion.CurrentRow.Cells[5].Value.ToString();

            hab_Baja.Show();
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
         
            dgv_habitacion.DataSource = habitacion1.Listar();

            if (dgv_habitacion.RowCount == 0)
            {
                DialogResult Result;
                Result = MessageBox.Show("No se encontró la habitación. Desea darlo de alta?", " ", MessageBoxButtons.OKCancel);

                if (Result == DialogResult.OK)
                {
                    ABM_de_Habitacion.Habitacion_Alta hab_Alta = new FrbaHotel.ABM_de_Habitacion.Habitacion_Alta();
                    hab_Alta.Show(this);
                }
                else
                {
                    return;
                }                
            }            
        }

        private void dgv_habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificacion.Enabled = true;
            btn_baja.Enabled = true;
        }
    }
}

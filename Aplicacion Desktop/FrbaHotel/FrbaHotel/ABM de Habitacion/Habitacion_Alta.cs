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
        Dominio.Habitacion hab1 = new Dominio.Habitacion();

        public Habitacion_Alta()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            cbox_ubicacion.SelectedItem = null;
            cbox_tipo_hab.SelectedItem = null;
            cbox_estado.SelectedItem = null;
        }

        public bool LlenarObjeto()
        {
            try
            {
                hab1.Numero = int.Parse(txt_numero.Text);
                hab1.Piso = int.Parse(txt_piso.Text);
                hab1.Ubicacion = cbox_ubicacion.Text;
                hab1.Tipo = int.Parse(cbox_tipo_hab.Text);
                hab1.Descripcion = txt_descripcion.Text;
                hab1.Estado = int.Parse(cbox_estado.Text);

                return true;
            }
            catch
            {
                return false;
            }
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


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*if (LlenarObjeto())
            {
                MessageBox.Show(hab1.Insertar());                                
            }
            else
            {
                //Mensaje en caso de error al llenar el objeto
                MessageBox.Show("Error al llenar los datos...");
            }*/
        }

    }
}

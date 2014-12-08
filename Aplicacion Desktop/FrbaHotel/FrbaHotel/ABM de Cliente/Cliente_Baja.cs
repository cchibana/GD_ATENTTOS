using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class Cliente_Baja : Form
    {
        public Cliente_Baja()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
            btn_guardar.Enabled = false;
        }

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Inhabilitado";
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
            Dominio.Cliente cli1 = new Dominio.Cliente();

            if (cli1.CambiarEstadoCliente(txt_tipodoc.Text, txt_nro_doc.Text, 0))
            {
                MessageBox.Show("Se ha dado de baja al Cliente " + txt_nombre.Text);
            }
            else
            {
                MessageBox.Show("Error al dar de baja al Cliente");
            }
            this.Hide();
            this.Close();                                  
        }


    }
}

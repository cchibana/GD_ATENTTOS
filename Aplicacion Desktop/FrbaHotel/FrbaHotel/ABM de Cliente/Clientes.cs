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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_mail.Text = "";
            txt_nro_doc.Text = "";
            cbox_tipo_doc.SelectedItem = null;            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Apellido_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBox_tipo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tipo_Doc_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gBox_filtros_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Alta cliente_Alta = new FrbaHotel.ABM_de_Cliente.Cliente_Alta();
            cliente_Alta.Show(this);
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Modificacion cliente_Modificacion = new FrbaHotel.ABM_de_Cliente.Cliente_Modificacion();
            cliente_Modificacion.Show(this);
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Baja cliente_Baja = new FrbaHotel.ABM_de_Cliente.Cliente_Baja();
            cliente_Baja.Show(this);
        }


       /* private void txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
        }*/

    }
}

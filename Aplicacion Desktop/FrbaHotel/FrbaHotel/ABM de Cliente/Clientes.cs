using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace FrbaHotel.ABM_de_Cliente
{
    public partial class Clientes : Form
    {
        Dominio.Cliente cliente1 = new Dominio.Cliente();
            
        public Clientes()
        {
            InitializeComponent();
        }

        /* (Código Nuevo: Llenar el objeto con datos, este metodo hace que los de los controles pasen al objeto*/
        public bool LlenarObjeto()
        {
            try
            {
                try { cliente1.Nombre = txt_nombre.Text; }
                catch { cliente1.Nombre = null; }
                cliente1.Nombre = txt_nombre.Text;
                cliente1.Apellido = txt_apellido.Text;

                return true;//Devuelve verdadero cuando los datos son correctos
            }
            catch
            {
                return false;//Devuelve falso cuando los datos NO son correctos
            }
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
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


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Usando el metodo Listar de oProducto y mostrandolo en el DataGridView
            dgv1.DataSource = cliente1.Listar();
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

        private void cbox_tipo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
          
      
            
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

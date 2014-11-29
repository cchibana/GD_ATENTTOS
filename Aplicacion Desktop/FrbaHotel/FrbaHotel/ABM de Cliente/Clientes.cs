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
            //Se usa el metodo Listar de cliente y mostrandolo en el DataGridView
            //*gs- ver como aplicar los filtros de busqueda   
            
            try
            {
                dgv_clientes.DataSource = cliente1.Listar();                
            }
            catch
            {
                MessageBox.Show("No se encontró el registro. Desea darlo de alta?");
            }
                           
        }


        
        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Alta cliente_Alta = new FrbaHotel.ABM_de_Cliente.Cliente_Alta();
            cliente_Alta.Show(this);
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Modificacion cliente_Modificacion = new FrbaHotel.ABM_de_Cliente.Cliente_Modificacion();
            
            //se pasan los datos de la fila seleccionada a la pantalla de modificación
            cliente_Modificacion.txt_nombre.Text = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            cliente_Modificacion.txt_apellido.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            cliente_Modificacion.txt_nacionalidad.Text = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            cliente_Modificacion.date_nacimiento.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            cliente_Modificacion.txt_mail.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
                        
            cliente_Modificacion.Show();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Cliente_Baja cliente_Baja = new FrbaHotel.ABM_de_Cliente.Cliente_Baja();

            //se pasan los datos de la fila seleccionada a la pantalla de baja
            cliente_Baja.txt_nombre.Text = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            cliente_Baja.txt_apellido.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            cliente_Baja.txt_nacionalidad.Text = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            cliente_Baja.date_nacimiento.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            cliente_Baja.txt_mail.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
            
            cliente_Baja.Show();
        }

  

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Modificacion.Enabled = true;
            btn_Baja.Enabled = true;
        }
    }
}

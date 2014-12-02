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

        /* Llenar el objeto con datos, este metodo hace que los de los controles pasen al objeto*/
        public bool LlenarObjeto()
        {
            try
            {
                try { cliente1.Nombre = txt_nombre.Text; }
                catch { cliente1.Nombre = null; }
                cliente1.Nombre = txt_nombre.Text;
                cliente1.Apellido = txt_apellido.Text;

                return true;
            }
            catch
            {
                return false;
            }
        }
        

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_mail.Text = "";
            txt_nro_doc.Text = "";
            cbox_tipodoc.SelectedItem = null;
        }

        public void KeyPressAlfa(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorAlfa(e.KeyChar);
        }

        public void KeyPressNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorNumerico(e.KeyChar);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Dominio.Cliente tipoDoc1 = new Dominio.Cliente();
            DataTable tipoDoc = tipoDoc1.ListarTipoDoc();

            for (int i = 0; i < tipoDoc.Rows.Count; i++)
            {
                cbox_tipodoc.Items.Add(tipoDoc.Rows[i][0]);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nombreCli = txt_nombre.Text;
            string apellidoCli = txt_apellido.Text;
            string mailCli = txt_mail.Text;
            string tipoDocCli = cbox_tipodoc.Text;

            Dominio.Cliente cliente  = new Dominio.Cliente();
            DataTable dt = cliente.ConsultaClientes(nombreCli, apellidoCli, mailCli, tipoDocCli);
            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas > 0)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    dgv_clientes.DataSource = dt;
                }
            }
            else
            {
                DialogResult Result;
                Result = MessageBox.Show("No se encontró el cliente. Desea darlo de alta?", " ", MessageBoxButtons.OKCancel);

                if (Result == DialogResult.OK)
                {
                    ABM_de_Cliente.Cliente_Alta cliente_Alta = new FrbaHotel.ABM_de_Cliente.Cliente_Alta();
                    cliente_Alta.Show(this);
                }
                else
                {
                    return;
                }
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
            cliente_Modificacion.cbox_nacionalidad.Items.Add(dgv_clientes.CurrentRow.Cells[2].Value.ToString());
            cliente_Modificacion.date_nacimiento.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            cliente_Modificacion.txt_mail.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
            cliente_Modificacion.txt_telefono.Text = dgv_clientes.CurrentRow.Cells[5].Value.ToString();
            cliente_Modificacion.txt_dom_calle.Text = dgv_clientes.CurrentRow.Cells[6].Value.ToString();
            cliente_Modificacion.txt_dom_nro.Text = dgv_clientes.CurrentRow.Cells[7].Value.ToString();
            cliente_Modificacion.txt_dom_piso.Text = dgv_clientes.CurrentRow.Cells[8].Value.ToString();
            cliente_Modificacion.txt_dom_dpto.Text = dgv_clientes.CurrentRow.Cells[9].Value.ToString();
            cliente_Modificacion.txt_ciudad.Text = dgv_clientes.CurrentRow.Cells[10].Value.ToString();
            cliente_Modificacion.txt_pais.Text = dgv_clientes.CurrentRow.Cells[11].Value.ToString();
            cliente_Modificacion.cbox_tipo_doc.Items.Add(dgv_clientes.CurrentRow.Cells[12].Value.ToString());
            cliente_Modificacion.txt_nro_doc.Text = dgv_clientes.CurrentRow.Cells[13].Value.ToString();
            cliente_Modificacion.cbox_estado.Items.Add(dgv_clientes.CurrentRow.Cells[14].Value.ToString());
            
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
            cliente_Baja.txt_telefono.Text = dgv_clientes.CurrentRow.Cells[5].Value.ToString();
            cliente_Baja.txt_dom_calle.Text = dgv_clientes.CurrentRow.Cells[6].Value.ToString();
            cliente_Baja.txt_dom_nro.Text = dgv_clientes.CurrentRow.Cells[7].Value.ToString();
            cliente_Baja.txt_dom_piso.Text = dgv_clientes.CurrentRow.Cells[8].Value.ToString();
            cliente_Baja.txt_dom_dpto.Text = dgv_clientes.CurrentRow.Cells[9].Value.ToString();
            cliente_Baja.txt_ciudad.Text = dgv_clientes.CurrentRow.Cells[10].Value.ToString();
            cliente_Baja.txt_pais.Text = dgv_clientes.CurrentRow.Cells[11].Value.ToString();
            cliente_Baja.txt_tipodoc.Text = dgv_clientes.CurrentRow.Cells[12].Value.ToString();
            cliente_Baja.txt_nro_doc.Text = dgv_clientes.CurrentRow.Cells[13].Value.ToString();
            cliente_Baja.cbox_estado.Items.Add(dgv_clientes.CurrentRow.Cells[14].Value.ToString());
            
            cliente_Baja.Show();
        }
          

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Modificacion.Enabled = true;
            btn_Baja.Enabled = true;
        }
    }
}

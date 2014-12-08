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

        private static Clientes _instancia;

        public static Clientes ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Clientes();
            }
            _instancia.BringToFront();
            return _instancia;
        }


        Dominio.Cliente cliente1 = new Dominio.Cliente();

        string tipoDoc;
        string idEstado;
        string descEstado;
        Dominio.Cliente tipoDoc1 = new Dominio.Cliente();

        public Clientes()
        {
            InitializeComponent();
            InicializarComboBoxTipoDoc();
        }              

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_mail.Text = "";
            txt_nro_doc.Text = "";
            cbox_tipodoc.SelectedIndex = 0;
        }

        /*validacion teclas permitidas*/
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


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void InicializarComboBoxTipoDoc()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cbox_tipodoc.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "DNI";
            item1.Value = "1";
            cbox_tipodoc.Items.Add(item1);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "CI";
            item2.Value = "2";
            cbox_tipodoc.Items.Add(item2);

            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "LE";
            item3.Value = "3";
            cbox_tipodoc.Items.Add(item3);

            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "LC";
            item4.Value = "4";
            cbox_tipodoc.Items.Add(item4);

            Dominio.ComboBoxItem item5 = new Dominio.ComboBoxItem();
            item5.Text = "PASS";
            item5.Value = "5";
            cbox_tipodoc.Items.Add(item5);

            Dominio.ComboBoxItem item6 = new Dominio.ComboBoxItem();
            item6.Text = "Otro";
            item6.Value = "6";
            cbox_tipodoc.Items.Add(item6);

            cbox_tipodoc.SelectedIndex = 0;
        }

        private string DescripEstado(string idEstado)
        {
            if (idEstado == "True")
            {
                descEstado = "Habilitado";
            }
            else
            {
                descEstado = "Inhabilitado";
            }
            return descEstado;
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Dominio.Cliente cli1 = new Dominio.Cliente();

            try
            {
                Dominio.ComboBoxItem itemCbox_tipodoc = (Dominio.ComboBoxItem)cbox_tipodoc.SelectedItem;

                if (itemCbox_tipodoc.Value == null)
                {
                    itemCbox_tipodoc.Value = "";
                }

                DataTable dt = cli1.BuscarClientes(txt_nombre.Text, txt_apellido.Text, txt_mail.Text, itemCbox_tipodoc.Value.ToString(), txt_nro_doc.Text);
                
                if (dt.Rows.Count == 0 )
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
                else
                {
                    dgv_clientes.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar la búsqueda");                
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
            cliente_Modificacion.date_nacimiento.Value = Convert.ToDateTime(dgv_clientes.CurrentRow.Cells[3].Value.ToString());
            cliente_Modificacion.txt_mail.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
            cliente_Modificacion.txt_telefono.Text = dgv_clientes.CurrentRow.Cells[5].Value.ToString();
            cliente_Modificacion.txt_dom_calle.Text = dgv_clientes.CurrentRow.Cells[6].Value.ToString();
            cliente_Modificacion.txt_dom_nro.Text = dgv_clientes.CurrentRow.Cells[7].Value.ToString();
            cliente_Modificacion.txt_dom_piso.Text = dgv_clientes.CurrentRow.Cells[8].Value.ToString();
            cliente_Modificacion.txt_dom_dpto.Text = dgv_clientes.CurrentRow.Cells[9].Value.ToString();
            cliente_Modificacion.txt_ciudad.Text = dgv_clientes.CurrentRow.Cells[10].Value.ToString();
            cliente_Modificacion.txt_pais.Text = dgv_clientes.CurrentRow.Cells[11].Value.ToString();

            tipoDoc = dgv_clientes.CurrentRow.Cells[12].Value.ToString();
            DataTable dt_tipoDoc = tipoDoc1.RecuperaDescripDoc(tipoDoc);
            cliente_Modificacion.txt_tipodoc.Text = dt_tipoDoc.Rows[0][0].ToString();

            cliente_Modificacion.txt_nro_doc.Text = dgv_clientes.CurrentRow.Cells[13].Value.ToString();
                   
            idEstado = dgv_clientes.CurrentRow.Cells[14].Value.ToString();
            DescripEstado(idEstado);
            cliente_Modificacion.txt_estado.Text = descEstado;      
                      
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

            tipoDoc = dgv_clientes.CurrentRow.Cells[12].Value.ToString();
            DataTable dt_tipoDoc = tipoDoc1.RecuperaDescripDoc(tipoDoc);
            cliente_Baja.txt_tipodoc.Text = dt_tipoDoc.Rows[0][0].ToString();

            cliente_Baja.txt_nro_doc.Text = dgv_clientes.CurrentRow.Cells[13].Value.ToString();

            idEstado = dgv_clientes.CurrentRow.Cells[14].Value.ToString();
            DescripEstado(idEstado);
            cliente_Baja.txt_estado.Text = descEstado;            
            
            cliente_Baja.Show();
        }
          

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Modificacion.Enabled = true;
            btn_Baja.Enabled = true;
        }
    }
}

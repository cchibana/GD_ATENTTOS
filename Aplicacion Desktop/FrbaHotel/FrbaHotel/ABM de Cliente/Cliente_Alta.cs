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
    public partial class Cliente_Alta : Form
    {
        public Cliente_Alta()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
            InicializarComboBoxTipoDocumento();
        }


        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cbox_nacionalidad.SelectedItem = null;
            date_nacimiento.Value = DateTime.Now;
            txt_mail.Text = "";
            txt_telefono.Text = "";            
            txt_dom_calle.Text = "";
            txt_dom_nro.Text = "";
            txt_dom_piso.Text = "";
            txt_dom_dpto.Text = "";
            txt_ciudad.Text = "";
            cbox_pais.SelectedItem = null;            
            cbox_tipodoc.SelectedItem = null;
            txt_nrodoc.Text = "";
            cbox_estado.SelectedItem = "Habilitado";            
        }


        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Habilitado";
            item0.Value = "1";
            cbox_estado.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Inhabilitado";
            item1.Value = "0";
            cbox_estado.Items.Add(item1);
        }

        private void InicializarComboBoxTipoDocumento()
        {
            Dominio.Cliente cli1 = new Dominio.Cliente();
            DataTable dt_TipoDoc = cli1.ListarTipoDoc();
            for (int i = 0; i < dt_TipoDoc.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_TipoDoc.Rows[i][0].ToString();
                item.Value = dt_TipoDoc.Rows[i][0].ToString();

                cbox_tipodoc.Items.Add(item);
            }
            cbox_tipodoc.SelectedIndex = 0;
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


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Dominio.Cliente cli1 = new Dominio.Cliente();

                if (cli1.verificarTipoYNumeroDocumentoValido(cbox_tipodoc.SelectedItem.ToString(), txt_nrodoc.Text))
                {
                    if (cli1.verificarMailValido(txt_mail.Text))
                    {
                        if (cli1.InsertarDatosEnTablaClientes(txt_nombre.Text, txt_apellido.Text, cbox_nacionalidad.SelectedItem.ToString(), date_nacimiento.Value.ToString("yyyy-MM-dd"), txt_mail.Text, txt_telefono.Text, txt_dom_calle.Text, txt_dom_nro.Text, txt_dom_piso.Text, txt_dom_dpto.Text, txt_ciudad.Text, cbox_pais.SelectedItem.ToString(), cbox_tipodoc.SelectedItem.ToString(), txt_nrodoc.Text, cbox_estado.SelectedItem.ToString()))
                        {
                            DialogResult Result;
                            Result = MessageBox.Show("Alta de Cliente Exitosa. Desea Ingresar otro?", " ", MessageBoxButtons.OKCancel);

                            if (Result != DialogResult.OK)
                            {
                                this.Close();
                            }
                            else
                            {
                                Limpiar();                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido dar de alta al nuevo Cliente");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con el mail ingresado");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con el tipo y número de documento ingresado");
                }
            }            
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_nombre.Text) ||
                string.IsNullOrEmpty(this.txt_apellido.Text) ||
                string.IsNullOrEmpty(this.cbox_nacionalidad.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.date_nacimiento.Value.ToString()) ||
                string.IsNullOrEmpty(this.txt_mail.Text) ||
                string.IsNullOrEmpty(this.txt_telefono.Text) ||
                string.IsNullOrEmpty(this.txt_dom_calle.Text) ||
                string.IsNullOrEmpty(this.txt_dom_nro.Text) ||                
                string.IsNullOrEmpty(this.txt_ciudad.Text) ||
                string.IsNullOrEmpty(this.cbox_pais.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.cbox_tipodoc.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.txt_nrodoc.Text) ||
                string.IsNullOrEmpty(this.cbox_estado.SelectedItem.ToString()))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }


        private void Cliente_Alta_Load(object sender, EventArgs e)
        {
            Dominio.Cliente nacionalidad1 = new Dominio.Cliente();
            DataTable nacionalidad = nacionalidad1.ListarNacionalidades();

            for (int i = 0; i < nacionalidad.Rows.Count; i++)
            {
                cbox_nacionalidad.Items.Add(nacionalidad.Rows[i][0]);
            }

            Dominio.Cliente pais1 = new Dominio.Cliente();
            DataTable pais = pais1.ListarPaises();

            for (int i = 0; i < pais.Rows.Count; i++)
            {
                cbox_pais.Items.Add(pais.Rows[i][0]);
            }
            
        }
                      

    }
}

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
    public partial class Cliente_Modificacion : Form
    {

        private static Cliente_Modificacion _instancia;

        private string Cli_TipoDocumentoBD;
        private long? Cli_NroDocumentoBD;
        private string Cli_MailBD;

        public static Cliente_Modificacion ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Cliente_Modificacion();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Cliente_Modificacion()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
        }

        public Cliente_Modificacion(string stringvalor)
        {
            InitializeComponent();
            txt_nombre.Text = stringvalor;
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_nombre.Text) ||
                string.IsNullOrEmpty(this.txt_apellido.Text) ||
                string.IsNullOrEmpty(this.txt_nacionalidad.Text) ||
                string.IsNullOrEmpty(this.date_nacimiento.Value.ToString()) ||
                string.IsNullOrEmpty(this.txt_mail.Text) ||
                string.IsNullOrEmpty(this.txt_telefono.Text) ||
                string.IsNullOrEmpty(this.txt_dom_calle.Text) ||
                string.IsNullOrEmpty(this.txt_dom_nro.Text) ||
                string.IsNullOrEmpty(this.txt_ciudad.Text) ||
                string.IsNullOrEmpty(this.txt_pais.Text) ||
                string.IsNullOrEmpty(this.txt_tipodoc.Text) ||
                string.IsNullOrEmpty(this.txt_nro_doc.Text) ||
                string.IsNullOrEmpty(this.txt_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }
        

        private void Cliente_Modificacion_Load(object sender, EventArgs e)
        {
            Dominio.Cliente nacionalidad1 = new Dominio.Cliente();
            DataTable nacionalidad = nacionalidad1.ListarNacionalidades();

            for (int i = 0; i < nacionalidad.Rows.Count; i++)
            {
                cbox_nacionalidad.Items.Add(nacionalidad.Rows[i][0]);
            }

            Dominio.Cliente tipoDoc1 = new Dominio.Cliente();
            DataTable tipoDoc = tipoDoc1.ListarTipoDoc();

            for (int i = 0; i < tipoDoc.Rows.Count; i++)
            {
                cbox_tipodoc.Items.Add(tipoDoc.Rows[i][0]);
            }

            Cli_TipoDocumentoBD = txt_tipodoc.Text;
            Cli_NroDocumentoBD = Convert.ToInt64(txt_nro_doc.Text);
            Cli_MailBD = txt_mail.Text;
        }

        private void CambiarNacionalidad(object sender, EventArgs e)
        {
            txt_nacionalidad.Text = cbox_nacionalidad.SelectedItem.ToString();
        }

        private void CambiarTipoDoc(object sender, EventArgs e)
        {
            txt_tipodoc.Text = cbox_tipodoc.SelectedItem.ToString();
        }

        private void CambiarEstado(object sender, EventArgs e)
        {
            txt_estado.Text = cbox_estado.SelectedItem.ToString();
        }

                
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                bool estadoModificaciones = true;
                Dominio.Cliente cli1 = new Dominio.Cliente();

                if (estadoModificaciones)
                {
                    if (this.Cli_MailBD != txt_mail.Text)
                    {
                        if (!cli1.verificarMailValido(txt_mail.Text))
                        {
                            MessageBox.Show("Ya existe un Cliente con el mail ingresado");
                            estadoModificaciones = false;
                        }
                    }
                }

                if (estadoModificaciones)
                {
                    if (this.Cli_NroDocumentoBD != Convert.ToInt64(txt_nro_doc.Text) || this.Cli_TipoDocumentoBD != txt_tipodoc.Text)
                    {
                        if (!cli1.verificarTipoYNumeroDocumentoValido(txt_tipodoc.Text, txt_nro_doc.Text))
                        {
                            MessageBox.Show("Ya existe un cliente con el tipo y número de documento ingresado");
                            estadoModificaciones = false;
                        }
                    }
                }

                if (estadoModificaciones)
                {
                    if (!cli1.ModificarDatosClientes(txt_nombre.Text, txt_apellido.Text, txt_nacionalidad.Text, date_nacimiento.Value, txt_mail.Text, txt_telefono.Text, txt_dom_calle.Text, txt_dom_nro.Text, txt_dom_piso.Text, txt_dom_dpto.Text, txt_ciudad.Text, txt_pais.Text, txt_tipodoc.Text, txt_nro_doc.Text, txt_estado.Text))
                    {
                        MessageBox.Show("Error en la modificación de datos del cliente");
                        estadoModificaciones = false;
                    }
                }

                if (estadoModificaciones)
                {
                    MessageBox.Show("Se han guardado los cambios correctamente");
                    this.Hide();
                    this.Close();
                }
            }
        }
                    
        
    }
}

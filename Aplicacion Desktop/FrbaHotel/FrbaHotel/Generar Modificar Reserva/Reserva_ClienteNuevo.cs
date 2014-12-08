using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class Reserva_ClienteNuevo : Form
    {
        private static Reserva_ClienteNuevo _instancia;

        public static Reserva_ClienteNuevo ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Reserva_ClienteNuevo();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Reserva_ClienteNuevo()
        {
            InitializeComponent();
            InicializarComboBoxTipoDocumento();
            InicializarComboBoxPais();
        }

        private void InicializarComboBoxPais()
        {
            Dominio.Cliente pais1 = new Dominio.Cliente();
            DataTable pais = pais1.ListarPaises();

            for (int i = 0; i < pais.Rows.Count; i++)
            {
                cbox_pais.Items.Add(pais.Rows[i][0]);
            }
            cbox_pais.SelectedIndex = 0;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Dominio.Cliente cli1 = new Dominio.Cliente();

                if (cli1.verificarTipoYNumeroDocumentoValido(cbox_tipodoc.SelectedItem.ToString(), txt_nrodoc.Text))
                {
                    if (cli1.verificarMailValido(txt_mail.Text))
                    {
                        if (cli1.InsertarDatosEnTablaClientesReservas(txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text, txt_dom_calle.Text, txt_dom_nro.Text, txt_dom_piso.Text, txt_dom_dpto.Text, txt_ciudad.Text, cbox_pais.SelectedItem.ToString(), cbox_tipodoc.SelectedItem.ToString(), txt_nrodoc.Text))
                        {
                            MessageBox.Show("Alta de Cliente Exitosa.");

                            Reserva_ClienteBusqueda newCliBusqueda = Reserva_ClienteBusqueda.ObtenerInstancia();
                            newCliBusqueda.Show();
                            this.Close();

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

        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
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


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txt_nombre.Text) ||
                string.IsNullOrEmpty(this.txt_apellido.Text) ||
                string.IsNullOrEmpty(this.txt_mail.Text) ||
                string.IsNullOrEmpty(this.txt_telefono.Text) ||
                string.IsNullOrEmpty(this.txt_dom_calle.Text) ||
                string.IsNullOrEmpty(this.txt_dom_nro.Text) ||
                string.IsNullOrEmpty(this.txt_ciudad.Text) ||
                string.IsNullOrEmpty(this.cbox_pais.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.cbox_tipodoc.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(this.txt_nrodoc.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Reserva_Generar resGen = Reserva_Generar.ObtenerInstancia();
            resGen.Show();
            this.Close();
        }
    }
}

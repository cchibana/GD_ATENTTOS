using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Facturacion
{
    public partial class FacturarEstadia : Form
    {
        private static FacturarEstadia _instancia;

        public static FacturarEstadia ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new FacturarEstadia();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public FacturarEstadia()
        {
            InitializeComponent();
            CargarComboBoxFormasDePago();
        }

        private void CargarComboBoxFormasDePago()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Efectivo";
            item1.Value = 1;
            cb_FormaDePago.Items.Add(item1);
            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "Tarjeta";
            item2.Value = 2;
            cb_FormaDePago.Items.Add(item2);
            cb_FormaDePago.SelectedIndex = 0;
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

        private void cb_FormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FormaDePago.SelectedIndex == 0)
            {
                gb_PagoTarjeta.Enabled = false;
            }
            else
            {
                gb_PagoTarjeta.Enabled = true;
            }
        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            Dominio.Facturacion f1 = new Dominio.Facturacion();
            DataTable dt = f1.VerificarEstadiaCheckOut(txt_NroEstadia.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se ha encontrado el nro de Estadía");
            }
            else if (Convert.ToBoolean(dt.Rows[0][0].ToString()))
            {
                Dominio.ComboBoxItem itemFormaPago = (Dominio.ComboBoxItem)cb_FormaDePago.SelectedItem;
                f1.RegistrarFacturacion(txt_NroEstadia.Text,itemFormaPago.Text.ToString(), txt_NroTarjeta.Text, txt_Banco.Text);
            }
            else
            {
                MessageBox.Show("Debe realizar el Checkout antes de realizar la facturación");
            }
        }
    }
}

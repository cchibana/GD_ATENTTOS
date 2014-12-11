using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumibles : Form
    {
        private static RegistrarConsumibles _instancia;

        public static RegistrarConsumibles ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new RegistrarConsumibles();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public RegistrarConsumibles()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            Dominio.Consumible cons1 = new Dominio.Consumible();
            DataTable dt_Consumibles = cons1.ListarConsumibles();

            for (int i = 0; i < dt_Consumibles.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_Consumibles.Rows[i][1].ToString();
                item.Value = dt_Consumibles.Rows[i][0].ToString();

                cb_Consumibles.Items.Add(item);
            }
            cb_Consumibles.SelectedIndex = 0;
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

        private void btn_RegistrarConsumible_Click(object sender, EventArgs e)
        {
            Dominio.Consumible cons1 = new Dominio.Consumible();
            Dominio.ComboBoxItem itemConsumible = (Dominio.ComboBoxItem)cb_Consumibles.SelectedItem;
            DataTable dt = cons1.VerificarFechaValida(txt_NroEstadia.Text);
            if (dt.Rows.Count == 0)
	        {
		         MessageBox.Show("No se ha encontrado el número de ESTADIA");
	        }
            else if (Convert.ToBoolean(dt.Rows[0][0].ToString()))
            {
                if (cons1.RegistrarConsumible(txt_NroEstadia.Text, itemConsumible.Value.ToString(), txt_Cantidad.Text))
                {
                    MessageBox.Show("Se ha registrado la consumición");
                }
                else
                {
                    MessageBox.Show("Error al registrar la consumición");
                }
            }
            else
            {
                MessageBox.Show("Ya se ha realizado el Check out de la estadía. No puede registrar más consumiciones.");
            }

        }
    }
}

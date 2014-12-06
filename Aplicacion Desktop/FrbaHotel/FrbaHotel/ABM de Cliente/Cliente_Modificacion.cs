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
        
    }
}

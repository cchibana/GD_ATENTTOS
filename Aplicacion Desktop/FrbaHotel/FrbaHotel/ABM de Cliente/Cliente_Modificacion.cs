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
        }

        public Cliente_Modificacion(string stringvalor)
        {
            InitializeComponent();
            txt_nombre.Text = stringvalor;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}

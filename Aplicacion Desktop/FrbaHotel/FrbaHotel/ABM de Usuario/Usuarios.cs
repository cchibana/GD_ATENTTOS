using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuario_Alta usuario_Alta = new FrbaHotel.ABM_de_Usuario.Usuario_Alta();
            usuario_Alta.Show(this);
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuario_Modificacion usuario_Modificacion = new FrbaHotel.ABM_de_Usuario.Usuario_Modificacion();
            usuario_Modificacion.Show(this);
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuario_Alta usuario_Baja = new FrbaHotel.ABM_de_Usuario.Usuario_Alta();
            usuario_Baja.Show(this);
        }
    }
}

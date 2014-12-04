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
    public partial class NuevaContrasenia : Form
    {
        private static NuevaContrasenia _instancia;

        public static NuevaContrasenia ObtenerInstancia(string nombreUsuario)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new NuevaContrasenia(nombreUsuario);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public NuevaContrasenia(string nombreUsuario)
        {
            InitializeComponent();
            lbl_nombreUsuario.Text = nombreUsuario;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            if (usu1.GuardarNuevaContrasenia(lbl_nombreUsuario.Text, txt_Contrasenia.Text))
            {
                MessageBox.Show("Se ha guardado la nueva contraseña");
                this.Close();
            } 
            else
            {
                MessageBox.Show("Error al guardar la contraseña");
            }   
        }
    }
}

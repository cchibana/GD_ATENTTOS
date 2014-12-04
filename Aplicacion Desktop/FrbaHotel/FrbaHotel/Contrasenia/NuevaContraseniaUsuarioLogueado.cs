using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Contrasenia
{
    public partial class NuevaContraseniaUsuarioLogueado : Form
    {
        private static NuevaContraseniaUsuarioLogueado _instancia;

        public static NuevaContraseniaUsuarioLogueado ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new NuevaContraseniaUsuarioLogueado();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public NuevaContraseniaUsuarioLogueado()
        {
            InitializeComponent();
            lbl_NombreUsuario.Text = Dominio.UsuarioLogin.TheInstance.getUsuario();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Dominio.ContraseniaUsuarioLogueado contr1 = new Dominio.ContraseniaUsuarioLogueado();
            if (contr1.VerificarContraseniaDeUsuarioLogueado(lbl_NombreUsuario.Text,txt_ContraseniaActual.Text))
            {
                if (txt_ContraseniaNueva1.Text == txt_ContraseniaNueva2.Text)
                {
                    if (contr1.ModificarContraseniaDelUsuario(lbl_NombreUsuario.Text, txt_ContraseniaNueva1.Text))
                    {
                        MessageBox.Show("Se ha guardado la nueva contraseña");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar la nueva contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("No coinciden los campos de la contraseña nueva.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual ingresada no es válida.");
            }   

        }
    }
}

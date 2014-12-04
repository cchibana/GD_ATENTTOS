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
    public partial class Usuario_Baja : Form
    {
        private static Usuario_Baja _instancia;

        public static Usuario_Baja ObtenerInstancia(string nombreUsuario)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Usuario_Baja(nombreUsuario);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Usuario_Baja(string nombreUsuario)
        {
            InitializeComponent();
            CargarDatos(nombreUsuario);
        }

        internal void CargarDatos(string nombreUsuario)
        {
            txt_Username.Text = nombreUsuario;
            txt_Estado.Text = "Activo";

            Dominio.Usuario usu1 = new FrbaHotel.Dominio.Usuario();
            DataTable dtRoles = usu1.ObtenerRolesUsuario(nombreUsuario);
            for (int i = 0; i < dtRoles.Rows.Count; i++)
            {
                string rolUsuarioDB = dtRoles.Rows[i][0].ToString();
                lb_roles.Items.Add(rolUsuarioDB);
            }

            DataTable dt = usu1.ObtenerDatosUsuario(nombreUsuario);
            if (dt.Rows.Count > 0)
            {
                txt_Usuario_Nombre.Text = dt.Rows[0][0].ToString();
                txt_Usuario_Apellido.Text = dt.Rows[0][1].ToString();
                txt_TipoDocumento.Text = dt.Rows[0][2].ToString();
                txt_Usuario_NroDocumento.Text = dt.Rows[0][3].ToString();
                txt_Usuario_Mail.Text = dt.Rows[0][4].ToString();
                txt_Usuario_Telefono.Text = dt.Rows[0][5].ToString();
                txt_Usuario_Direccion.Text = dt.Rows[0][6].ToString();
                txt_FechaNacimiento.Text = Convert.ToDateTime(dt.Rows[0][7].ToString()).ToShortDateString();
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            
            if (usu1.ModificarEstadoEnTablaUsuario(txt_Username.Text,0))
            {
                MessageBox.Show("Se ha dado de baja al Usuario " + txt_Username.Text);
            }
            else
            {
                MessageBox.Show("Error al dar de baja al Usuario");
            }
            this.Hide();
            ABM_de_Usuario.Usuarios newUsu = ABM_de_Usuario.Usuarios.ObtenerInstancia();
            newUsu.BuscarUsuarios();
            newUsu.Show();
            this.Close();

        }

        private void btn_TodosRolesHoteles_Click(object sender, EventArgs e)
        {
            string estadoUsuario;
            if (txt_Estado.Text == "Activo")
            {
                estadoUsuario = "True";
            }
            else
            {
                estadoUsuario = "False";
            }

            ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario ventanaRolesHotelesDeUsuario = ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario.ObtenerInstancia(txt_Username.Text, estadoUsuario);
            ventanaRolesHotelesDeUsuario.Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

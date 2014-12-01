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
    public partial class Usuario_Modificacion : Form
    {
        private static Usuario_Modificacion _instancia;

        public static Usuario_Modificacion ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Usuario_Modificacion();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Usuario_Modificacion()
        {
            InitializeComponent(); 
            InicializarComboBoxRol();
            InicializarComboBoxTipoDocumento();
            InicializarComboBoxEstadoUsuario();
        }

        private void InicializarComboBoxRol()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            DataTable dt_roles = usu1.ListarTodosLosRolesActivosNoGuest();
            for (int i = 0; i < dt_roles.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_roles.Rows[i][0].ToString();
                item.Value = dt_roles.Rows[i][0].ToString();

                cb_Rol.Items.Add(item);
            }
            cb_Rol.SelectedIndex = 0;
        }

        private void InicializarComboBoxTipoDocumento()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            DataTable dt_TipoDoc = usu1.ListarTodosLosTiposDocumentos();
            for (int i = 0; i < dt_TipoDoc.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_TipoDoc.Rows[i][0].ToString();
                item.Value = dt_TipoDoc.Rows[i][0].ToString();

                cb_Usuario_TipoDocumento.Items.Add(item);
            }
            cb_Usuario_TipoDocumento.SelectedIndex = 0;
        }

        private void InicializarComboBoxEstadoUsuario()
        {
            Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
            item.Text = "Activo";
            item.Value = "True";
            cb_EstadoUsuario.Items.Add(item);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "No Activo";
            item2.Value = "False";
            cb_EstadoUsuario.Items.Add(item2);
            cb_EstadoUsuario.SelectedIndex = 0;
        }


        internal void CargarDatos(string nombreUsuario, string estadoUsuario)
        {
            txt_Username.Text = nombreUsuario;
            if (estadoUsuario == "True")
            {
                cb_EstadoUsuario.SelectedIndex = 0;
            }
            else
            {
                cb_EstadoUsuario.SelectedIndex = 1;
            }

            Dominio.Usuario usu1 = new FrbaHotel.Dominio.Usuario();
            DataTable dt = usu1.ObtenerDatosUsuario(nombreUsuario);
            if (dt.Rows.Count > 0)
	        {
                txt_Usuario_Nombre.Text = dt.Rows[0][0].ToString();
                txt_Usuario_Apellido.Text = dt.Rows[0][1].ToString();
                int index = cb_Usuario_TipoDocumento.FindString(dt.Rows[0][2].ToString());
                cb_Usuario_TipoDocumento.SelectedIndex = index;
                txt_Usuario_NroDocumento.Text = dt.Rows[0][3].ToString();
                txt_Usuario_Mail.Text = dt.Rows[0][4].ToString();
                txt_Usuario_Telefono.Text = dt.Rows[0][5].ToString();
                txt_Usuario_Direccion.Text = dt.Rows[0][6].ToString();
                dtp_Usuario_FechaNacimiento.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
            }
            else
            {
                MessageBox.Show("No se han cargado los datos personales del usuario seleccionado.");
                LimpiarDatosPersonales();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_Username.Text = null;
            cb_Rol.SelectedIndex = 0;
            lb_roles.Items.Clear();
            LimpiarDatosPersonales();
        }

        private void LimpiarDatosPersonales()
        {
            txt_Usuario_Nombre.Text = null;
            txt_Usuario_Apellido.Text = null;
            cb_Usuario_TipoDocumento.SelectedIndex = 0;
            txt_Usuario_NroDocumento.Text = null;
            txt_Usuario_Mail.Text = null;
            txt_Usuario_Telefono.Text = null;
            txt_Usuario_Direccion.Text = null;
            dtp_Usuario_FechaNacimiento.Value = DateTime.Now;
        }

        private void btn_QuitarRol_Click(object sender, EventArgs e)
        {
            if (this.lb_roles.SelectedIndex >= 0)
            {
                this.lb_roles.Items.RemoveAt(this.lb_roles.SelectedIndex);
            }
        }

        private void btn_AgregarRol_Click_1(object sender, EventArgs e)
        {
            if (!lb_roles.Items.Contains(cb_Rol.SelectedItem.ToString()))
            {
                string itemSelTexto = cb_Rol.SelectedItem.ToString();
                lb_roles.Items.Add(itemSelTexto);
            }
            else
            {
                MessageBox.Show("El rol seleccionado ya se ha sido agregado.");
            }
        }

    }
}

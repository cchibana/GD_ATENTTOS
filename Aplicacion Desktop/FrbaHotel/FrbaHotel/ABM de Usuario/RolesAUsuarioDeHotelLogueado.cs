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
    public partial class RolesAUsuarioDeHotelLogueado : Form
    {
        private static RolesAUsuarioDeHotelLogueado _instancia;

        public static RolesAUsuarioDeHotelLogueado ObtenerInstancia(string nombreUsuario)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new RolesAUsuarioDeHotelLogueado(nombreUsuario);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public RolesAUsuarioDeHotelLogueado(string nombreUsuario)
        {
            InitializeComponent();
            lbl_nombreUsuario.Text = nombreUsuario;
            gb_Roles.Text = "Roles en este hotel '" + Dominio.UsuarioLogin.TheInstance.getHotelNombre() + " '";
            InicializarComboBoxRol();
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

        private void btn_AgregarRol_Click(object sender, EventArgs e)
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

        private void btn_QuitarRol_Click(object sender, EventArgs e)
        {
            if (this.lb_roles.SelectedIndex >= 0)
            {
                this.lb_roles.Items.RemoveAt(this.lb_roles.SelectedIndex);
            }
        }

        private void btn_GuardarRoles_Click(object sender, EventArgs e)
        {
            if (lb_roles.Items.Count != 0)
            {
                Dominio.Usuario usu1 = new Dominio.Usuario();
                List<string> listaRolesSeleccionados = ArmarListaRolesSeleccionados();
                if (usu1.InsertarUsuarioEnTablaRoles_Por_Usuarios_Y_Hoteles(listaRolesSeleccionados, lbl_nombreUsuario.Text))
                {
                    MessageBox.Show("Se han guardado los roles para el usuario seleccionado en este hotel.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se ha producido un error al guardar los roles.");
                }
            }
            else
            {
                MessageBox.Show("Debe agregar algún rol en la lista.");
            }
 
            
        }

        private List<string> ArmarListaRolesSeleccionados()
        {
            List<string> listaRolesSeleccionados = new List<string>();

            //Arma una lista a partir del ListBox de Roles
            listaRolesSeleccionados = this.lb_roles.Items.Cast<String>().ToList();
            return listaRolesSeleccionados;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

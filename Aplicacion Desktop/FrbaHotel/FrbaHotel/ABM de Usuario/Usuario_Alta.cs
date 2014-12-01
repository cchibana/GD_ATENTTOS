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
    public partial class Usuario_Alta : Form
    {
        private static Usuario_Alta _instancia;

        public static Usuario_Alta ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Usuario_Alta();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Usuario_Alta()
        {
            InitializeComponent();
            InicializarComboBoxRol();
            InicializarComboBoxTipoDocumento();
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


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_Username.Text = null;
            txt_Contrasenia.Text = null;
            cb_Rol.SelectedIndex = 0;
            lb_roles.Items.Clear();
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

        private void btn_DarDeAlta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
	        {
        		Dominio.Usuario usu1 = new Dominio.Usuario();
                if (usu1.verificarNombreDeUsuarioValido(txt_Username.Text))
                {
                    if (usu1.verificarTipoYNumeroDocumentoValido(cb_Usuario_TipoDocumento.SelectedItem.ToString(), txt_Usuario_NroDocumento.Text))
                    {
                        if (usu1.verificarMailValido(txt_Usuario_Mail.Text))
                        {
                            if (usu1.InsertarUsuarioEnTablaUsuarios(txt_Username.Text, txt_Contrasenia.Text))
                            {
                                List<string> listaRolesSeleccionados = ArmarListaRolesSeleccionados();
                                if (usu1.InsertarUsuarioEnTablaRoles_Por_Usuarios_Y_Hoteles(listaRolesSeleccionados, txt_Username.Text))
                                {
                                    //Falta Insertar Datos en la tabla Roles por Usuarios y Hoteles
                                    if (usu1.InsertarDatosEnTablaEmpleados(txt_Usuario_Nombre.Text, txt_Usuario_Apellido.Text, cb_Usuario_TipoDocumento.SelectedItem.ToString(), txt_Usuario_NroDocumento.Text, txt_Usuario_Mail.Text, txt_Usuario_Telefono.Text, txt_Usuario_Direccion.Text, dtp_Usuario_FechaNacimiento.Value.ToString("yyyy-MM-dd"), txt_Username.Text))
                                    {
                                        MessageBox.Show("Alta de Usuario Exitosa");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha podido dar de alta al nuevo Usuario");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error al dar los roles en el hotel del nuevo usuario");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al dar de alta el usuario.");
                            }   
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con el mail ingresado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con el tipo y número de documento ingresado");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado no se encuentra disponible");
                }
	        }
        }

        private List<string> ArmarListaRolesSeleccionados()
        {
            List<string> listaRolesSeleccionados = new List<string>();

            //Arma una lista a partir del ListBox de Roles
            listaRolesSeleccionados = this.lb_roles.Items.Cast<String>().ToList();
            return listaRolesSeleccionados;
        }


        private bool ValidarCampos()
        {
             if (string.IsNullOrEmpty(this.txt_Username.Text) ||
                 string.IsNullOrEmpty(this.txt_Contrasenia.Text) ||
                 string.IsNullOrEmpty(this.txt_Usuario_Nombre.Text) ||
                 string.IsNullOrEmpty(this.txt_Usuario_Apellido.Text) ||
                 string.IsNullOrEmpty(this.txt_Usuario_NroDocumento.Text) ||
                 string.IsNullOrEmpty(this.txt_Usuario_Mail.Text) ||
                 string.IsNullOrEmpty(this.txt_Usuario_Telefono.Text)||
                 string.IsNullOrEmpty(this.txt_Usuario_Direccion.Text) ||
                 lb_roles.Items.Count == 0
             )
             {
                 MessageBox.Show("Debe completar todos los campos");
                 return false;
             }
             return true;
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

    }
}

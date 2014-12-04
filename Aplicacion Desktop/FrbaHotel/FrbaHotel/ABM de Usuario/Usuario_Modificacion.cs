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

        private string Usu_UserNameBD;
        private int Usu_EstadoBD;
        private List<string> Usu_RolesBD;
        private string Usu_TipoDocumentoBD;
        private long? Usu_NroDocumentoBD;
        private string Usu_MailBD;
        private bool estadoDatosUsuario; //Para saber si el usuario tenía datos cargados.

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
            Usu_RolesBD = new List<string>();
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
            this.Usu_UserNameBD = nombreUsuario;
            if (estadoUsuario == "True")
            {
                cb_EstadoUsuario.SelectedIndex = 0;
                this.Usu_EstadoBD = 1;
            }
            else
            {
                cb_EstadoUsuario.SelectedIndex = 1;
                this.Usu_EstadoBD = 0;
            }


            Dominio.Usuario usu1 = new FrbaHotel.Dominio.Usuario();
            DataTable dtRoles = usu1.ObtenerRolesUsuario(nombreUsuario);
            for (int i = 0; i < dtRoles.Rows.Count; i++)
            {
                string rolUsuarioDB = dtRoles.Rows[i][0].ToString();
                lb_roles.Items.Add(rolUsuarioDB);
                this.Usu_RolesBD.Add(rolUsuarioDB);
            }

            DataTable dt = usu1.ObtenerDatosUsuario(nombreUsuario);
            if (dt.Rows.Count > 0)
	        {
                txt_Usuario_Nombre.Text = dt.Rows[0][0].ToString();
                txt_Usuario_Apellido.Text = dt.Rows[0][1].ToString();
                int index = cb_Usuario_TipoDocumento.FindString(dt.Rows[0][2].ToString());
                cb_Usuario_TipoDocumento.SelectedIndex = index;
                this.Usu_TipoDocumentoBD = dt.Rows[0][2].ToString();
                txt_Usuario_NroDocumento.Text = dt.Rows[0][3].ToString();
                this.Usu_NroDocumentoBD = Convert.ToInt64(dt.Rows[0][3].ToString());
                txt_Usuario_Mail.Text = dt.Rows[0][4].ToString();
                this.Usu_MailBD = dt.Rows[0][4].ToString();
                txt_Usuario_Telefono.Text = dt.Rows[0][5].ToString();
                txt_Usuario_Direccion.Text = dt.Rows[0][6].ToString();
                dtp_Usuario_FechaNacimiento.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
                estadoDatosUsuario = true;
            }
            else
            {
                MessageBox.Show("No se han cargado los datos personales del usuario seleccionado.");
                estadoDatosUsuario = false;
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
            this.Usu_UserNameBD = null;
            cb_Rol.SelectedIndex = 0;
            lb_roles.Items.Clear();
            this.Usu_RolesBD.Clear();
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
            dtp_Usuario_FechaNacimiento.Value = DateTime.Today;
            this.Usu_MailBD = null;
            this.Usu_NroDocumentoBD = null;
            this.Usu_TipoDocumentoBD = null;
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

        private void btn_NuevaContrasenia_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.NuevaContrasenia newContr = FrbaHotel.ABM_de_Usuario.NuevaContrasenia.ObtenerInstancia(txt_Username.Text);
            newContr.Show();
        }

        private void btn_TodosRolesHoteles_Click(object sender, EventArgs e)
        {
            string estadoUsuario;
            if (this.Usu_EstadoBD == 1)
            {
                estadoUsuario = "True";
            }else
	        {
                estadoUsuario = "False";
	        }

            ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario ventanaRolesHotelesDeUsuario = ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario.ObtenerInstancia(Usu_UserNameBD, estadoUsuario);
            ventanaRolesHotelesDeUsuario.Show();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int Usu_EstadoNuevo;
            Dominio.Usuario usu1 = new Dominio.Usuario();
            //List<Int32> copy = new List<Int32>(original);
            List<string> listaRolesAnterior = new List<string>(Usu_RolesBD);
            List<string> listaRolesNuevos = armarListaRolesSeleccionados();
            List<string> listaRolesParaAgregar = new List<string>();
            List<string> listaRolesParaEliminar = new List<string>(Usu_RolesBD);
            bool estadoModificaciones = true;

            if (cb_EstadoUsuario.SelectedIndex == 0)
	        {
        		Usu_EstadoNuevo = 1;
	        }
            else
	        {
                Usu_EstadoNuevo = 0;
	        }

            if (Usu_UserNameBD != txt_Username.Text)
            {
                if (usu1.verificarNombreDeUsuarioValido(txt_Username.Text))
                {
                    if (usu1.ModificarDatosUsuarioEnTablaUsuarios(txt_Username.Text, Usu_UserNameBD, Usu_EstadoNuevo) == false)
                    {
                        MessageBox.Show("Error al guardar el nombre de usuario y el estado.");
                        estadoModificaciones = false;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado no se encuentra disponible");
                    estadoModificaciones = false;
                }
            }
            else
            {
                if (Usu_EstadoNuevo != Usu_EstadoBD)
                {
                    if (usu1.ModificarEstadoEnTablaUsuario(txt_Username.Text, Usu_EstadoNuevo) == false)
                    {
                        MessageBox.Show("Error al cambiar el estado del usuario");
                        estadoModificaciones = false;
                    } 
                }
            }
            if (estadoModificaciones)
            {
                //Roles Agregados
                foreach (var itemRol in listaRolesNuevos)
                {
                    if (!listaRolesAnterior.Contains(itemRol))
                    {
                        listaRolesParaAgregar.Add(itemRol);
                    }
                }

                //Roles Eliminardos
                foreach (var itemRol in listaRolesAnterior)
                {
                    if (listaRolesNuevos.Contains(itemRol))
                    {
                        listaRolesParaEliminar.RemoveAt(listaRolesParaEliminar.IndexOf(itemRol));
                    }
                }

                if ((usu1.InsertarRolesAlUsuario(txt_Username.Text, listaRolesParaAgregar) && usu1.QuitarRolesAlUsuario(txt_Username.Text, listaRolesParaEliminar)) == false)
                {
                    MessageBox.Show("Error al guardar las modificaciones");
                    estadoModificaciones = false;
                }                
            }
            if (estadoModificaciones)
            {
                if (this.Usu_MailBD != txt_Usuario_Mail.Text)
                {
                    if (!usu1.verificarMailValido(txt_Usuario_Mail.Text))
                    {
                        MessageBox.Show("Ya existe un usuario con el mail ingresado");
                        estadoModificaciones = false;
                    }
                }
            }

            if (estadoModificaciones)
            {
                if (this.Usu_NroDocumentoBD != Convert.ToInt64(txt_Usuario_NroDocumento.Text) || this.Usu_TipoDocumentoBD != cb_Usuario_TipoDocumento.SelectedItem.ToString())
                {
                    if (!usu1.verificarTipoYNumeroDocumentoValido(cb_Usuario_TipoDocumento.SelectedItem.ToString(), txt_Usuario_NroDocumento.Text))
                    {
                        MessageBox.Show("Ya existe un usuario con el tipo y número de documento ingresado");
                        estadoModificaciones = false;
                    }
                }
            }
            if (estadoModificaciones)
            {
                if (estadoDatosUsuario == true)
                {
                    if (!usu1.ModificarDatosEnTablaEmpleados(txt_Usuario_Nombre.Text, txt_Usuario_Apellido.Text, cb_Usuario_TipoDocumento.SelectedItem.ToString(), txt_Usuario_NroDocumento.Text, txt_Usuario_Mail.Text, txt_Usuario_Telefono.Text, txt_Usuario_Direccion.Text, dtp_Usuario_FechaNacimiento.Value, txt_Username.Text))
                    {
                        MessageBox.Show("Error en la modificación de datos del Usuario");
                        estadoModificaciones = false;
                    }
                }
                else
                {
                    if (!usu1.InsertarDatosEnTablaEmpleados(txt_Usuario_Nombre.Text, txt_Usuario_Apellido.Text, cb_Usuario_TipoDocumento.SelectedItem.ToString(), txt_Usuario_NroDocumento.Text, txt_Usuario_Mail.Text, txt_Usuario_Telefono.Text, txt_Usuario_Direccion.Text, dtp_Usuario_FechaNacimiento.Value.ToString("yyyy-MM-dd"), txt_Username.Text))
                    {
                        MessageBox.Show("Error al guardar de datos del Usuario");
                        estadoModificaciones = false;
                    }
                }
            }

            if (estadoModificaciones)
            {
                MessageBox.Show("Se han guardado los cambios correctamente");
                this.Hide();
                ABM_de_Usuario.Usuarios newUsu = ABM_de_Usuario.Usuarios.ObtenerInstancia();
                newUsu.BuscarUsuarios();
                newUsu.Show();
                this.Close();
            }

        }

        private List<string> armarListaRolesSeleccionados()
        {
            List<string> listaRolesSeleccionados = new List<string>();
            listaRolesSeleccionados = this.lb_roles.Items.Cast<string>().ToList();
            return listaRolesSeleccionados;
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

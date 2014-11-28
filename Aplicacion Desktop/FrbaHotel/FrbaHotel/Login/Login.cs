using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Buscar Nombre de usuario en la tabla de Usuarios, y obtener el password.
            //Selección del hotel, si trabaja en más de uno. Idem rol

            //Dominio.Usuario usu1 = new Dominio.Usuario();
            
            //Dominio.UsuarioLogin usu1 = new Dominio.UsuarioLogin();
            bool valorRe = Dominio.UsuarioLogin.TheInstance.buscarUsuarioContrasenia(txt_nombreUsuario.Text, txt_passwordUsuario.Text);
            if (valorRe)
            {
                //Usuario y contraseña válidos
                Dominio.UsuarioLogin.TheInstance.setUsu_Username(txt_nombreUsuario.Text);

                List<Dominio.HotelRolLista> lHotelRol = Dominio.UsuarioLogin.TheInstance.BuscarHotelRol();

                if (lHotelRol.Count == 0)
                {
                    MessageBox.Show("Su usuario no tiene acceso a ningún hotel ni rol. Comuníquese con el administrador.");
                }
                else if (lHotelRol.Count == 1)
                {
                    //Usuario con permiso para acceder con un sólo rol y hotel
                    foreach (var iHotelRol in lHotelRol)
                    {
                        Dominio.UsuarioLogin.TheInstance.setearHotelRol(iHotelRol.nombreHotel, iHotelRol.idHotel, iHotelRol.rol);

                        PantallaPrincipal pantPrinc = new PantallaPrincipal();
                        pantPrinc.Show(this);
                        this.Hide();
                    }

                }
                else
                {                                       
                    //Más de un hotel y/o rol
                    LoginHotelRol loginHotelRol = new LoginHotelRol(lHotelRol);
                    loginHotelRol.Show(this);
                    this.Hide();
                }
            }
            else
	        {
               //Usuario y contraseña inválidos
                MessageBox.Show("Usuario y contraseña inválidos");
	        }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Pantalla GUEST
            Dominio.UsuarioLogin.TheInstance.setRol("Guest");
            PantallaPrincipal pantPrinc = new PantallaPrincipal();
            pantPrinc.Show(this);
            
        }

        private bool verificarUsuarioContr(string usuario, string contrasenia) 
        {            
            return true;
        }
    }
}

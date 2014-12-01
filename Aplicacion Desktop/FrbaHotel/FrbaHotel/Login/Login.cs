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
        private static Login _instancia;

        public static Login ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Login();
            }
            _instancia.BringToFront();
            return _instancia;
        }
       
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            bool valorRe = Dominio.UsuarioLogin.TheInstance.buscarUsuarioContrasenia(txt_nombreUsuario.Text, txt_passwordUsuario.Text);
            if (valorRe)
            {
                //Usuario y contraseña válidos
                Dominio.UsuarioLogin.TheInstance.setUsuario(txt_nombreUsuario.Text);

                List<Dominio.HotelRolLista> lHotelRol = Dominio.UsuarioLogin.TheInstance.BuscarHotelRol();

                if (lHotelRol.Count == 0)
                {
                    MessageBox.Show("Su usuario no tiene acceso a ningún hotel ni rol. Comuníquese con el administrador.");
                }
                else if (lHotelRol.Count == 1)
                {
                    //Usuario con permiso para acceder con un sólo rol y hotel
                    if (Dominio.UsuarioLogin.TheInstance.BuscarEstadoDelRol(lHotelRol[0].rol))
                    {
                        Dominio.UsuarioLogin.TheInstance.setearHotelRol(lHotelRol[0].nombreHotel, lHotelRol[0].idHotel, lHotelRol[0].rol);
                        PantallaPrincipal pantPrinc = new PantallaPrincipal();
                        pantPrinc.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El Rol con el que se quiere ingresar se encuentra Inactivo.");
                    }

                }
                else
                {                                       
                    //Más de un hotel y/o rol
                    LoginHotelRol loginHotelRol = LoginHotelRol.ObtenerInstancia(lHotelRol);
                    loginHotelRol.Show(this);
                    this.Hide();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            
            //Pantalla GUEST
            if (Dominio.UsuarioLogin.TheInstance.BuscarEstadoDelRol("Guest"))
            {                Dominio.UsuarioLogin.TheInstance.setRol("Guest");
                PantallaPrincipal pantPrinc = new PantallaPrincipal();
                pantPrinc.Show(this);
                this.Hide();
            } 
            else
	        {
                MessageBox.Show("El Rol Guest con el que se quiere ingresar se encuentra Inactivo.");
	        }   
            
            
        }

        private bool verificarUsuarioContr(string usuario, string contrasenia) 
        {            
            return true;
        }
    }
}

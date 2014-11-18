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
            //Comparar y Loguear
            //Selección del hotel, si trabaja en más de uno.
            //Generar MenuStrip para la pantalla inicial según el rol del usuario
            //PantallaPrincipal pantPrinc;

            Dominio.Usuario usu1 = new Dominio.Usuario(txt_nombreUsuario.Text,txt_passwordUsuario.Text);
            bool valorRe = usu1.buscarUsuarioContrasenia();
            if (valorRe )
            {
                if (usu1.Usu_Rol_Id == "Administrador")
	            {
                    this.Hide();
                    //Pantalla Administrador
                    PantallaPrincipal pantPrinc = new PantallaPrincipal("administrador");
                    pantPrinc.Show(this);
                }
                else if (usu1.Usu_Rol_Id == "Recepcionista")
                {
                    this.Hide();
                    //Pantalla Recepcionista
                    //recepcionista -> usuario: recepcion, contraseña recepcion
                    PantallaPrincipal pantPrinc = new PantallaPrincipal("recepcionista");
                    pantPrinc.Show(this);
                }
                
            }
            else
	        {
               MessageBox.Show("ERROR!!!");
	        }


            //if (txt_nombreUsuario.Text == "admin" && hashContr == "e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7")
            //{
            //    this.Hide();
            //    //Pantalla Administrador
            //    pantPrinc = new PantallaPrincipal("administrador");
            //    pantPrinc.Show(this);
            //}
            //else if (txt_nombreUsuario.Text == "recepcionista" && hashContr == "bd2f76155a54ecf99bd3efd53dfbadf54d7b0ecd7b99f989449dfb817c0bb744")
            //{
            //    this.Hide(); 
            //    //Pantalla Recepcionista
            //    //recepcionista -> usuario: recepcionista, contraseña recepcionista
            //    pantPrinc = new PantallaPrincipal("recepcionista");
            //    pantPrinc.Show(this);
            //}
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Pantalla GUEST
            PantallaPrincipal pantPrinc = new PantallaPrincipal("usuario");
            pantPrinc.Show(this);
            
        }

        private bool verificarUsuarioContr(string usuario, string contrasenia) 
        {
            
            return true;
        }
    }
}

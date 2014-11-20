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

            Dominio.Usuario usu1 = new Dominio.Usuario();
            bool valorRe = usu1.buscarUsuarioContrasenia(txt_nombreUsuario.Text, txt_passwordUsuario.Text);
            if (valorRe)
            {
                //Usuario y contraseña válidos
                usu1.setUsu_Username(txt_nombreUsuario.Text);


                
                
                
                List<Dominio.HotelRolLista> lHotelRol = usu1.BuscarHotelRol();

                //Si lHotelRol
                    //- es NULO -> Mensaje de error : Su usuario no tiene acceso a ningún hotel ni rol. Comuníquese con el administrador.
                    //- si me trae algo. 
                        //-IF contar cuantos me trajo
                            //- Si me trae uno solo -> Setear el hotel y el rol al que se loguea. 
                            //                         Crear la pantalla para ese usuario y mostrarlo
                            //- Si me trae más de uno -> Armar la coleccion

                if (lHotelRol.Count == 0)
                {
                    MessageBox.Show("Su usuario no tiene acceso a ningún hotel ni rol. Comuníquese con el administrador.");
                }
                else if (lHotelRol.Count == 1)
                {
                    foreach (var iHotelRol in lHotelRol)
                    {
                        usu1.setearHotelRol(iHotelRol.nombreHotel,iHotelRol.idHotel, iHotelRol.rol);

                        this.Hide();
                        PantallaPrincipal pantPrinc = new PantallaPrincipal(usu1.getRol());
                        pantPrinc.Show(this);
                    }

                }
                else
                {
                    this.Hide();
                    LoginHotelRol loginHotelRol = new LoginHotelRol(lHotelRol);
                    loginHotelRol.Show(this);
                }


                //if (usu1.Usu_Rol_Id == "Administrador")
                //{
                //    this.Hide();
                //    //Pantalla Administrador
                //    PantallaPrincipal pantPrinc = new PantallaPrincipal("administrador");
                //    pantPrinc.Show(this);
                //}
                //else if (usu1.Usu_Rol_Id == "Recepcionista")
                //{
                //    this.Hide();
                //    //Pantalla Recepcionista
                //    //recepcionista -> usuario: recepcion, contraseña recepcion
                //    PantallaPrincipal pantPrinc = new PantallaPrincipal("recepcionista");
                //    pantPrinc.Show(this);
                //}

            }
            else
	        {
               //Usuario y contraseña inválidos
               MessageBox.Show("ERROR!!!");
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
            PantallaPrincipal pantPrinc = new PantallaPrincipal("usuario");
            pantPrinc.Show(this);
            
        }

        private bool verificarUsuarioContr(string usuario, string contrasenia) 
        {            
            return true;
        }
    }
}

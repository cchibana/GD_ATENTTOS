using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaHotel.Dominio
{
    class Usuario
    {
        public string Usu_Username;
        public string Usu_Password;
        public string Usu_Rol_Id;
        public bool Usu_Estado;

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public string cifrarContrasenia(string contrasenia) 
        {
            //Cifrado de la contraseña
            Contrasenia.encriptarContrasenia contraseniaUsr = new Contrasenia.encriptarContrasenia();
            string hashContr = contraseniaUsr.hash(contrasenia);

            return hashContr;
        }

        public string buscarUsuarioContrasenia(string usuario)
        {
            return "";
        }

        
    }
}

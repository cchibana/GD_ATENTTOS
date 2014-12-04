using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Dominio
{
    class ContraseniaUsuarioLogueado : CDatos
    {
        public string cifrarContrasenia(string contrasenia)
        {
            //Cifrado de la contraseña
            Contrasenia.encriptarContrasenia contraseniaUsr = new Contrasenia.encriptarContrasenia();
            string hashContr = contraseniaUsr.hash(contrasenia);

            return hashContr;
        }
        
        internal bool VerificarContraseniaDeUsuarioLogueado(string nombreUsuario, string contrasenia)
        {
            string passHASH = cifrarContrasenia(contrasenia);
            string textoSQL = "SELECT  Usu_Password FROM  ATENTTOS.Usuarios WHERE Usu_Username = '" + nombreUsuario + "'";
            DataTable dt = EjecutarConsulta(textoSQL);
            if (dt.Rows[0][0].ToString() == passHASH)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        internal bool ModificarContraseniaDelUsuario(string nombreUsuario, string contraseniaNueva)
        {
            string passHASH = cifrarContrasenia(contraseniaNueva);
            string textoSQL = "UPDATE ATENTTOS.Usuarios SET Usu_Password = '" + passHASH + "' WHERE Usu_Username = '" + nombreUsuario + "'";
            try
            {
                EjecutarComando(textoSQL);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}

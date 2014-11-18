using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;

using System.Windows.Forms;


namespace FrbaHotel.Dominio
{
    class Usuario : CDatos
    {
        public string Usu_Username;
        public string Usu_Password;
        public string Usu_Rol_Id;
        public bool Usu_Estado;

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public Usuario(string usu_username, string usu_password) {
            this.Usu_Username = usu_username;
            this.Usu_Password = usu_password;
        }

        public string cifrarContrasenia(string contrasenia) 
        {
            //Cifrado de la contraseña
            Contrasenia.encriptarContrasenia contraseniaUsr = new Contrasenia.encriptarContrasenia();
            string hashContr = contraseniaUsr.hash(contrasenia);

            return hashContr;
        }

        public bool buscarUsuarioContrasenia()
        {
            string passHASH = cifrarContrasenia(Usu_Password);
            string textoSQL = "SELECT Usu_Username, Usu_Password, Usu_Rol_Id, Usu_Estado FROM  ATENTTOS.Usuarios WHERE Usu_Username = '" + Usu_Username + "' AND Usu_Password = '" + passHASH + "'";

            DataTable dt = EjecutarConsulta(textoSQL);
            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas == 1)
            {
                MostrarDatoLogin(dt);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string MostrarDatoLogin(DataTable dt) 
        {
            int numColumnas;
            string nombreCampo = "";
            string campo = "";

            numColumnas = dt.Columns.Count;

            ////Iteramos por cada fila y cada columna
            //for (int fila = 0; fila  < dt.Rows.Count; fila++)
            //{
            //    for (int col = 0; col  < numColumnas; col++)
            //    {
            //        if(!dt.Rows[fila].IsNull(col))
            //        {
            //            //Almacenamos el nombre del campo y su contenido
            //            campo = dt.Rows[fila][col].ToString();
            //            nombreCampo = dt.Columns[col].ColumnName;
            //        }
            //        if (campo != null)
            //         {
            //            return nombreCampo + ":   " + campo.ToString();
            //         }
            //   }
                
            //}
            if (!dt.Rows[0].IsNull(0))
            {
                this.Usu_Rol_Id = dt.Rows[0][2].ToString();
                this.Usu_Estado = Convert.ToBoolean(dt.Rows[0][3].ToString());
            }
            return null;
        }

        
    }
}
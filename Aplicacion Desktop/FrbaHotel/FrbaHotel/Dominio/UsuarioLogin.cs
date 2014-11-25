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
    public class UsuarioLogin : CDatos
    {

        protected string Usu_Username;
        protected string Usu_Hotel_Nombre;
        protected int Usu_Hotel_Id;
        protected string Usu_Rol_Id;

        //Parametros para SP
        private Parametros[] parametrosSP;

        public void setUsuario(string usu_username) {
            this.Usu_Username = usu_username;
        }

        public string cifrarContrasenia(string contrasenia) 
        {
            //Cifrado de la contraseña
            Contrasenia.encriptarContrasenia contraseniaUsr = new Contrasenia.encriptarContrasenia();
            string hashContr = contraseniaUsr.hash(contrasenia);

            return hashContr;
        }

        public bool buscarUsuarioContrasenia(string nombreUsuarioIngresado, string contraseniaIngresada)
        {
            string passHASH = cifrarContrasenia(contraseniaIngresada);
            string textoSQL = "SELECT Usu_Username, Usu_Password, Usu_Rol_Id, Usu_Estado FROM  ATENTTOS.Usuarios WHERE Usu_Username = '" + nombreUsuarioIngresado + "' AND Usu_Password = '" + passHASH + "'";

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
            numColumnas = dt.Columns.Count;

            if (!dt.Rows[0].IsNull(0))
            {
                this.Usu_Rol_Id = dt.Rows[0][2].ToString();
                //this.Usu_Estado = Convert.ToBoolean(dt.Rows[0][3].ToString());
            }
            return null;
        }



        public List<HotelRolLista> BuscarHotelRol()
        {
            //1 - Ejecuto el SP para traer el listado de hotel y rol de un usuario
            //2 - IF 
                    //- no me devuelve Ningun dato -> return null;
                    //- Si me trae algo -> armo la lista y lo retorno


            /*
            string textoSQL = "SELECT Usu_Username, Usu_Password, Usu_Rol_Id, Usu_Estado FROM  ATENTTO'";
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
            */
            var lHotelRol = new List<HotelRolLista>();

            parametrosSP = new Parametros[1];//1 por la cantidad de parámetros que ingreso
            parametrosSP[0] = new Parametros("@username", Usu_Username);

            DataTable dt = EjecutarStoreProcedure("dbo.SP_RolesYHoteles", parametrosSP);
           
            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas > 0)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    lHotelRol.Add(new HotelRolLista
                    {
                        nombreHotel = dt.Rows[i][2].ToString(),
                        idHotel = Convert.ToInt32(dt.Rows[i][1].ToString()),
                        rol = dt.Rows[i][0].ToString()
                    });
                }
            }

            return lHotelRol;
        }

        /* GET Y SET */

        public void setUsu_Username(string nombreUsuario) 
        {
            this.Usu_Username = nombreUsuario;
        }

        public string getRol()
        {
            return this.Usu_Rol_Id;
        }

        public void setearHotelRol(string hotelNombre, int hotelId, string rolUsu)
        {
            this.Usu_Hotel_Nombre = hotelNombre;
            this.Usu_Hotel_Id = hotelId;
            this.Usu_Rol_Id = rolUsu;
        }

    }

    public class HotelRolLista
    {
        public string nombreHotel;
        public int idHotel;
        public string rol;

    }
}
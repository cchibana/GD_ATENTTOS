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
    public sealed class UsuarioLogin : CDatos
    {

        private string Usu_Username;
        private string Usu_Hotel_Nombre;
        private int Usu_Hotel_Id;
        private string Usu_Rol_Id;


        //Parametros para SP
        private Parametros[] parametrosSP;

        //Singleton
        private static volatile UsuarioLogin theInstance = null;
        private static readonly object padlock = new object();
        UsuarioLogin() { }

        public static UsuarioLogin TheInstance 
        {
            get
            {
                if (theInstance == null)
                {
                    lock (padlock)
                    {
                        if (theInstance == null)
                            theInstance = new UsuarioLogin();
                    }
                }
                return theInstance;
            }
        }

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
            }
            return null;
        }

        public List<HotelRolLista> BuscarHotelRol()
        {
            var lHotelRol = new List<HotelRolLista>();

            parametrosSP = new Parametros[1];//1 por la cantidad de parámetros que ingreso
            parametrosSP[0] = new Parametros("@username", Usu_Username); //0 porque un vector empieza en la posición 0

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


        public List<int> BuscarFuncionalidades()
        {

            var listaIDFuncionalidades = new List<int>();

            parametrosSP = new Parametros[1]; //Pongo uno entre corchetes porque busco por un sólo parámetro
            parametrosSP[0] = new Parametros("@rol", this.Usu_Rol_Id); //El vector empieza en la posición 0.
            
            DataTable dt = EjecutarStoreProcedure("dbo.SP_FuncionalidadesPorRol", parametrosSP);

            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas > 0)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    listaIDFuncionalidades.Add(Convert.ToInt32(dt.Rows[i][0].ToString()));
                }
            }

            return listaIDFuncionalidades;
        }




        //public List<int>

        /* GET Y SET */

        public void setUsu_Username(string nombreUsuario) 
        {
            this.Usu_Username = nombreUsuario;
        }

        public string getRol()
        {
            return this.Usu_Rol_Id;
        }

        public void setRol(string rol) 
        {
            this.Usu_Rol_Id = rol;
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
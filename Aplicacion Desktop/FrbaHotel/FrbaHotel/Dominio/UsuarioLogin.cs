﻿using System;
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
            string textoSQL = "SELECT Usu_Username, Usu_Password, Usu_Estado, Usu_CantIntentosFallidos FROM  ATENTTOS.Usuarios WHERE Usu_Username = '" + nombreUsuarioIngresado + "'";

            DataTable dt = EjecutarConsulta(textoSQL);
            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas == 1)
            {
                string Usu_Username = dt.Rows[0][0].ToString();
                string Usu_Password = dt.Rows[0][1].ToString();
                bool Usu_Estado = Convert.ToBoolean(dt.Rows[0][2].ToString());
                int Usu_CantIntentosFallidos = Convert.ToInt32(dt.Rows[0][3].ToString());
                if (Usu_Estado == true)
                {
                    if (Usu_Password == passHASH)
                    {
                        string textoSQL2 = "UPDATE [GD2C2014].[ATENTTOS].[Usuarios] SET Usu_CantIntentosFallidos = 0 WHERE Usu_Username = '" + Usu_Username + "'";
                        EjecutarComando(textoSQL2);
                        //string mensajePRUEBA = EjecutarComando(textoSQL2);
                        //MessageBox.Show(mensajePRUEBA);
                        return true;
                    }
                    else
                    {
                        Usu_CantIntentosFallidos++;
                        //No coincide el password
                        string textoSQL2 = "UPDATE [GD2C2014].[ATENTTOS].[Usuarios] SET Usu_CantIntentosFallidos = " + Usu_CantIntentosFallidos + " WHERE Usu_Username = '" + Usu_Username + "'";
                        DataTable dt2 = EjecutarConsulta(textoSQL2);
                        MessageBox.Show("Contraseña Inválida");
                        if (Usu_CantIntentosFallidos == 3)
                        {
                            textoSQL2 = "UPDATE [GD2C2014].[ATENTTOS].[Usuarios] SET Usu_Estado = 'false' WHERE Usu_Username = '" + Usu_Username + "'";
                            dt2 = EjecutarConsulta(textoSQL2);
                            MessageBox.Show("Su usuario ha sido inhabilitado por llegar a los 3 intentos fallidos. Comuníquese con el administrador.");
                        }
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Su usuario se encuentra inhabilitado. Comuníquese con el administrador.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario inválido");
                return false;
            }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FrbaHotel.Dominio
{
    public class CDatos
    {
        //Aquí esta la cadena de conexión a SqlServer, dependiendo de tu proyecto, esto debes cambiarlo
        //normalmente se cambia el nombre del servidor y el nombre de la base de datos

        private string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        public string getCadenaDeConexion() 
        {
            return this.cadenaDeConexion;
        }

        public bool EjecutarComando(string textoSql)
        {
            try
            {
                //Para la cadena de conexión
                string sCnn = cadenaDeConexion;
                //Creamos la conexión
                SqlConnection cnn = new SqlConnection(sCnn);
                //Texto del comando insert
                string iTexto = textoSql;
                //Creamos el comando con su texto y conexión
                SqlCommand cmd = new SqlCommand(iTexto, cnn);
                cmd.CommandType = CommandType.Text;
                //abrimos la conexión y ejecutamos el comando
                cnn.Open();
                //Ejecutamos el comando sql
                cmd.ExecuteNonQuery();
                //Cerramos la conexión
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable EjecutarConsulta(string textoSQL)
        {
            //Creamos la cadena de conexion
            string sCnn = cadenaDeConexion;
            //Creamos el comando de sql para listar
            string sSel = textoSQL;
            //Creamos el adaptador que capturara los datos
            SqlDataAdapter da = new SqlDataAdapter(sSel, sCnn);
            //Creamos un data table que contendra los datos
            DataTable dt = new DataTable();
            //Llenamos el data table con el adaptador
            da.Fill(dt);
            //Colocando datos al datagridview dgvNacionalidad
            return dt;
        }

        public DataTable EjecutarStoreProcedure(string nombreSP, Dominio.Parametros[] datos)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand(nombreSP,connection);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < datos.Length; i++)
			{
                cmd.Parameters.AddWithValue(datos[i].Nombre, datos[i].Valor);
			}
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool EjecutarStoreProcedureSinDataTable(string nombreSP, Dominio.Parametros[] datos)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand(nombreSP, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < datos.Length; i++)
            {
                cmd.Parameters.AddWithValue(datos[i].Nombre, datos[i].Valor);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            try{
                da.Fill(dt);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}

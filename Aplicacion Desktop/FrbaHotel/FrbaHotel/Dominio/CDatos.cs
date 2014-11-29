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
        //string cadenaDeConexion = @"Data Source=(local)\SQLSERVER2008;Initial Catalog=GD2C2014";
        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

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
    }
}

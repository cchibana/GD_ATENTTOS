using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Dominio
{
    public class CDatos
    {
        //Aquí esta la cadena de conexión a SqlServer, dependiendo de tu proyecto, esto debes cambiarlo
        //normalmente se cambia el nombre del servidor y el nombre de la base de datos
        string cadenaDeConexion = @"Data Source=(local)\SQLSERVER2008;Initial Catalog=GD2C2014;Integrated Security=True";

        public DataTable EjecutarConsulta(string textoSQL)
        {
            //Creamos la cadena de conexion
            string sCnn = cadenaDeConexion;
            //Creamo el comando de sql para listar
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



    }
}

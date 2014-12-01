using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace FrbaHotel.Dominio
{
    class Usuario : CDatos
    {
        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarUsuarios(string nombreUsuario, string estadoUsuario)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("dbo.SP_UsuariosBusqueda", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            }
            if (!string.IsNullOrEmpty(estadoUsuario))
            {
                cmd.Parameters.AddWithValue("@estadoUsuario", estadoUsuario.ToString());
            }
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

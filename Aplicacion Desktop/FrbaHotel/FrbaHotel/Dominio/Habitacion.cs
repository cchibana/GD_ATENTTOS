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
    class Habitacion : CDatos
    {
        string estado;


        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarHabitaciones(string hotelHab, string numeroHab, string pisoHab, string descripcion, string ubicacion, string tipoHab)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_BuscarHabitaciones", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(hotelHab))
            {
                cmd.Parameters.AddWithValue("@hotelHab", hotelHab);
            }
            if (!string.IsNullOrEmpty(numeroHab))
            {
                cmd.Parameters.AddWithValue("@numeroHab", numeroHab);
            }
            if (!string.IsNullOrEmpty(pisoHab))
            {
                cmd.Parameters.AddWithValue("@pisoHab", pisoHab);
            }
            if (!string.IsNullOrEmpty(descripcion))
            {
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
            }
            if (!string.IsNullOrEmpty(ubicacion))
            {
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion.ToString());
            }
            if (!string.IsNullOrEmpty(tipoHab))
            {
                cmd.Parameters.AddWithValue("@tipoHab", tipoHab.ToString());
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarUbicaciones()
        {
            string texto = "select distinct[Hab_Ubicacion] from [GD2C2014].[ATENTTOS].[Habitaciones];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarTiposHab()
        {
            string texto = "select distinct[Hab_Tipo_Habitacion] from [GD2C2014].[ATENTTOS].[Habitaciones];";
            return EjecutarConsulta(texto);
        }
        
        public DataTable RecuperaDescripHab(string tipoHab)
        {
            string texto = "select [Hab_Descripcion] from [GD2C2014].[ATENTTOS].[Habitaciones] where [Hab_Tipo_Habitacion] =" + tipoHab + ";";
            return EjecutarConsulta(texto);
        }

        public DataTable RecuperaPorcentualHab(string tipoHab)
        {
            string texto = "select [Hab_Tipo_Porcentual] from [GD2C2014].[ATENTTOS].[Habitaciones] where [Hab_Tipo_Habitacion] =" + tipoHab + ";";
            return EjecutarConsulta(texto);
        }

        internal bool verificarNroHAbitacionValido(string numeroHab)
        {
            //Si el número de habitación Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Habitaciones h WHERE h.Hab_Numero = '" + numeroHab + "') THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool InsertarDatosEnTablaHabitaciones(string hotelHab, string numeroHab, string pisoHab, string ubicacionHab, string tipoHab, string descHab, string estadoHab)
        {
            string textoSQL = @"INSERT INTO ATENTTOS.Habitaciones (Hab_Hot_Codigo, Hab_Numero, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion, Hab_Descripcion, Hab_Estado)" +
                               "VALUES(" +hotelHab+ ", " + numeroHab + ", " + pisoHab + ", '" + ubicacionHab + "', " + tipoHab + ", '"+ descHab + "',1)";
            try
            {
                EjecutarComando(textoSQL);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public bool CambiarEstadoHabitacion(string hotelHab, string numeroHab, int estadoHab)
        {
            string textoSQL = "UPDATE ATENTTOS.Habitaciones SET Hab_Estado = " + estadoHab + " WHERE Hab_Numero = " + numeroHab + " and Hab_Hot_Codigo = " + hotelHab + ";";
            try
            {
                EjecutarComando(textoSQL);
            }
            catch
            {
                return false;
            }
            return true;
        }


        internal bool ModificarDatosHabitaciones(string hotelHab, string numeroHab, string pisoHab, string ubicacionHab, string estadoHab)
        {
            if (estadoHab == "Disponible")
            {
                estado = "True";
            }
            else
            {
                estado = "False";
            }

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_ModificarDatosHabitaciones", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Hab_Hotel", hotelHab);
            cmd.Parameters.AddWithValue("@Hab_Numero", numeroHab);
            cmd.Parameters.AddWithValue("@Hab_Piso", pisoHab);
            cmd.Parameters.AddWithValue("@Hab_Ubicacion", ubicacionHab);            
            cmd.Parameters.AddWithValue("@Hab_Estado", estado);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
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

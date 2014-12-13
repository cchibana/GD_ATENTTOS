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
    class Estadia: CDatos
    {

        internal bool verificaReservaCod(string nroReserva)
        {
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Estadias WHERE Est_Res_Codigo = '" + nroReserva + "')	THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }
        
        internal bool RegistrarEnTablaEstadias(string nroReserva, string cantNoches, string usuCheckIn)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("[ATENTTOS].[SP_InsertarEstadias]", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@codReserva", SqlDbType.BigInt);
            cmd.Parameters["@codReserva"].Value = Convert.ToInt64(nroReserva);

            cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
            cmd.Parameters["@fechaInicio"].Value = UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss");

            cmd.Parameters.Add("@cantNoches", SqlDbType.BigInt);
            cmd.Parameters["@cantNoches"].Value = Convert.ToInt64(cantNoches);

            cmd.Parameters.Add("@usuGeneradorCheckIn", SqlDbType.NVarChar);
            cmd.Parameters["@usuGeneradorCheckIn"].Value = usuCheckIn;

            cmd.Parameters.Add("@fechaCheckOut", SqlDbType.DateTime);
            cmd.Parameters["@fechaCheckOut"].Value = null;

            cmd.Parameters.Add("@usuGeneradorCheckOut", SqlDbType.NVarChar);
            cmd.Parameters["@usuGeneradorCheckOut"].Value = null;     

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

        internal bool CambiarEstadoReserva(string nroReserva)
        {
            string textoSQL = "UPDATE ATENTTOS.Reservas SET Res_Estado = 6 WHERE Res_Codigo = " + nroReserva + ";";
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
    }
}

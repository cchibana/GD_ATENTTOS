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
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Estadias WHERE Est_Res_Codigo = " + nroReserva + ")	THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal DataTable ObtenerDatosResEfectiva(string nroReserva)
        {
            string textoSQL = "SELECT c.Ciu_Detalle, h.Hot_Nombre, h.Hot_Codigo, r.Res_Fecha_Inicio, DATEADD(DAY, r.Res_Cant_Noches, r.Res_Fecha_Inicio) AS FechaFin, r.Res_Tipo_Regimen, re.Reg_Descripcion FROM  ATENTTOS.Reservas r, ATENTTOS.Ciudades c, ATENTTOS.Hoteles h, ATENTTOS.Regimenes re WHERE c.Ciu_Id = h.Hot_Ciu_Id AND  r.Res_Hot_codigo = h.Hot_Codigo AND r.Res_Tipo_Regimen = re.Reg_Codigo AND r.Res_Codigo = " + nroReserva + " AND (r.Res_Estado = 6)";
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ObtenerIdEstadia(string nroReserva)
        {
            string textoSQL = "SELECT Est_Id FROM  ATENTTOS.Estadias WHERE Est_Res_Codigo = " + nroReserva + ";";
            return EjecutarConsulta(textoSQL);
        }
        
        internal bool RegistrarEstadiaCheckIn(string nroReserva, DateTime fechaInicio, string cantNoches, string usuCheckIn)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("[ATENTTOS].[SP_InsertarEstadias]", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@codReserva", SqlDbType.BigInt);
            cmd.Parameters["@codReserva"].Value = Convert.ToInt64(nroReserva);

            cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
            cmd.Parameters["@fechaInicio"].Value = fechaInicio;

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

        internal bool ActualizarEstadiaCheckOut(string nroReserva, DateTime fechaCheckOut, int cantNochesReal, string usuCheckOut)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("[ATENTTOS].[SP_ModificarEstadias]", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@codReserva", SqlDbType.BigInt);
            cmd.Parameters["@codReserva"].Value = Convert.ToInt64(nroReserva);

            cmd.Parameters.Add("@fechaCheckOut", SqlDbType.DateTime);
            cmd.Parameters["@fechaCheckOut"].Value = fechaCheckOut;

            cmd.Parameters.Add("@cantNochesReales", SqlDbType.BigInt);
            cmd.Parameters["@cantNochesReales"].Value = Convert.ToInt64(cantNochesReal);                    

            cmd.Parameters.Add("@usuGeneradorCheckOut", SqlDbType.NVarChar);
            cmd.Parameters["@usuGeneradorCheckOut"].Value = usuCheckOut;

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

        
        internal int CantHuespedesPorRes(string codReserva)
        {
            string textoSQL = @"SELECT SUM( CASE WHEN h.Hab_Tipo_Habitacion = '1001' THEN 1 WHEN h.Hab_Tipo_Habitacion = '1002' THEN 2 WHEN h.Hab_Tipo_Habitacion = '1003' THEN 3 WHEN h.Hab_Tipo_Habitacion = '1004' THEN 4 WHEN h.Hab_Tipo_Habitacion = '1005' THEN 5 END ) AS 'CapacidadHuespedes'
                                  FROM ATENTTOS.Habitaciones_Por_Reserva hxr, ATENTTOS.Habitaciones h WHERE h.Hab_Numero = hxr.HxR_Hab_Nro AND hxr.HxR_Hot_Codigo = h.Hab_Hot_Codigo and hxr.HxR_Res_Codigo = " +codReserva+ ";";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        



     
        
    }
}

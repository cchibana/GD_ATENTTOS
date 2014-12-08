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
    class Reserva : CDatos
    {
        //Parametros para SP
        private Parametros[] parametrosSP;

        public DataTable ListarCiudades()
        {
            string textoSQL = "SELECT Ciu_Id, Ciu_Detalle FROM ATENTTOS.Ciudades";
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ListarHoteles(string ciudadSeleccionada)
        {
            string textoSQL = "SELECT h.Hot_Codigo, h.Hot_Nombre FROM ATENTTOS.Hoteles h WHERE h.Hot_Ciu_Id = " + ciudadSeleccionada;
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable BuscarCiudadDelHotel(int hotelIDLogueado)
        {
            string textoSQL = "SELECT c.Ciu_Id, c.Ciu_Detalle FROM ATENTTOS.Hoteles h, ATENTTOS.Ciudades c WHERE c.Ciu_Id = h.Hot_Ciu_Id AND h.Hot_Codigo = " + hotelIDLogueado;
            return EjecutarConsulta(textoSQL);        
        }

        internal DataTable ListarRegimenes(int HotelID)
        {
            string textoSQL = "SELECT rxh.RxH_Reg_Codigo, r.Reg_Descripcion FROM ATENTTOS.Regimenes_Por_Hotel rxh, ATENTTOS.Regimenes r WHERE rxh.RxH_Hot_Codigo = 2 AND r.Reg_Codigo = rxh.RxH_Reg_Codigo AND r.Reg_Estado = 1 GROUP BY rxh.RxH_Hot_Codigo, rxh.RxH_Reg_Codigo, r.Reg_Descripcion ORDER BY rxh.RxH_Hot_Codigo, rxh.RxH_Reg_Codigo";
            return EjecutarConsulta(textoSQL);    
        }

        internal DataTable ListarTiposHabitaciones(int HotelID)
        {
            string textoSQL = "SELECT DISTINCT h.Hab_Tipo_Habitacion, h.Hab_Descripcion FROM ATENTTOS.Habitaciones h WHERE h.Hab_Estado = 1 AND h.Hab_Hot_Codigo = " + HotelID;
            return EjecutarConsulta(textoSQL);    
        }

        internal DataTable ListarHabitacionesDisponibles(int hotelID, object regimenID, int tipoHabitacionID, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            DataTable dt = new DataTable();
            if (CancelarReservasNoShow(fechaIngreso, hotelID, tipoHabitacionID))
            {
                string cadenaDeConexion = getCadenaDeConexion();

                SqlConnection connection = new SqlConnection(cadenaDeConexion);
                SqlCommand cmd;
                if (regimenID == null)
                {
                    cmd = new SqlCommand("ATENTTOS.SP_HabitacionesDisponiblesCualquierRegimen", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new SqlCommand("ATENTTOS.SP_HabitacionesDisponiblesUnRegimen", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@regimen", SqlDbType.Int);
                    cmd.Parameters["@regimen"].Value = Convert.ToInt32(regimenID);
                }

                cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                cmd.Parameters["@fechaInicio"].Value = fechaIngreso;

                cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime);
                cmd.Parameters["@fechaFin"].Value = fechaEgreso;

                cmd.Parameters.Add("@Hotel", SqlDbType.Int);
                cmd.Parameters["@Hotel"].Value = Convert.ToInt32(hotelID);

                cmd.Parameters.Add("@tipoHabitacion", SqlDbType.Int);
                cmd.Parameters["@tipoHabitacion"].Value = Convert.ToInt32(tipoHabitacionID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                try
                {
                    da.Fill(dt);
                }
                catch
                {
                    return dt = null;
                }
            }
            return dt;
        }

        private bool CancelarReservasNoShow(DateTime fechaIngreso, int hotelID, int tipoHabitacionID)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.cancelarReservas", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@fechainicio", SqlDbType.DateTime);
            cmd.Parameters["@fechainicio"].Value = fechaIngreso;

            cmd.Parameters.Add("@fechaSistema", SqlDbType.DateTime);
            cmd.Parameters["@fechaSistema"].Value = UsuarioLogin.TheInstance.getFechaSistema();

            cmd.Parameters.Add("@Hotel", SqlDbType.Int);
            cmd.Parameters["@Hotel"].Value = Convert.ToInt32(hotelID);

            cmd.Parameters.Add("@tipoHabitacion", SqlDbType.Int);
            cmd.Parameters["@tipoHabitacion"].Value = Convert.ToInt32(tipoHabitacionID);

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

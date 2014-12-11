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
                SqlCommand cmd = null;
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


        internal DataTable CambiarRegimenEnHabitacionesSeleccionadas(int hotelID, int regimenID, DateTime fechaIngreso, DateTime fechaEgreso, int habNumero)
        {
            DataTable dt = new DataTable();
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = null;

            cmd = new SqlCommand("ATENTTOS.SP_NuevoRegimenParaHabitacionDeReserva", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@fechainicio", SqlDbType.DateTime);
            cmd.Parameters["@fechainicio"].Value = fechaIngreso;

            cmd.Parameters.Add("@fechafin", SqlDbType.DateTime);
            cmd.Parameters["@fechafin"].Value = fechaEgreso;

            cmd.Parameters.Add("@Hotel", SqlDbType.Int);
            cmd.Parameters["@Hotel"].Value = hotelID;

            cmd.Parameters.Add("@habNumero", SqlDbType.Int);
            cmd.Parameters["@habNumero"].Value = habNumero;

            cmd.Parameters.Add("@regimen", SqlDbType.Int);
            cmd.Parameters["@regimen"].Value = regimenID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                da.Fill(dt);
            }
            catch
            {
                return dt = null;
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


        internal DataTable BuscarCliente(string tipoDocumento, string nroDocumento, string mail)
        {
            parametrosSP = new Parametros[3];

            parametrosSP[0] = new Parametros("@tipo_doc", tipoDocumento);
            parametrosSP[1] = new Parametros("@nro_doc", nroDocumento);
            parametrosSP[2] = new Parametros("@mail", mail);

            DataTable dt = EjecutarStoreProcedure("[ATENTTOS].[SP_BuscarClientesParaReserva]", parametrosSP);
            return dt;
        }

        internal int ObtenerSiguienteNumeroDeReserva()
        {
            parametrosSP = new Parametros[0];

            DataTable dt = EjecutarStoreProcedure("[ATENTTOS].[SP_ProximoNumeroReservas]", parametrosSP);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        internal bool RegistrarReservaTablaReservas(int nroReserva, int hotelID, int clienteID, DateTime fechaIngreso, int cantidadNoches, int regimenID, decimal costoPorDia, decimal costoTotal, string usuario)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Reservas ([Res_Codigo],[Res_Hot_codigo],[Res_Cli_Id],[Res_Fecha_Inicio],[Res_Cant_Noches],[Res_Tipo_Regimen],[Res_Costo_Por_Dia],[Res_Costo_Total],[Res_Usu_Generador],[Res_Estado]) VALUES (" + nroReserva.ToString() + "," + hotelID.ToString() + "," + clienteID.ToString() + ",'" + fechaIngreso.ToString("yyyy-MM-dd HH:mm:ss") + "'," + cantidadNoches.ToString() + "," + regimenID.ToString() + "," + costoPorDia.ToString().Replace(',', '.') + "," + costoTotal.ToString().Replace(',', '.') + ",'" + usuario + "',1);";
            return EjecutarComando(textoSQL);
        }

        internal bool RegistrarReservaTablaHabitacionesPorReservas(string nroReserva, string hotelID, string nroHabitacion)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Habitaciones_Por_Reserva ( HxR_Res_Codigo,HxR_Hot_Codigo,HxR_Hab_Nro) VALUES ( " + nroReserva + "," + hotelID + ", " + nroHabitacion + ");";
            return EjecutarComando(textoSQL);
        }

        internal bool RegistrarEnTablaLogRegistros(int nroReserva, string usuario, char tipoAccion, string motivo)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("[ATENTTOS].[SP_InsertarEnLogsReserva]", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nroReserva", SqlDbType.BigInt);
            cmd.Parameters["@nroReserva"].Value = Convert.ToInt64(nroReserva);
            
            cmd.Parameters.Add("@usuarioGenerador", SqlDbType.NVarChar);
            cmd.Parameters["@usuarioGenerador"].Value = usuario;

            cmd.Parameters.Add("@fechaLog", SqlDbType.DateTime);
            cmd.Parameters["@fechaLog"].Value = UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss");

            cmd.Parameters.Add("@tipoAccion", SqlDbType.Char);
            cmd.Parameters["@tipoAccion"].Value = tipoAccion;

            cmd.Parameters.Add("@motivo", SqlDbType.NVarChar);
            cmd.Parameters["@motivo"].Value = motivo;

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

        internal DataTable ObtenerDatosCliente(string nroReserva)
        {
            string textoSQL = "SELECT c.Cli_Id, c.Cli_Apellido, c.Cli_Nombre, tp.Tip_Descripcion, c.Cli_Numero_Documento, c.Cli_Mail FROM ATENTTOS.Reservas R, ATENTTOS.Clientes c, ATENTTOS.Tipo_Documento tp WHERE R.Res_Cli_Id = c.Cli_Id AND c.Cli_Tipo_Documento = tp.Tip_Id AND r.Res_Codigo = " + nroReserva;
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ObtenerDatosReserva(string nroReserva)
        {
            string textoSQL = "SELECT c.Ciu_Detalle, h.Hot_Nombre, h.Hot_Codigo, r.Res_Fecha_Inicio, DATEADD(DAY, r.Res_Cant_Noches, r.Res_Fecha_Inicio) AS FechaFin, r.Res_Tipo_Regimen, re.Reg_Descripcion FROM  ATENTTOS.Reservas r, ATENTTOS.Ciudades c, ATENTTOS.Hoteles h, ATENTTOS.Regimenes re WHERE c.Ciu_Id = h.Hot_Ciu_Id AND  r.Res_Hot_codigo = h.Hot_Codigo AND r.Res_Tipo_Regimen = re.Reg_Codigo AND r.Res_Codigo = " + nroReserva + " AND (r.Res_Estado = 1 OR r.Res_Estado = 2)";
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ObtenerDatosHabitaciones(string nroReserva)
        {
            string textoSQL = "SELECT	re.Reg_Descripcion, r.Res_Tipo_Regimen, r.Res_Fecha_Inicio, DATEADD(DAY, r.Res_Cant_Noches, r.Res_Fecha_Inicio)AS FechaFin,hxr.HxR_Hab_Nro,ha.Hab_Tipo_Habitacion,ha.Hab_Piso,ha.Hab_Ubicacion,ha.Hab_Descripcion,r.Res_Hot_codigo,h.Hot_Nombre,(h.Hot_CantEstrella*h.Hot_RecargaEstrella+(ha.Hab_Tipo_Porcentual*re.Reg_Precio)), r.Res_Cant_Noches, (h.Hot_CantEstrella*h.Hot_RecargaEstrella+(ha.Hab_Tipo_Porcentual*re.Reg_Precio))* r.Res_Cant_Noches FROM	ATENTTOS.Regimenes re, ATENTTOS.Reservas r, ATENTTOS.Habitaciones ha, ATENTTOS.Hoteles h, ATENTTOS.Habitaciones_Por_Reserva hxr WHERE	r.Res_Hot_codigo = h.Hot_Codigo AND	r.Res_Tipo_Regimen = re.Reg_Codigo AND  h.Hot_Codigo = ha.Hab_Hot_Codigo AND  hxr.HxR_Hab_Nro = ha.Hab_Numero AND  hxr.HxR_Res_Codigo = r.Res_Codigo AND  r.Res_Codigo = " + nroReserva;
            return EjecutarConsulta(textoSQL);
        }

        public class itemsNuevoReg
        {
            public int hotelID;
            public int regimenID;
            public DateTime fechaIngreso;
            public DateTime fechaEgreso;
            public int habNumero;
        }


        internal void UpdateTablaReservas(int hotelCodigo, DateTime fechaInicio, int cantNoches, int RegimenId, string costoPorDiaString, string costoTotalString, int NroReservaBuscado)
        {
            string textoSQL = "UPDATE ATENTTOS.Reservas SET Res_Hot_codigo = " + hotelCodigo.ToString() + ", Res_Fecha_Inicio = '" + fechaInicio.ToString("yyyy-MM-dd HH:mm:ss") + "', Res_Cant_Noches = " + cantNoches.ToString() + ",Res_Tipo_Regimen = " + RegimenId.ToString() + ", Res_Costo_Por_Dia = " + costoPorDiaString.Replace(',', '.') + ", Res_Costo_Total = " + costoTotalString.Replace(',', '.') + ", Res_Estado = 2 WHERE Res_Codigo = " + NroReservaBuscado.ToString();
            EjecutarComando(textoSQL);
        }

        internal void BajaHabitacionesAnteriores(int NroReservaBuscado)
        {            
            string textoSQL = "DELETE ATENTTOS.Habitaciones_Por_Reserva WHERE HxR_Res_Codigo = " + NroReservaBuscado.ToString();
            EjecutarComando(textoSQL);
        }

        internal bool CancelarReserva(int NroReservaBuscado, string usuario, string motivo)
        {
            int estado;
            if (usuario == "guest")
            {
                //Cancelada por el usuario
                estado = 4;
                
            }
            else
            {
                //Cancelada por la recepción
                estado = 3; 
            }
            string textoSQL = "UPDATE ATENTTOS.Reservas SET Res_Estado = " + estado.ToString() + " WHERE Res_Codigo = " + NroReservaBuscado.ToString();
            try
            {
                EjecutarComando(textoSQL);
                RegistrarEnTablaLogRegistros(NroReservaBuscado, usuario, 'C', motivo);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        internal DataTable ObtenerLogReserva(string nroReserva)
        {
            string textoSQL = "SELECT [LRe_ID_Log] AS 'ID Log',[LRe_Codigo_Reserva] AS 'Código de Reserva',[LRe_Usuario_Generador] AS 'Usuario Generador del Log',[LRe_FechaLog] AS 'Fecha Log',[LRe_Tipo_Accion] AS 'Tipo de Acción',[LRe_Motivo] AS 'Motivo' FROM [GD2C2014].[ATENTTOS].[LogReservas] WHERE LRe_Codigo_Reserva = " + nroReserva;
            return EjecutarConsulta(textoSQL);
        }
    }
}

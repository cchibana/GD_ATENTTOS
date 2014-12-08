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

        //Parametros para SP
        private Parametros[] parametrosSP;

        internal DataTable BuscarUsuarios(string nombreUsuario, string estadoUsuario, string tipoDocumentoEmpleado, string nroDocumentoEmpleado, string nombreEmpleado, string apellidoEmpleado, string mailEmpleado, string telefonoEmpleado, string direccionEmpleado, DateTime fechaNacimientoEmpleado)
        {
            string cadenaDeConexion = getCadenaDeConexion();
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_UsuariosBusqueda", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            }
            if (!string.IsNullOrEmpty(estadoUsuario))
            {
                cmd.Parameters.AddWithValue("@estadoUsuario", estadoUsuario.ToString());
            }
            if (!string.IsNullOrEmpty(tipoDocumentoEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Tipo_Documento", tipoDocumentoEmpleado.ToString());
            }
            if (!string.IsNullOrEmpty(nroDocumentoEmpleado))
            {
                cmd.Parameters.Add("@Emp_Documento_Numero", SqlDbType.BigInt);
                cmd.Parameters["@Emp_Documento_Numero"].Value = Convert.ToInt64(nroDocumentoEmpleado);
            }
            if (!string.IsNullOrEmpty(nombreEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Nombre", nombreEmpleado);
            }
            if (!string.IsNullOrEmpty(apellidoEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Apellido", apellidoEmpleado);
            }
            if (!string.IsNullOrEmpty(mailEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Mail", mailEmpleado);
            }
            if (!string.IsNullOrEmpty(telefonoEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Telefono", telefonoEmpleado);
            }
            if (!string.IsNullOrEmpty(apellidoEmpleado))
            {
                cmd.Parameters.AddWithValue("@Emp_Direccion", direccionEmpleado);
            }
            if (fechaNacimientoEmpleado.ToShortDateString() != DateTime.Today.ToShortDateString())
            {
                cmd.Parameters.Add("@Emp_Fecha_Nac", SqlDbType.DateTime);
                cmd.Parameters["@Emp_Fecha_Nac"].Value = fechaNacimientoEmpleado;
            }
            int idHotelActual = Dominio.UsuarioLogin.TheInstance.getHotel();
            cmd.Parameters.AddWithValue("@hotelID", idHotelActual);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        internal DataTable ListarTodosLosRolesActivosNoGuest()
        {
            string textoSQL = "SELECT [Rol_Id] FROM [GD2C2014].[ATENTTOS].[Roles] WHERE [Rol_Estado] = 'True' AND [Rol_ID] != 'Guest' ";
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ListarTodosLosTiposDocumentos()
        {
            string textoSQL = "select [Tip_Descripcion] from [GD2C2014].[ATENTTOS].[Tipo_Documento];";
            return EjecutarConsulta(textoSQL);
        }

        internal bool verificarNombreDeUsuarioValido(string nombreUsuarioIngresado)
        {
            //Si el nombre de usuario Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "  SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Usuarios u WHERE u.Usu_Username = '" + nombreUsuarioIngresado + "')	THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool verificarTipoYNumeroDocumentoValido(string tipoDocumento, string numeroDocumento)
        {
            //Si el nombre de empleado Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "  SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Empleados e, ATENTTOS.Tipo_Documento td WHERE e.Emp_Tipo_Documento = td.Tip_Id AND e.Emp_Documento_Numero = " + numeroDocumento + " AND td.Tip_Descripcion = '" + tipoDocumento + "') THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool verificarMailValido(string mailIngresado)
        {
            //Si el nombre de empleado Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Empleados e WHERE e.Emp_Mail = '" + mailIngresado + "')	THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool InsertarUsuarioEnTablaUsuarios(string nombreUsuario, string contrasenia)
        {
            string hash = cifrarContrasenia(contrasenia);
            string textoSQL = "INSERT INTO ATENTTOS.Usuarios VALUES ('" + nombreUsuario + "','" + hash + "',1,0)";
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

        public string cifrarContrasenia(string contrasenia)
        {
            //Cifrado de la contraseña
            Contrasenia.encriptarContrasenia contraseniaUsr = new Contrasenia.encriptarContrasenia();
            string hashContr = contraseniaUsr.hash(contrasenia);

            return hashContr;
        }

        internal bool InsertarDatosEnTablaEmpleados(string nombre, string apellido, string tipoDocumento, string nroDocumento, string mail, string telefono, string direccion, string fechaNacimiento, string usuario)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Empleados (Emp_Documento_Numero,Emp_Tipo_Documento,Emp_Username,Emp_Nombre,Emp_Apellido,Emp_Mail,Emp_Telefono,Emp_Direccion,Emp_Fecha_Nac)" 
                              + "VALUES	(" +nroDocumento+ ",(SELECT tp.Tip_Id FROM ATENTTOS.Tipo_Documento tp WHERE tp.Tip_Descripcion = '" + tipoDocumento + "'),"
                              + "'" + usuario + "','" + nombre + "','" + apellido + "','" + mail + "'," + telefono +",'" + direccion + "', '" + fechaNacimiento + "')";
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

        internal bool InsertarUsuarioEnTablaRoles_Por_Usuarios_Y_Hoteles(List<string> listaRolesSeleccionados, string nombreUsuarioNuevo)
        {
            int hotelID = Dominio.UsuarioLogin.TheInstance.getHotel();
            foreach (var item in listaRolesSeleccionados)
	        {
                string textSQL = "INSERT INTO ATENTTOS.Roles_Por_Usuarios_Y_Hoteles VALUES('" + item.ToString() + "', '" + nombreUsuarioNuevo + "'," + hotelID + ")";
                try
                {
                    EjecutarComando(textSQL);
                }
                catch 
                {
                    return false;   
                }
	        }
            return true;
        }

        internal DataTable ObtenerDatosUsuario(string nombreUsuario)
        {
            parametrosSP = new Parametros[1];
            parametrosSP[0] = new Parametros("@nombreUsuario", nombreUsuario);

            DataTable dt = EjecutarStoreProcedure("[ATENTTOS].[SP_ObtenerDatosUsuario]", parametrosSP);
            return dt;
        }

        internal DataTable ObtenerRolesUsuario(string nombreUsuario)
        {
            string textoSQL = "SELECT RxU_Id_Rol FROM ATENTTOS.Roles_Por_Usuarios_Y_Hoteles WHERE RxU_User_Usu = '" + nombreUsuario + "' AND RxU_Hot_Codigo = " + Dominio.UsuarioLogin.TheInstance.getHotel().ToString();
            DataTable dt = EjecutarConsulta(textoSQL);
            return dt;
        }

        internal bool GuardarNuevaContrasenia(string nombreUsuario, string nuevaContrasenia)
        {
            string hash = cifrarContrasenia(nuevaContrasenia);
            string textoSQL = "UPDATE ATENTTOS.Usuarios SET Usu_Password = '" + hash + "' WHERE Usu_Username = '" + nombreUsuario + "'";
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

        internal DataTable BuscarTodosLosRolesHotelesDelUsuario(string nombreUsuario)
        {
            string textoSQL = "SELECT r.RxU_Id_Rol, h.Hot_Nombre FROM	ATENTTOS.Roles_Por_Usuarios_Y_Hoteles r, ATENTTOS.Hoteles h WHERE h.Hot_Codigo = r.RxU_Hot_Codigo AND	r.RxU_User_Usu = '" + nombreUsuario + "'";
            DataTable dt = EjecutarConsulta(textoSQL);
            return dt;
        }

        internal bool ModificarDatosUsuarioEnTablaUsuarios(string nombreUsuarioNuevo, string nombreUsuarioAnterior, int estadoUsuario)
        {
            parametrosSP = new Parametros[2];
            parametrosSP[0] = new Parametros("@UsuUsernameAnterior", nombreUsuarioAnterior);
            parametrosSP[1] = new Parametros("@UsuUsernameNuevo", nombreUsuarioNuevo);
            if (EjecutarStoreProcedureSinDataTable("[ATENTTOS].[SP_CambiarUsuUsername]", parametrosSP))
	        {
                if (ModificarEstadoEnTablaUsuario(nombreUsuarioNuevo, estadoUsuario))
                {
                    return true;
                }  
	        }
            return false;

            
        }

        public bool ModificarEstadoEnTablaUsuario(string nombreUsuario, int estadoUsuario) 
        {
            string textoSQL = "UPDATE ATENTTOS.Usuarios SET Usu_Estado = " + estadoUsuario + " WHERE Usu_Username = '" + nombreUsuario + "'; ";
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

        internal bool QuitarRolesAlUsuario(string nombreUsuario, List<string> listaRolesParaEliminar)
        {
            int HotelActual = Dominio.UsuarioLogin.TheInstance.getHotel();
            foreach (var item in listaRolesParaEliminar)
            {
                string textoSQL = "DELETE FROM ATENTTOS.Roles_Por_Usuarios_Y_Hoteles WHERE RxU_Id_Rol='" + item.ToString() + "' AND RxU_User_Usu = '" + nombreUsuario + "' AND RxU_Hot_Codigo = " + HotelActual;
                try
                {
                    EjecutarComando(textoSQL);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        internal bool InsertarRolesAlUsuario(string nombreUsuario, List<string> listaRolesParaAgregar)
        {
            int HotelActual = Dominio.UsuarioLogin.TheInstance.getHotel();
            foreach (var item in listaRolesParaAgregar)
            {
                string textoSQL = "INSERT INTO ATENTTOS.Roles_Por_Usuarios_Y_Hoteles VALUES ('" + item.ToString() + "', '" + nombreUsuario + "'," + HotelActual + ")";
                try
                {
                    EjecutarComando(textoSQL);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        internal bool ModificarDatosEnTablaEmpleados(string nombreUsuario, string apellidoUsuario, string tipoDocumentoUsuario, string nroDocumentoUsuario, string mailUsuario, string telefonoUsuario, string direccionUsuario, DateTime fechaNacimientoUsuario, string Username)
        {
            string cadenaDeConexion = getCadenaDeConexion();

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_ModificarDatosEmpleados", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Emp_Documento_Numero", SqlDbType.BigInt);
            cmd.Parameters["@Emp_Documento_Numero"].Value = nroDocumentoUsuario;
            cmd.Parameters.AddWithValue("@Emp_Tipo_Documento", tipoDocumentoUsuario);
            cmd.Parameters.AddWithValue("@Emp_Apellido", apellidoUsuario);
            cmd.Parameters.AddWithValue("@Emp_Nombre", nombreUsuario);
            cmd.Parameters.AddWithValue("@Emp_Direccion", direccionUsuario);
            cmd.Parameters.Add("@Emp_Fecha_Nac", SqlDbType.DateTime);
            cmd.Parameters["@Emp_Fecha_Nac"].Value = fechaNacimientoUsuario;
            cmd.Parameters.AddWithValue("@Emp_Telefono", telefonoUsuario);
            cmd.Parameters.AddWithValue("@Emp_Mail", mailUsuario);
            cmd.Parameters.AddWithValue("@Emp_Username", Username);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                return true ;
            }
            catch 
            {
                return false;
            }


        }
    }
}

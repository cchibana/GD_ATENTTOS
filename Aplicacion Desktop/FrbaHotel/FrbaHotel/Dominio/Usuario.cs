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

        internal DataTable ListarTodosLosRolesActivos()
        {
            string textoSQL = "SELECT [Rol_Id] FROM [GD2C2014].[ATENTTOS].[Roles] WHERE [Rol_Estado] = 'True'";
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
    }
}

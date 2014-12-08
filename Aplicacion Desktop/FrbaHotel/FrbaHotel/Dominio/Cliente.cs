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
    class Cliente : CDatos
    {
        string estado;
        /*string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        string nacionalidad;
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value;}
        }

        string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        string tipoDoc;
        public string Tipodoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }

        int nroDocumento;
        public int NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }*/


        /*Rellenar el combobox desde la tabla*/
        public DataTable ListarNacionalidades()
        {
            string texto = "select [Pai_Nacionalidad] from [GD2C2014].[ATENTTOS].[Paises];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarPaises()
        {
            string texto = "select [Pai_Nombre] from [GD2C2014].[ATENTTOS].[Paises];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarTipoDoc()
        {
            string texto = "select [Tip_Descripcion] from [GD2C2014].[ATENTTOS].[Tipo_Documento];";
            return EjecutarConsulta(texto);
        }

        public DataTable RecuperaDescripDoc(string tipoDoc)
        {
            string texto = "select [Tip_Descripcion] from [GD2C2014].[ATENTTOS].[Tipo_Documento] where [Tip_Id] =" + tipoDoc + ";";
            return EjecutarConsulta(texto);
        }


        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarClientes(string nombreCli, string apellidoCli, string mailCli, string tipoDoc, string nroDoc)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_BuscarClientes", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(nombreCli))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreCli);
            }
            if (!string.IsNullOrEmpty(apellidoCli))
            {
                cmd.Parameters.AddWithValue("@apellido", apellidoCli);
            }
            if (!string.IsNullOrEmpty(mailCli))
            {
                cmd.Parameters.AddWithValue("@mail", mailCli);
            }            
            if (!string.IsNullOrEmpty(tipoDoc))
            {
                cmd.Parameters.AddWithValue("@tipo_doc", tipoDoc.ToString());
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                cmd.Parameters.AddWithValue("@nro_doc", nroDoc);
            }            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        internal bool verificarTipoYNumeroDocumentoValido(string tipoDocumento, string numeroDocumento)
        {
            //Si el cliente Ingresado no se encuentra registrado, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "  SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Clientes c, ATENTTOS.Tipo_Documento td WHERE c.Cli_Tipo_Documento = td.Tip_Id AND c.Cli_Numero_Documento = " + numeroDocumento + " AND td.Tip_Descripcion = '" + tipoDocumento + "') THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool verificarMailValido(string mailIngresado)
        {
            //Si el mail del cliente Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Clientes c WHERE c.Cli_Mail = '" + mailIngresado + "')	THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool InsertarDatosEnTablaClientes(string nombre, string apellido, string nacionalidad, string fechaNacimiento, string mail, string telefono, string direccion, string dirNumero, string piso, string dpto, string localidad, string pais, string tipoDocumento, string nroDocumento, string estado)
        {
            string textoSQL = @"INSERT INTO ATENTTOS.Clientes (Cli_Nombre, Cli_Apellido, Cli_Nacionalidad, Cli_Fecha_Nac, Cli_Mail, Cli_Telefono, Cli_Domicilio_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Dto, Cli_Localidad, Cli_Pai_Nombre, Cli_Tipo_Documento, Cli_Numero_Documento, Cli_Estado)" + 
                               "VALUES('" + @nombre + "', '" + @apellido + "', '" + @nacionalidad + "', '" + @fechaNacimiento + "', '"    
                              + @mail + "', " + @telefono + ", '" + @direccion + "'," + @dirNumero+ "," +@piso+ ",'"+@dpto+ "','"
                              +@localidad+ "','" +@pais+ "',(SELECT tp.Tip_Id FROM ATENTTOS.Tipo_Documento tp WHERE tp.Tip_Descripcion = '"+ @tipoDocumento + "')," + @nroDocumento+ ",1)";
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


        internal bool ModificarDatosClientes(string nombreCli, string apellidoCli, string nacionalidadCli, DateTime fechaNacimientoCli, string mailCli, string telefonoCli, string dirCalleCli, string nroCalleCli, string pisoCli, string dtoCli, string localidadCli, string paisCli, string tipoDocCli, string nroDocCli, string estadoCli)
        {
            if (estadoCli == "Habilitado")
            {
                estado = "True";
            }
            else
            {
                estado = "False";
            }

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_ModificarDatosClientes", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cli_Nombre", nombreCli);
            cmd.Parameters.AddWithValue("@Cli_Apellido", apellidoCli);
            cmd.Parameters.AddWithValue("@Cli_Nacionalidad", nacionalidadCli);
            cmd.Parameters.Add("@Cli_Fecha_Nac", SqlDbType.DateTime);
            cmd.Parameters["@Cli_Fecha_Nac"].Value = fechaNacimientoCli;
            cmd.Parameters.AddWithValue("@Cli_Mail", mailCli);
            cmd.Parameters.AddWithValue("@Cli_Telefono", telefonoCli);
            cmd.Parameters.AddWithValue("@Cli_Domicilio_Calle", dirCalleCli);
            cmd.Parameters.AddWithValue("@Cli_Nro_Calle", nroCalleCli);
            cmd.Parameters.AddWithValue("@Cli_Piso", pisoCli);
            cmd.Parameters.AddWithValue("@Cli_Dto", dtoCli);
            cmd.Parameters.AddWithValue("@Cli_Localidad", localidadCli);
            cmd.Parameters.AddWithValue("@Cli_Pai_Nombre", paisCli);
            cmd.Parameters.AddWithValue("@Cli_Tipo_Documento", tipoDocCli);
            cmd.Parameters.Add("@Cli_Numero_Documento", SqlDbType.BigInt);
            cmd.Parameters["@Cli_Numero_Documento"].Value = nroDocCli;
            cmd.Parameters.AddWithValue("@Cli_Estado", estado);

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
        

        public bool CambiarEstadoCliente(string tipoDoc, string numeroDoc, int estadoCliente)
        {
            string textoSQL = "UPDATE ATENTTOS.Clientes SET Cli_Estado = " + estadoCliente + " WHERE Cli_Tipo_Documento = (SELECT tp.Tip_Id FROM ATENTTOS.Tipo_Documento tp WHERE tp.Tip_Descripcion = '"+ tipoDoc + "') AND Cli_Numero_Documento = " +numeroDoc+ ";";
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


        internal bool InsertarDatosEnTablaClientesReservas(string nombre, string apellido, string mail, string telefono, string direccion, string dirNumero, string piso, string dpto, string localidad, string pais, string tipoDocumento, string nroDocumento)
        {
            string textoSQL = @"INSERT INTO ATENTTOS.Clientes (Cli_Nombre, Cli_Apellido, Cli_Mail, Cli_Telefono, Cli_Domicilio_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Dto, Cli_Localidad, Cli_Pai_Nombre, Cli_Tipo_Documento, Cli_Numero_Documento, Cli_Estado)" +
                               "VALUES('" + @nombre + "', '" + @apellido + "', '" + @mail + "', " + @telefono + ", '" + @direccion + "'," + @dirNumero + "," + @piso + ",'" + @dpto + "','"
                              + @localidad + "','" + @pais + "',(SELECT tp.Tip_Id FROM ATENTTOS.Tipo_Documento tp WHERE tp.Tip_Descripcion = '" + @tipoDocumento + "')," + @nroDocumento + ",1)";
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

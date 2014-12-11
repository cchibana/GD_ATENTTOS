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
    class Hotel : CDatos
    {

        string estado;

        public DataTable ListarRegimenes()
        {
            string texto = "select [Reg_Descripcion] from [GD2C2014].[ATENTTOS].[Regimenes];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarPaises()
        {
            string texto = "select [Pai_Nombre] from [GD2C2014].[ATENTTOS].[Paises];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarCiudades()
        {
            string texto = "select [Ciu_Detalle] from [GD2C2014].[ATENTTOS].[Ciudades];";
            return EjecutarConsulta(texto);
        }

        public DataTable RecuperaCodigoHotel(string calleHot, string numeroCalle)
        {
            string texto = "select [Hot_Codigo] from [GD2C2014].[ATENTTOS].[Hoteles] where [Hot_Calle] = '" + calleHot + "' and [Hot_Numero] = " + numeroCalle + ";";
            return EjecutarConsulta(texto);
        }

        public DataTable RecuperaIdCiudad(string ciuDetalle)
        {
            string texto = "select [Ciu_Id] from [GD2C2014].[ATENTTOS].[Ciudades] where [Ciu_Detalle] = '" + ciuDetalle + "';";
            return EjecutarConsulta(texto);
        }

        public DataTable RecuperaNomCiudad(string ciuId)
        {
            string texto = "select [Ciu_Detalle] from [GD2C2014].[ATENTTOS].[Ciudades] where [Ciu_Id] = '" + ciuId + "';";
            return EjecutarConsulta(texto);
        }
        

        internal bool verificarCalleYNumeroValido(string calleHotel, string numero)
        {
            //Si la dirección Ingresada es válida, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "  SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Hoteles h WHERE h.Hot_Calle = '" + calleHotel + "' AND h.Hot_Numero = '" + numero + "') THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarHoteles(string nombreHotel, string ciudadHotel, string paisHotel, string estrellas)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_BuscarHoteles", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(nombreHotel))
            {
                cmd.Parameters.AddWithValue("@nombreHotel", nombreHotel);
            }
            if (!string.IsNullOrEmpty(ciudadHotel))
            {
                cmd.Parameters.AddWithValue("@ciudadHotel", ciudadHotel);
            }
            if (!string.IsNullOrEmpty(paisHotel))
            {
                cmd.Parameters.AddWithValue("@paisHotel", paisHotel);
            }
            if (!string.IsNullOrEmpty(estrellas))
            {
                cmd.Parameters.AddWithValue("@estrellas", estrellas.ToString());
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        internal bool InsertarDatosEnTablaHoteles(string nombre, string mail, string telefono, string calle, string numero, string ciudad, string pais, string estrellas, string fechaCreacion, string estado)
        {
            string textoSQL = @"INSERT INTO ATENTTOS.Hoteles (Hot_Nombre, Hot_Email, Hot_Telefono, Hot_Calle, Hot_Numero, Hot_Ciu_Id, Hot_Pai_Nombre, Hot_CantEstrella, Hot_RecargaEstrella, Hot_Fecha_Creacion, Hot_Estado)"
                              + "VALUES	('" + nombre + "', '" + mail + "', " + telefono + ", '" + calle + "', "
                              + numero + ",'" + ciudad + "', '" + pais + "'," + estrellas + ", 10, '" + fechaCreacion + "', 1)";
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


        internal bool InsertarDatosEnTablaRegXHotel(string codigoHotel)
        {
            for (int i = 0; i < 4; i++)
            {
                int regCod = i+1;
                string textoSQL = @"INSERT INTO ATENTTOS.Regimenes_Por_Hotel (RxH_Hot_Codigo, RxH_Reg_Codigo)"
                + "VALUES (" + codigoHotel + "," + regCod + ");";

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

        public bool CambiarEstadoHotel(string calleHot, string numeroHot, int estadoHot)
        {
            string textoSQL = "UPDATE ATENTTOS.Hoteles SET Hot_Estado = " + estadoHot + " WHERE Hot_Calle = '" + calleHot + "' and Hot_Numero = " + numeroHot + ";";
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

        internal bool ModificarDatosHoteles(string nombreHot, string mailHot, string telefonoHot, string calleHot, string numeroHot, string ciudadIdHot, string paisHot, string estrellasHot, string fechaCreacionHot, string estadoHot)
        {
            if (estadoHot == "Habilitado")
            {
                estado = "True";
            }
            else
            {
                estado = "False";
            }

            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("ATENTTOS.SP_ModificarDatosHotel", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Hot_Nombre", nombreHot);
            cmd.Parameters.AddWithValue("@Hot_Email", mailHot);
            cmd.Parameters.Add("@Hot_Telefono", SqlDbType.BigInt);
            cmd.Parameters["@Hot_Telefono"].Value = Convert.ToInt64(telefonoHot);
            cmd.Parameters.Add("@Hot_Numero", SqlDbType.Int);
            cmd.Parameters["@Hot_Numero"].Value = Convert.ToInt32(numeroHot);
            cmd.Parameters.Add("@Hot_Ciu_Id", SqlDbType.Int);
            cmd.Parameters["@Hot_Ciu_Id"].Value = Convert.ToInt32(ciudadIdHot);
            cmd.Parameters.Add("@Hot_CantEstrella", SqlDbType.Int);
            cmd.Parameters["@Hot_CantEstrella"].Value = Convert.ToInt32(estrellasHot);
            cmd.Parameters.AddWithValue("@Hot_Calle", calleHot);
            cmd.Parameters.AddWithValue("@Hot_Pai_Nombre", paisHot);
            cmd.Parameters.Add("@Hot_Fecha_Creacion", SqlDbType.DateTime);
            cmd.Parameters["@Hot_Fecha_Creacion"].Value = fechaCreacionHot;
            cmd.Parameters.AddWithValue("@Hot_Estado", estado);            

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
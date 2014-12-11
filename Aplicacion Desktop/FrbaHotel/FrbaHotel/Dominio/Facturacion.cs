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
    class Facturacion : CDatos
    {

        internal DataTable VerificarEstadiaCheckOut(string nroEstadia)
        {
            string textoSQL = "select case when Est_Fecha_CheckOut is not null THEN 'true' else  'false' end from ATENTTOS.Estadias e WHERE e.Est_Id = " + nroEstadia;
            DataTable dt = EjecutarConsulta(textoSQL);
            return dt;
        }

        internal void RegistrarFacturacion(string nroEstadia, string formaPago, string nroTarjeta, string bancoTarjeta)
        {
            string textoSQL;
            try
            {
                if (formaPago == "Tarjeta")
                {
                    string textoSQL = "INSERT INTO ATENTTOS.Facturas ([Fac_Numero],[Fac_Est_Id],[Fac_Forma_Pago],[Fac_Fecha],[Fac_Nro_Tarjeta],[Fac_Banco]) VALUES (  (SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC)+1, " + nroEstadia + ", '" + formaPago + "', '" + Dominio.UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss") + "'," + nroTarjeta + ", '" + bancoTarjeta + "');";
                }
                else
                {
                    string textoSQL = "INSERT INTO ATENTTOS.Facturas ([Fac_Numero],[Fac_Est_Id],[Fac_Forma_Pago],[Fac_Fecha]) VALUES (  (SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC)+1, " + nroEstadia + ", '" + formaPago + "', '" + Dominio.UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss") + "');";
                }
                EjecutarComando(textoSQL);
            }
            catch 
            {
                
                throw;
            }
        }
    }
}

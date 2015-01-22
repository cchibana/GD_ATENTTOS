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
    class Consumible : CDatos
    {

        internal System.Data.DataTable ListarConsumibles()
        {
            string textoSQL = "SELECT [Cons_Codigo],[Cons_descripcion] FROM [GD2C2014].[ATENTTOS].[Consumibles]";
            return EjecutarConsulta(textoSQL);
        }


        internal bool RegistrarConsumible(string nroReserva, string nroConsumible, string cantidad)
        {
            string textoSQL = "exec ATENTTOS.SP_RegistrarConsumibles @CodEstadia=" + nroReserva + ", @CodConsumible=" + nroConsumible + ", @Cant = " + cantidad;
            try
            {
                EjecutarComando(textoSQL);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        internal DataTable VerificarFechaValida(string nroEstadia)
        {
            string fechaSistema = UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss");
            string textoSQL = "  select case when Est_Fecha_CheckOut is null AND (DATEADD(day, e.Est_cant_noches_res, e.Est_Fecha_inicio) >= '" + fechaSistema + "') THEN 'true' else  'false' end from ATENTTOS.Estadias e WHERE e.Est_Id = " + nroEstadia;
            return EjecutarConsulta(textoSQL);


        }
    }
}

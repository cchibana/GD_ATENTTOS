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
                    textoSQL = "INSERT INTO ATENTTOS.Facturas ([Fac_Numero],[Fac_Est_Id],[Fac_Forma_Pago],[Fac_Fecha],[Fac_Nro_Tarjeta],[Fac_Banco]) VALUES (  (SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC)+1, " + nroEstadia + ", '" + formaPago + "', '" + Dominio.UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss") + "'," + nroTarjeta + ", '" + bancoTarjeta + "');";
                }
                else
                {
                    textoSQL = "INSERT INTO ATENTTOS.Facturas ([Fac_Numero],[Fac_Est_Id],[Fac_Forma_Pago],[Fac_Fecha]) VALUES (  (SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC)+1, " + nroEstadia + ", '" + formaPago + "', '" + Dominio.UsuarioLogin.TheInstance.getFechaSistema().ToString("yyyy-MM-dd HH:mm:ss") + "');";
                }
                EjecutarComando(textoSQL);
            }
            catch 
            {
                
                throw;
            }
        }

        internal DataTable ObtenerDatosHabitaciones(string nroEstadia)
        {
            string textoSQL = "  SELECT	re.Reg_Descripcion, r.Res_Tipo_Regimen, r.Res_Fecha_Inicio, DATEADD(DAY, r.Res_Cant_Noches, r.Res_Fecha_Inicio)AS FechaFin,hxr.HxR_Hab_Nro,ha.Hab_Tipo_Habitacion,ha.Hab_Piso,ha.Hab_Ubicacion,ha.Hab_Descripcion,r.Res_Hot_codigo,h.Hot_Nombre,(h.Hot_CantEstrella*h.Hot_RecargaEstrella+(ha.Hab_Tipo_Porcentual*re.Reg_Precio)), r.Res_Cant_Noches, (h.Hot_CantEstrella*h.Hot_RecargaEstrella+(ha.Hab_Tipo_Porcentual*re.Reg_Precio))* r.Res_Cant_Noches FROM	ATENTTOS.Regimenes re, ATENTTOS.Reservas r, ATENTTOS.Habitaciones ha, ATENTTOS.Hoteles h, ATENTTOS.Habitaciones_Por_Reserva hxr, ATENTTOS.Estadias e WHERE	r.Res_Hot_codigo = h.Hot_Codigo AND	r.Res_Tipo_Regimen = re.Reg_Codigo AND  h.Hot_Codigo = ha.Hab_Hot_Codigo AND  hxr.HxR_Hab_Nro = ha.Hab_Numero AND  hxr.HxR_Res_Codigo = r.Res_Codigo AND  r.Res_Codigo = e.Est_Res_Codigo AND e.Est_Id = " + nroEstadia;
            return EjecutarConsulta(textoSQL);
        }

        internal DataTable RegistrarEstadiasFacturacion(string nroEstadia, string tipoHabitacion, string precioDia, string CantNoches)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Items_Factura ([Itf_Factura_Numero]  ,[Itf_Tipo],[Itf_Est_Id_] ,[Itf_Tipo_Habitacion],[Itf_Cons_Codigo],[Itf_Descripcion],[Itf_Monto],[Itf_Cantidad]) VALUES ((SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC), 'E', " + nroEstadia + ", " + tipoHabitacion+ ", Null, 'Estadía', " + precioDia+ ", " + CantNoches + ")";

            return EjecutarConsulta(textoSQL);
        }

        internal DataTable ObtenerDatosConsumibles(string nroEstadia)
        {
            string textoSQL = "SELECT [Cpe_Codigo_Consumible] ,[Cpe_Cantidad] FROM [GD2C2014].[ATENTTOS].[Consumibles_Por_Estadia]  WHERE Cpe_Estadia_Id = " + nroEstadia;
            return EjecutarConsulta(textoSQL);
        }

        internal void RegistrarConsumiblesFacturacion(string nroEstadia, string itemConsumible, string cantidad)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Items_Factura ([Itf_Factura_Numero]  ,[Itf_Tipo],[Itf_Est_Id_] ,[Itf_Tipo_Habitacion],[Itf_Cons_Codigo],[Itf_Descripcion],[Itf_Monto],[Itf_Cantidad]) VALUES ((SELECT TOP 1 Fac_Numero FROM ATENTTOS.Facturas ORDER BY Fac_Numero DESC), 'C', " + nroEstadia + ", null, " + itemConsumible + ", (SELECT c.Cons_descripcion FROM ATENTTOS.Consumibles c WHERE c.Cons_Codigo = " + itemConsumible+ "), (SELECT c.Cons_Precio FROM ATENTTOS.Consumibles c WHERE c.Cons_Codigo = " + itemConsumible + "), " + cantidad+ ")";
            EjecutarConsulta(textoSQL);
        }
    }
}

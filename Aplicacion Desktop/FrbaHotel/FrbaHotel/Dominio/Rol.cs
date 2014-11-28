using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Dominio
{
    class Rol : CDatos
    {
        //private static Rol _instancia;

        //public static Rol ObtenerInstancia()
        //{
        //    if (_instancia == null)
        //    {
        //        _instancia = new Rol();
        //    }
        //    return _instancia;
        //}

        //private Rol(){}

        public DataTable ListarFuncionalidades()
        {
            string textoSQL = "SELECT [Fun_Id],[Fun_Descripcion] FROM [GD2C2014].[ATENTTOS].[Funcionalidades]";
            return EjecutarConsulta(textoSQL);
        }
    }
}

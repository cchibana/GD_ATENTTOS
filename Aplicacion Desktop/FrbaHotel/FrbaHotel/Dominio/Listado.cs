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
    class Listado : CDatos
    {

        internal System.Data.DataTable ObtenerListado(string anio, string trimestre, int listado)
        {
            string textoSQL;

            switch (listado)
            {
                case 1:
                    textoSQL = "exec ATENTTOS.LISTADOUNO @año=" + anio + ", @trimestre = " + trimestre;
                    break;
                case 2:
                    textoSQL = "exec ATENTTOS.LISTADODOS @año=" + anio + ", @trimestre = " + trimestre +";";
                    //textoSQL = "exec ATENTTOS.LISTADODOS @año=2014, @trimestre=1;";
                    break;
                case 3:
                    textoSQL = "exec ATENTTOS.LISTADOTRES @año=" + anio + ", @trimestre = " + trimestre;
                    break;
                case 4:
                    textoSQL = "exec ATENTTOS.LISTADOCUATRO @año=" + anio + ", @trimestre = " + trimestre;
                    //textoSQL = "exec ATENTTOS.LISTADOCUATRO @año=2013, @trimestre=1;";
                    break;
                default:
                    textoSQL = "exec ATENTTOS.LISTADOCINCO @año=" + anio + ", @trimestre = " + trimestre;
                    break;
            }
            DataTable dt = EjecutarConsulta(textoSQL);
            return dt;

        }
    }
}

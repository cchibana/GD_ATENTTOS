using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaHotel.Dominio
{
    class Prueba : CDatos
    {
        private Parametros[] parametrosSP;
        
        public DataTable ConsultaRolesYHoteles(string username){

            parametrosSP = new Parametros[1]; //Pongo uno entre corchetes porque busco por un sólo parámetro
            parametrosSP[0] = new Parametros("@username",username); //El vector empieza en la posición 0.

            return EjecutarStoreProcedure("ATENTTOS.SP_RolesYHoteles", parametrosSP);
        }



    }
}

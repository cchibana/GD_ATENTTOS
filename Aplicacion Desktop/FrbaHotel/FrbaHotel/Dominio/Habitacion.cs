using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Dominio
{
    class Habitacion : CDatos
    {
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        int piso;

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        /*Estos metodos retornan resultados de consultas*/
        public DataTable Listar()
        {
            string texto = "select [Habitacion_Numero],[Habitacion_Piso],[Habitacion_frente],[Habitacion_Tipo_Descripcion] from [GD2C2014].[gd_esquema].[Maestra];";
            return EjecutarConsulta(texto);
        }
    }
}

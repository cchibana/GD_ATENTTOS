using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Dominio
{
    class Hotel : CDatos
    {
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        /*Estos metodos retornan resultados de consultas*/
        public DataTable Listar()
        {
            string texto = "select [Hotel_Ciudad],[Hotel_Calle],[Hotel_Nro_Calle],[Hotel_CantEstrella] from [GD2C2014].[gd_esquema].[Maestra] where ;";
            return EjecutarConsulta(texto);
        }

    }
}

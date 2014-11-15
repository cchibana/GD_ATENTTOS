using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Dominio
{
    class Cliente : CDatos
    {
        string nombre;

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

        /*Estos metodos retornan resultados pues con consultas*/
        public DataTable Listar()
        {
            string texto = "select * from [GD2C2014].[gd_esquema].[Maestra];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarPorNombre()
        {
            string texto = "select * from [GD2C2014].[gd_esquema].[Maestra] where nombre=" + Nombre + ";";
            return EjecutarConsulta(texto);
        }


    }
} 

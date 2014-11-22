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

        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        string tipoDoc;

        public string Tipodoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }

        int nroDocumento;

        public int NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }


        /*Estos metodos retornan resultados de consultas*/
        public DataTable Listar()
        {
            string texto = "select [Cliente_Nombre],[Cliente_Apellido],[Cliente_Nacionalidad],[Cliente_Fecha_Nac],[Cliente_Mail] from [GD2C2014].[gd_esquema].[Maestra];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarPorNombre()
        {
            string texto = "select [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],[Cliente_Nacionalidad] from [GD2C2014].[gd_esquema].[Maestra] where nombre = '" + Nombre + "';";
            return EjecutarConsulta(texto);
        }
        
    }
} 

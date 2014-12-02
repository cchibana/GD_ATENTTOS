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
            string texto = @"select [Hot_Nombre] as 'Nombre',
                                    [Hot_Email] as 'E-Mail' ,
                                    [Hot_Telefono] as 'Telefono',
                                    [Hot_Calle] as 'Calle',
                                    [Hot_Numero] as 'Número',
                                    [Hot_Ciu_Id] as 'Ciudad',
                                    [Hot_Pai_Nombre] as 'Pais',
                                    [Hot_CantEstrella] as 'Estrellas',
                                    [Hot_Fecha_Creacion] as 'Fecha Creación',
                                    [Hot_Estado] as 'Estado'
                               from [GD2C2014].[ATENTTOS].[Hoteles];";
            return EjecutarConsulta(texto);
        }

    }
}

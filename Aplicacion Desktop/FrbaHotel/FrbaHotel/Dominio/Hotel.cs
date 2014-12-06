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

        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarHoteles(string nombreHotel, string ciudadHotel, string paisHotel, string estrellas)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("dbo.SP_BuscarHoteles", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(nombreHotel))
            {
                cmd.Parameters.AddWithValue("@nombreHotel", nombreHotel);
            }
            if (!string.IsNullOrEmpty(ciudadHotel))
            {
                cmd.Parameters.AddWithValue("@ciudadHotel", ciudadHotel);
            }
            if (!string.IsNullOrEmpty(paisHotel))
            {
                cmd.Parameters.AddWithValue("@paisHotel", paisHotel);
            }
            if (!string.IsNullOrEmpty(estrellas))
            {
                cmd.Parameters.AddWithValue("@estrellas", estrellas.ToString());
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}

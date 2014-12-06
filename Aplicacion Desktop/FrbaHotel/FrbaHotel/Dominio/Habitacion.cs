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
    class Habitacion : CDatos
    {
        int numero;
        int piso;
        string ubicacion;
        int tipo;
        string descripcion;
        int estado;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /*Estos metodos retornan resultados de consultas*/
        public DataTable Listar()
        {
            string texto = @"select [Hab_Numero] as 'Numero',
                                    [Hab_Piso] as 'Piso',
                                    [Hab_Ubicacion] as 'Ubicacion',
                                    [Hab_Tipo_Habitacion] as 'Tipo', 
                                    [Hab_Descripcion] as 'Descripción',
                                    [Hab_Estado] as 'Estado'
                               from [GD2C2014].[ATENTTOS].[Habitaciones];";
            return EjecutarConsulta(texto);
        }


        string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GD2C2014"].ConnectionString;

        internal DataTable BuscarHabitaciones(string numeroHab, string pisoHab, string descripcion, string ubicacion, string tipoHab)
        {
            SqlConnection connection = new SqlConnection(cadenaDeConexion);
            SqlCommand cmd = new SqlCommand("dbo.SP_BuscarHabitaciones", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (!string.IsNullOrEmpty(numeroHab))
            {
                cmd.Parameters.AddWithValue("@numeroHab", numeroHab);
            }
            if (!string.IsNullOrEmpty(pisoHab))
            {
                cmd.Parameters.AddWithValue("@pisoHab", pisoHab);
            }
            if (!string.IsNullOrEmpty(descripcion))
            {
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
            }
            if (!string.IsNullOrEmpty(ubicacion))
            {
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion.ToString());
            }
            if (!string.IsNullOrEmpty(tipoHab))
            {
                cmd.Parameters.AddWithValue("@tipoHab", tipoHab.ToString());
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*public string Insertar()
        {
            string texto = @"INSERT into [GD2C2014].[ATENTTOS].[Habitaciones](Hab_Numero, Hab_Piso, Hab_Ubicacion, Hab_Tipo_Habitacion, Hab_Descripcion, Hab_Estado)
                             values(" + Numero + "," + Piso + ",'" + Ubicacion + "'," + Tipo + ",'" + Descripcion + "'," + Estado + ")";
            return EjecutarComando(texto);
        }*/


    }
}

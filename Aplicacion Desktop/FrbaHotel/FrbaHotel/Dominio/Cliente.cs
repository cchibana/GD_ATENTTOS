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

        string nacionalidad;
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value;}
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
            string texto = @"select [Cli_Nombre] as 'Nombre',
                                    [Cli_Apellido] as 'Apellido',
                                    [Cli_Pai_Nombre] as 'Nacionalidad',
                                    [Cli_Fecha_Nac] as 'Fecha de Nacimiento',
                                    [Cli_Mail] as 'Mail',
                                    [Cli_telefono] as 'Teléfono',
                                    [Cli_Domicilio_Calle] as 'Domicilio',
                                    [Cli_Nro_Calle] as 'Número',
                                    [Cli_Piso] as 'Piso',
                                    [Cli_Dto] as 'Dpto',
                                    [Cli_Pai_Nombre] as 'Ciudad',
                                    [Cli_Pai_Nombre] as 'Pais',
                                    [Cli_Tipo_Documento] as 'Tipo Doc',
                                    [Cli_Numero_Documento] as 'Nro Documento',
                                    [Cli_Estado] as 'Estado'
                               from [GD2C2014].[ATENTTOS].[Clientes];";

            return EjecutarConsulta(texto);
        }

        public DataTable ListarPorNombre()
        {
            string texto = @"select [Cli_Pasaporte_Nro],
                                    [Cliente_Apellido],
                                    [Cliente_Nombre],
                                    [Cliente_Fecha_Nac],
                                    [Cliente_Mail],
                                    [Cliente_Nacionalidad] 
                               from [GD2C2014].[ATENTTOS].[Clientes] where nombre = '" + Nombre + "';";
            return EjecutarConsulta(texto);
        }


        /*Rellenar el combobox desde la tabla*/
        public DataTable ListarNacionalidades()
        {
            string texto = "select [Pai_Nacionalidad] from [GD2C2014].[ATENTTOS].[Paises];";
            return EjecutarConsulta(texto);
        }

        public DataTable ListarTipoDoc()
        {
            string texto = "select [Tip_Descripcion] from [GD2C2014].[ATENTTOS].[Tipo_Documento];";
            return EjecutarConsulta(texto);
        }

        private Parametros[] parametrosSP;
        
        public DataTable ConsultaClientes(string nombre, string ape, string mail, string tipoDoc){

            parametrosSP = new Parametros[1]; //Pongo uno entre corchetes porque busco por un sólo parámetro
            parametrosSP[0] = new Parametros("@nombre",nombre); //El vector empieza en la posición 0.
            /*parametrosSP[1] = new Parametros("@apellido", apellido);
            parametrosSP[2] = new Parametros("@mail", mail);
            parametrosSP[3] = new Parametros("@tipo_doc", tipoDoc);*/
            //parametrosSP[4] = new Parametros("@nro_doc", nroDocumento);

            return EjecutarStoreProcedure("dbo.buscarClientes", parametrosSP);
        }
    }
} 

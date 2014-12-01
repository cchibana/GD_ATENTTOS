using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace FrbaHotel.Dominio
{
    class Rol : CDatos
    {
        public static List<item_idNombreFuncionalidad> lista_ID_Nombre_Funcionalidad;

        public static List<item_idNombreFuncionalidad> ObtenerInstanciaListaF()
        {
            if (lista_ID_Nombre_Funcionalidad == null)
            {
                lista_ID_Nombre_Funcionalidad = new List<item_idNombreFuncionalidad>();
            }
            return lista_ID_Nombre_Funcionalidad;
        }

        private static List<item_idYEstadoDelRol> lista_idYEstadoDelRol;

        public static List<item_idYEstadoDelRol> ObtenerInstanciaListaRol()
        {
            if (lista_idYEstadoDelRol == null)
            {
                lista_idYEstadoDelRol = new List<item_idYEstadoDelRol>();
            }
            return lista_idYEstadoDelRol;
        }

        //Parametros para SP
        private Parametros[] parametrosSP;

        /* Métodos ABM */
        public void cargarListaFuncionalidad()
        {
            DataTable dt = ListarFuncionalidades();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!ObtenerInstanciaListaF().Exists(e => e.id == Convert.ToInt32(dt.Rows[i][0].ToString())))
                {
                    ObtenerInstanciaListaF().Add(new item_idNombreFuncionalidad { id = Convert.ToInt32(dt.Rows[i][0].ToString()), nombre = dt.Rows[i][1].ToString() });   
                }
            }
        }

        public List<item_idNombreFuncionalidad> obtenerListadoFuncionalidades() 
        {
            return ObtenerInstanciaListaF();
        }

        public int obtenerIDdeFuncionalidad(string nombreFuncionalidad)
        {
            List<int> lista = new List<int>();
            item_idNombreFuncionalidad itemFunc = lista_ID_Nombre_Funcionalidad.Find(e => e.nombre == nombreFuncionalidad);
            return itemFunc.id;
        }

        public string obtenerNombreFuncionalidad(int idFuncionalidad) 
        {
            List<string> lista = new List<string>();
            item_idNombreFuncionalidad itemFunc = lista_ID_Nombre_Funcionalidad.Find(e => e.id == idFuncionalidad);
            return itemFunc.nombre;
        }



        public DataTable ListarFuncionalidades()
        {
            string textoSQL = "SELECT [Fun_Id],[Fun_Descripcion] FROM [GD2C2014].[ATENTTOS].[Funcionalidades]";
            return EjecutarConsulta(textoSQL);
        }

        public bool verificarNombreDeRolValido(string nombreRolIngresado){
            //Si el nombre de Rol Ingresado se encuentra disponible, devuelve 1(True). Sino, devuelve 0(False).
            string textoSQL = "SELECT CASE WHEN EXISTS ( SELECT * FROM ATENTTOS.Roles r WHERE r.Rol_Id = '" + nombreRolIngresado + "')THEN CAST(0 AS BIT)ELSE CAST(1 AS BIT) END";
            DataTable dt = EjecutarConsulta(textoSQL);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        internal bool InsertarNuevoRol(string nombreRolIngresado, bool estadoRolIngresado)
        {
            string textoSQL = "INSERT INTO ATENTTOS.Roles VALUES ('" + nombreRolIngresado + "','" + estadoRolIngresado.ToString() + "');";
            return EjecutarComando(textoSQL);
        }

        internal bool InsertarFuncionalidadesAlRol(string nombreRol, List<int> listaIDFuncionalidadesSeleccionadas)
        {
            foreach (var item in listaIDFuncionalidadesSeleccionadas)
            {
                string textoSQL = "INSERT INTO ATENTTOS.Roles_Por_Funcionalidad VALUES ('" + nombreRol + "', " + item.ToString() + ");";
                //MessageBox.Show(textoSQL);
                try
                {
                    EjecutarComando(textoSQL);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        internal bool QuitarFuncionalidadesAlRol(string nombreRol, List<int> listaIDFuncionalidadesParaEliminar)
        {
            foreach (var item in listaIDFuncionalidadesParaEliminar)
            {
                string textoSQL = "DELETE FROM ATENTTOS.Roles_Por_Funcionalidad WHERE RxF_Id_Rol = '" + nombreRol + "' AND RxF_Fun_Id = " + item.ToString();
                try
                {
                    EjecutarComando(textoSQL);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public void LimpiarListadoRol() 
        {
            ObtenerInstanciaListaRol().Clear();
        }

        internal List<item_idYEstadoDelRol> ObtenerListadoRoles()
        {
            LimpiarListadoRol();
            string textoSQL = "SELECT [Rol_Id], [Rol_Estado] FROM [GD2C2014].[ATENTTOS].[Roles]";
            DataTable dt = EjecutarConsulta(textoSQL);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ObtenerInstanciaListaRol().Add(new item_idYEstadoDelRol { id = dt.Rows[i][0].ToString(), estado = Convert.ToBoolean(dt.Rows[i][1].ToString()) });                    
            }
            return ObtenerInstanciaListaRol();
        
        }

        public List<int> BuscarFuncionalidades(string rol)
        {
            var listaIDFuncionalidades = new List<int>();

            parametrosSP = new Parametros[1]; //Pongo uno entre corchetes porque busco por un sólo parámetro
            parametrosSP[0] = new Parametros("@rol", rol); //El vector empieza en la posición 0.

            DataTable dt = EjecutarStoreProcedure("ATENTTOS.SP_FuncionalidadesPorRol", parametrosSP);

            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas > 0)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    listaIDFuncionalidades.Add(Convert.ToInt32(dt.Rows[i][0].ToString()));
                }
            }

            return listaIDFuncionalidades;
        }


        internal bool HabilitarRol(string nombreRol)
        {
            string textoSQL = "UPDATE [GD2C2014].[ATENTTOS].[Roles] SET Rol_Estado = 'true' WHERE Rol_Id = '" + nombreRol + "'";
            try
            {
                EjecutarComando(textoSQL);
            }
            catch 
            {
                return false;
            }
            return true;
        }

        internal bool DeshabilitarRol(string nombreRol)
        {
            string textoSQL = "UPDATE [GD2C2014].[ATENTTOS].[Roles] SET Rol_Estado = 'false' WHERE Rol_Id = '" + nombreRol + "'";
            try
            {
                EjecutarComando(textoSQL);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

    public class item_idNombreFuncionalidad
    {
        public int id {get; set;}
        public string nombre {get; set;}
    }

    public class item_idYEstadoDelRol   
    {
        public string id { get; set; }
        public bool estado { get; set; }
    }
}

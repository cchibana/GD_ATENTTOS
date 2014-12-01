using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Rol_Modificacion : Form
    {
        private static Rol_Modificacion _instancia;

        public static Rol_Modificacion ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Rol_Modificacion();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private Rol_Modificacion()
        {
            InitializeComponent();
            InicializarComboBoxFuncionalidades();
            DeshabilitarCampos();
            ArmarListView();
        }


        private void InicializarComboBoxFuncionalidades()
        {
            Dominio.Rol rol1 = new Dominio.Rol();
            DataTable dt_roles = rol1.ListarFuncionalidades();
            for (int i = 0; i < dt_roles.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_roles.Rows[i][1].ToString();
                item.Value = dt_roles.Rows[i][0];

                cb_Funcionalidades.Items.Add(item);
            }

            cb_Funcionalidades.SelectedIndex = 0;
            rol1.cargarListaFuncionalidad();
        }

        private void DeshabilitarCampos()
        {
            txtNombreRol.Enabled = false;
            lb_Funcionalidades.Enabled = false;
            cb_Funcionalidades.Enabled = false;
            btn_AgregarFuncionalidad.Enabled = false;
            btn_QuitarFuncionalidad.Enabled = false;
            btn_GuardarRol.Enabled = false;
        }

        private void ArmarListView()
        {
            lv_Roles.Columns[0].Width = 147;
            lv_Roles.Columns[1].Width = 119;


            Dominio.Rol rol1 = new Dominio.Rol();
            List<Dominio.item_idYEstadoDelRol> listadoRoles = rol1.ObtenerListadoRoles();

            foreach (var item in listadoRoles)
            {
                string estado;
                var itemLV = new ListViewItem(item.id.ToString());
                if (item.estado)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "No Activo";
                }
                itemLV.SubItems.Add(estado);
                lv_Roles.Items.Add(itemLV);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreRol.Text = null;
            lb_Funcionalidades.DataSource = null;
            lb_Funcionalidades.Items.Clear();
            cb_Funcionalidades.SelectedIndex = 0;
        }

        private void HabilitarCampos()
        {
            txtNombreRol.Enabled = true;
            lb_Funcionalidades.Enabled = true;
            cb_Funcionalidades.Enabled = true;
            btn_AgregarFuncionalidad.Enabled = true;
            btn_QuitarFuncionalidad.Enabled = true;
            btn_GuardarRol.Enabled = true;
        }

        private void btn_ModificarRolSeleccionado_Click(object sender, EventArgs e)
        {
            if (lv_Roles.SelectedItems.Count == 1)
            {
                HabilitarCampos();
                ListViewItem itemLVSeleccionado = lv_Roles.SelectedItems[0];
                LimpiarCampos();
                CargarCampos(itemLVSeleccionado.SubItems[0].Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
        }

        private void CargarCampos(string idRolSeleccionado)
        {
            txtNombreRol.Text = idRolSeleccionado;
            cb_Funcionalidades.SelectedIndex = 0;
            Dominio.Rol rol1 = new Dominio.Rol();
            ListViewItem itemLVSeleccionado = lv_Roles.SelectedItems[0];
            foreach (var itemFuncionalidad in rol1.BuscarFuncionalidades(itemLVSeleccionado.SubItems[0].Text))
            {
                string nombreFuncionalidad =  rol1.obtenerNombreFuncionalidad(Convert.ToInt32(itemFuncionalidad.ToString()));
                lb_Funcionalidades.Items.Add(nombreFuncionalidad);
            }
        }


        private void btn_AgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (!lb_Funcionalidades.Items.Contains(cb_Funcionalidades.SelectedItem.ToString()))
            {
                string itemSelTexto = cb_Funcionalidades.SelectedItem.ToString();
                lb_Funcionalidades.Items.Add(itemSelTexto);
            }
            else
            {
                MessageBox.Show("La funcionalidad seleccionada ya se ha sido agregada.");
            }
        }

        private void btn_QuitarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (this.lb_Funcionalidades.SelectedIndex >= 0)
            {
                this.lb_Funcionalidades.Items.RemoveAt(this.lb_Funcionalidades.SelectedIndex);
            }
        }

        private void btn_ActualizarListado_Click(object sender, EventArgs e)
        {
            lv_Roles.Items.Clear();
            ArmarListView();
        }

        private void btn_GuardarRol_Click(object sender, EventArgs e)
        {
            Dominio.Rol rol1 = new Dominio.Rol();
            List<int> listaFuncionalidadesAnterior = rol1.BuscarFuncionalidades(txtNombreRol.Text);
            List<int> listaIDFuncionalidadesNueva = armarListaFuncionalidadesSeleccionadas();
            List<int> listaIDFuncionalidadesParaAgregar = new List<int>();
            List<int> listaIDFuncionalidadesParaEliminar = rol1.BuscarFuncionalidades(txtNombreRol.Text);
            
            //Funcionalidades agregadas
            foreach (var itemFuncionalidad in listaIDFuncionalidadesNueva)
            {
                if (!listaFuncionalidadesAnterior.Contains(itemFuncionalidad))
                {
                    listaIDFuncionalidadesParaAgregar.Add(itemFuncionalidad);
                }
            }
            rol1.InsertarFuncionalidadesAlRol(txtNombreRol.Text, listaIDFuncionalidadesParaAgregar);

            //Funcionalidades eliminadas
            foreach (var itemFuncionalidad in listaFuncionalidadesAnterior)
            {
                if (listaIDFuncionalidadesNueva.Contains(itemFuncionalidad))
                {
                    listaIDFuncionalidadesParaEliminar.RemoveAt(listaIDFuncionalidadesParaEliminar.IndexOf(itemFuncionalidad));
                }
            }

            if (rol1.QuitarFuncionalidadesAlRol(txtNombreRol.Text, listaIDFuncionalidadesParaEliminar))
            {
                MessageBox.Show("Se han guardado las modificaciones");
            }
            else
            {
                MessageBox.Show("No se han podido guardar las modificaciones");
            }

            lv_Roles.Items.Clear();
            ArmarListView();
        }

        private List<int> armarListaFuncionalidadesSeleccionadas()
        {
            List<int> listaIDFuncionalidadesSeleccionadas = new List<int>();

            //Arma una lista a partir del ListBox
            var listaFuncionalidadesListBox = this.lb_Funcionalidades.Items.Cast<String>().ToList();

            Dominio.Rol rol1 = new Dominio.Rol();
            foreach (var item in listaFuncionalidadesListBox)
            {
                int id = rol1.obtenerIDdeFuncionalidad(item);
                listaIDFuncionalidadesSeleccionadas.Add(id);
            }
            return listaIDFuncionalidadesSeleccionadas;
        }

        private void btn_HabilitarRolSeleccionado_Click(object sender, EventArgs e)
        {
            if (lv_Roles.SelectedItems.Count == 1)
            {
                Dominio.Rol rol1 = new Dominio.Rol();
                if (rol1.HabilitarRol(lv_Roles.SelectedItems[0].Text))
                {
                    MessageBox.Show("Se ha habilitado el rol");
                    lv_Roles.Items.Clear();
                    ArmarListView();
                }
                else
                {
                    MessageBox.Show("No se ha podido habilitar el rol");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
        }
    }
}

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
    public partial class Rol_Alta : Form
    {
        private static Rol_Alta _instancia;

        public static Rol_Alta ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Rol_Alta();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Rol_Alta()
        {
            InitializeComponent();
            InicializarComboBoxFuncionalidades();
            InicializarComboBoxEstado();
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

        private void InicializarComboBoxEstado()
        {
            Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
            item.Text = "Activo";
            item.Value = "True";
            cb_EstadoRol.Items.Add(item);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "No Activo";
            item2.Value = "False";
            cb_EstadoRol.Items.Add(item2);
            cb_EstadoRol.SelectedIndex = 0;
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
            cb_EstadoRol.SelectedIndex = 0;
            cb_Funcionalidades.SelectedIndex = 0;    
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

        private void btn_GuardarRol_Click(object sender, EventArgs e)
        {
            Dominio.Rol rol1 = new Dominio.Rol();
            if (txtNombreRol.Text != "")
            {
                if (rol1.verificarNombreDeRolValido(txtNombreRol.Text))
                {
                    bool estadoRolSeleccionado = Convert.ToBoolean((cb_EstadoRol.SelectedItem as Dominio.ComboBoxItem).Value.ToString());
                    List<int> listaIDFuncionalidadesSeleccionadas = armarListaFuncionalidadesSeleccionadas();

                    if (rol1.InsertarNuevoRol(txtNombreRol.Text, estadoRolSeleccionado) && rol1.InsertarFuncionalidadesAlRol(txtNombreRol.Text, listaIDFuncionalidadesSeleccionadas))
                    {
                        MessageBox.Show("Alta de Rol exitosa");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido dar de alta al nuevo Rol");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de rol ingresado ya se encuentra registrado");
                }                
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el nuevo Rol");
            }

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



    }
}

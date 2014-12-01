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
    public partial class Rol_Baja : Form
    {
        private static Rol_Baja _instancia;

        public static Rol_Baja ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Rol_Baja();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private Rol_Baja()
        {
            InitializeComponent();
            ArmarListView();
        }

        private void ArmarListView()
        {
            lv_Roles.Columns[0].Width = 134;
            lv_Roles.Columns[1].Width = 127;


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

        private void btn_ActualizarListado_Click(object sender, EventArgs e)
        {
            lv_Roles.Items.Clear();
            ArmarListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lv_Roles.SelectedItems.Count == 1)
            {
                Dominio.Rol rol1 = new Dominio.Rol();
                if (rol1.DeshabilitarRol(lv_Roles.SelectedItems[0].Text))
                {
                    MessageBox.Show("Se ha dado de baja al rol");
                    lv_Roles.Items.Clear();
                    ArmarListView();
                }
                else
                {
                    MessageBox.Show("No se ha podido dar de baja al rol");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
        }
    }
}

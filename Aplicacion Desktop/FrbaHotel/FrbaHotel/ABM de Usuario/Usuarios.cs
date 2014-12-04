using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class Usuarios : Form
    {

        private static Usuarios _instancia;

        public static Usuarios ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Usuarios();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Usuarios()
        {
            InitializeComponent();
            InicializarComboBoxEstado();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();

            try
            {
                Dominio.ComboBoxItem itemCb_Estado = (Dominio.ComboBoxItem)cb_EstadoUsuario.SelectedItem;

                if (itemCb_Estado.Value == null)
                {
                    itemCb_Estado.Value = "";
                }

                DataTable dt = usu1.BuscarUsuarios(txt_nombre.Text, itemCb_Estado.Value.ToString());
                if (dt.Rows.Count != 0)
                {
                    dgv_usuarios.DataSource = dt;
                    dgv_usuarios.Columns[0].Width = 160;
                    dgv_usuarios.Columns[1].Width = 110;
                    dgv_usuarios.Columns[2].Width = 130;
                }
                else
                {
                    MessageBox.Show("No se encontró el registro. Para darlo de Alta, presione el botón de Alta.");
                }
            }
            catch
            {
                MessageBox.Show("Error en la búsqueda de Usuarios.");
            }
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuario_Alta usuario_Alta = FrbaHotel.ABM_de_Usuario.Usuario_Alta.ObtenerInstancia();
            usuario_Alta.Show(this);
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.CurrentRow != null)
            {
                if (dgv_usuarios.CurrentRow.Cells[2].Value.ToString() == "True")
                {
                    ABM_de_Usuario.Usuario_Modificacion usuario_Modificacion = FrbaHotel.ABM_de_Usuario.Usuario_Modificacion.ObtenerInstancia();
                    usuario_Modificacion.CargarDatos(dgv_usuarios.CurrentRow.Cells[0].Value.ToString(), dgv_usuarios.CurrentRow.Cells[1].Value.ToString());
                    usuario_Modificacion.Show(this);
                }
                else
                {
                    DialogResult resultado;
                    resultado = MessageBox.Show("Sólo pueden realizar modificaciones sobre usuarios que se desempeñen en este hotel. ¿Desea darle permisos a este usuario?"," ", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        RolesAUsuarioDeHotelLogueado ventanaRolesAUsuarioDeHotelLogueado = RolesAUsuarioDeHotelLogueado.ObtenerInstancia(dgv_usuarios.CurrentRow.Cells[0].Value.ToString());
                        ventanaRolesAUsuarioDeHotelLogueado.Show(this);
                        dgv_usuarios.DataSource = null;      
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para realizar la modificación.");
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuario_Alta usuario_Baja = FrbaHotel.ABM_de_Usuario.Usuario_Alta.ObtenerInstancia();
            usuario_Baja.Show(this);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos() 
        {
            txt_nombre.Text = null;
            cb_EstadoUsuario.SelectedIndex = 0;
            dgv_usuarios.DataSource = null;           
        }

        private void InicializarComboBoxEstado()
        {

            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cb_EstadoUsuario.Items.Add(item0);

            Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
            item.Text = "Activo";
            item.Value = "True";
            cb_EstadoUsuario.Items.Add(item);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "No Activo";
            item2.Value = "False";
            cb_EstadoUsuario.Items.Add(item2);

            cb_EstadoUsuario.SelectedIndex = 0;
        }


    }
}

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
            InicializarComboBoxTipoDocumento();
        }

        private void InicializarComboBoxTipoDocumento()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            DataTable dt_TipoDoc = usu1.ListarTodosLosTiposDocumentos();

            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cb_Usuario_TipoDocumento.Items.Add(item0);

            for (int i = 0; i < dt_TipoDoc.Rows.Count; i++)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Text = dt_TipoDoc.Rows[i][0].ToString();
                item.Value = dt_TipoDoc.Rows[i][0].ToString();

                cb_Usuario_TipoDocumento.Items.Add(item);
            }
            cb_Usuario_TipoDocumento.SelectedIndex = 0;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        public void BuscarUsuarios()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();
            Dominio.ComboBoxItem itemCb_Estado = (Dominio.ComboBoxItem)cb_EstadoUsuario.SelectedItem;
            Dominio.ComboBoxItem itemCb_TipoDocumento = (Dominio.ComboBoxItem)cb_Usuario_TipoDocumento.SelectedItem;
            DataTable dt;

            if (itemCb_Estado.Value == null)
            {
                itemCb_Estado.Value = "";
            }
            if (itemCb_TipoDocumento.Value == null)
            {
                itemCb_TipoDocumento.Value = "";
            }
            try
            {
                    dt = usu1.BuscarUsuarios    (txt_nombre.Text, 
                                                itemCb_Estado.Value.ToString(),
                                                itemCb_TipoDocumento.Value.ToString(),
                                                txt_Usuario_NroDocumento.Text,
                                                txt_Usuario_Nombre.Text,
                                                txt_Usuario_Apellido.Text,
                                                txt_Usuario_Mail.Text,
                                                txt_Usuario_Telefono.Text,
                                                txt_Usuario_Direccion.Text,
                                                dtp_Usuario_FechaNacimiento.Value);
                if (dt.Rows.Count != 0)
                {
                    dgv_usuarios.DataSource = dt;
                    dgv_usuarios.Columns[2].Width = 110;
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
            if (dgv_usuarios.CurrentRow != null)
            {
                if (dgv_usuarios.CurrentRow.Cells[1].Value.ToString() == "True")
                {
                    if (dgv_usuarios.CurrentRow.Cells[2].Value.ToString() == "True")
                    {
                        ABM_de_Usuario.Usuario_Baja usuario_Baja = FrbaHotel.ABM_de_Usuario.Usuario_Baja.ObtenerInstancia(dgv_usuarios.CurrentRow.Cells[0].Value.ToString());
                        usuario_Baja.Show(this);   
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja a un usuario que no se desempeñe en este hotel.");
                    }
                }
                else
                {
                    MessageBox.Show("Ya se ha dado de baja a este usuario");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para darlo de baja.");
            }
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
            dtp_Usuario_FechaNacimiento.Value = DateTime.Today;
        }

        private void InicializarComboBoxEstado()
        {

            Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
            item.Text = "Activo";
            item.Value = "True";
            cb_EstadoUsuario.Items.Add(item);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "No Activo";
            item2.Value = "False";
            cb_EstadoUsuario.Items.Add(item2);

            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cb_EstadoUsuario.Items.Add(item0);

            cb_EstadoUsuario.SelectedIndex = 0;
        }

        private void btn_TodosRolesHoteles_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.CurrentRow != null)
            {
                ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario ventanaRolesHotelesDeUsuario = ABM_de_Usuario.TodasLosRolesyHotelesDeUnUsuario.ObtenerInstancia(dgv_usuarios.CurrentRow.Cells[0].Value.ToString(), dgv_usuarios.CurrentRow.Cells[1].Value.ToString());
                ventanaRolesHotelesDeUsuario.Show();          
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para ver los roles y hoteles en donde se desempeña.");
            }
        }

    }
}

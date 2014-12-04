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
    public partial class TodasLosRolesyHotelesDeUnUsuario : Form
    {
        private static TodasLosRolesyHotelesDeUnUsuario _instancia;

        public static TodasLosRolesyHotelesDeUnUsuario ObtenerInstancia(string nombreUsuario)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new TodasLosRolesyHotelesDeUnUsuario(nombreUsuario);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public TodasLosRolesyHotelesDeUnUsuario(string nombreUsuario)
        {
            InitializeComponent();
            lbl_nombreUsuario.Text = nombreUsuario;
            ArmarDataGridView();
        }

        private void ArmarDataGridView()
        {
            Dominio.Usuario usu1 = new Dominio.Usuario();

            try
            {
                DataTable dt = usu1.BuscarTodosLosRolesHotelesDelUsuario(lbl_nombreUsuario.Text);
                if (dt.Rows.Count != 0)
                {
                    dgv_usuarios.DataSource = dt;
                    if (dgv_usuarios.Height > dgv_usuarios.Rows.GetRowsHeight(DataGridViewElementStates.Visible))
                    {
                        dgv_usuarios.Columns[0].Width = 128;
                        dgv_usuarios.Columns[1].Width = 128;
                    }
                    else
                    {
                        dgv_usuarios.Columns[0].Width = 120;
                        dgv_usuarios.Columns[1].Width = 120;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron roles y hoteles asignados al usuario seleccionado. ");
                }
            }
            catch
            {
                MessageBox.Show("Error en la búsqueda de roles y hoteles en donde se desempeña el usuario seleccionado.");
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

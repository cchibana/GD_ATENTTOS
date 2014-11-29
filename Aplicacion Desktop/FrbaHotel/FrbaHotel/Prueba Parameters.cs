using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel
{
    public partial class Prueba_Parameters : Form
    {
        public Prueba_Parameters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            Dominio.Prueba pruebaSP  = new Dominio.Prueba();
            DataTable dt = pruebaSP.ConsultaRolesYHoteles(nombreUsuario);
            int cantidadFilas = dt.Rows.Count;
            if (cantidadFilas > 0)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    MessageBox.Show(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString());
                    
                }
            }
            else
            {
                MessageBox.Show("Cantidad de filas : " + cantidadFilas);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Buscar Nombre de usuario en la tabla de Usuarios, y obtener el password.
            //Comparar y Loguear

            //Selección del hotel, si trabaja en más de uno.

            //Crear y Abrir Vista para Adminitrador y Recepcionista.
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            //Crear y Abrir vista para Guest..

            Generar_Modificar_Reserva.GenerarReserva nuevaReserva = new FrbaHotel.Generar_Modificar_Reserva.GenerarReserva();
            nuevaReserva.Show(this);
        }
    }
}

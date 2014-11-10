using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class PantallaPrincipal : Form
    {
        public MenuStrip menuPrincipal;

        public PantallaPrincipal(string rol)
        {
            InitializeComponent();
            CreateSimpleMenu(rol);

        }

        private void CreateSimpleMenu(string rol) {
            
            // Create high level menu container
            menuPrincipal = new MenuStrip();            
            
            ToolStripMenuItem menuItem_Reservas = new ToolStripMenuItem("&Reservas",null, new EventHandler(menuItem_Reservas_Click));
            menuPrincipal.Items.Add(menuItem_Reservas);
            //menuItem_Reservas.DropDownItems.Add("Sub menu item");
            //strip.Items.Add(menuItem_Reservas);

            if (rol == "recepcionista" || rol == "administrador")
            {
                ToolStripMenuItem menuItem_Clientes = new ToolStripMenuItem("&Clientes", null, new EventHandler(menuItem_Clientes_Click));
                menuPrincipal.Items.Add(menuItem_Clientes);
                ToolStripMenuItem menuItem_Estadias = new ToolStripMenuItem("&Estadías", null, new EventHandler(menuItem_Estadias_Click));
                menuPrincipal.Items.Add(menuItem_Estadias);
                ToolStripMenuItem menuItem_Consumiciones = new ToolStripMenuItem("&Consumiciones", null, new EventHandler(menuItem_Consumiciones_Click));
                menuPrincipal.Items.Add(menuItem_Consumiciones);
                ToolStripMenuItem menuItem_Facturaciones = new ToolStripMenuItem("&Facturaciones", null, new EventHandler(menuItem_Facturaciones_Click));
                menuPrincipal.Items.Add(menuItem_Facturaciones);

                if (rol == "administrador")
                {
                    ToolStripMenuItem menuItem_Roles = new ToolStripMenuItem("Roles", null, new EventHandler(menuItem_Roles_Click));
                    menuPrincipal.Items.Add(menuItem_Roles);
                    ToolStripMenuItem menuItem_Usuarios = new ToolStripMenuItem("&Usuarios", null, new EventHandler(menuItem_Usuarios_Click));
                    menuPrincipal.Items.Add(menuItem_Usuarios); 
                    ToolStripMenuItem menuItem_Hoteles = new ToolStripMenuItem("&Hoteles", null, new EventHandler(menuItem_Hoteles_Click));
                    menuPrincipal.Items.Add(menuItem_Hoteles);
                    ToolStripMenuItem menuItem_Habitaciones = new ToolStripMenuItem("&Habitaciones", null, new EventHandler(menuItem_Habitaciones_Click));
                    menuPrincipal.Items.Add(menuItem_Habitaciones);
                    ToolStripMenuItem menuItem_Regimenes = new ToolStripMenuItem("&Regímenes", null, new EventHandler(menuItem_Regimenes_Click));
                    menuPrincipal.Items.Add(menuItem_Regimenes);
                    ToolStripMenuItem menuItem_Listado_Estadistico = new ToolStripMenuItem("&Listado Estadístico", null, new EventHandler(menuItem_Listado_Estadistico_Click));
                    menuPrincipal.Items.Add(menuItem_Listado_Estadistico);
                }
            }

            ToolStripMenuItem menuItem_Salir = new ToolStripMenuItem("&Salir del Sistema", null, new EventHandler(menuItem_Salir_Click));
            menuPrincipal.Items.Add(menuItem_Salir);

            // Add menu to form
            this.Controls.Add(menuPrincipal);
        }

        private void menuItem_Reservas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservas");
        }

        private void menuItem_Clientes_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Clientes newCli = new ABM_de_Cliente.Clientes();
            newCli.Show(this);
        }

        private void menuItem_Estadias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estadías");
        }

        private void menuItem_Consumiciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consumiciones");
        }

        private void menuItem_Facturaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facturaciones");
        }

        private void menuItem_Roles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles");
        }

        private void menuItem_Usuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuarios");
        }

        private void menuItem_Hoteles_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hotel newHotel = new ABM_de_Hotel.Hotel();
            newHotel.Show(this);
        }

        private void menuItem_Habitaciones_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitaciones newHab = new ABM_de_Habitacion.Habitaciones();
            newHab.Show(this);
        }

        private void menuItem_Regimenes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regímenes");
        }

        private void menuItem_Listado_Estadistico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listado estadístico");
        }

        private void menuItem_Salir_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            DialogResult resultado; 
            resultado = MessageBox.Show("¿Desea salir del sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (DialogResult.OK == resultado)
            {
                //base.OnClosed(e);
                MessageBox.Show("Se cerrará su sesión.");
            }

        }


    }
}






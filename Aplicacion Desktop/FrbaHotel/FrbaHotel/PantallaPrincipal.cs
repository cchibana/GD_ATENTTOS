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

            ToolStripMenuItem menuItem_Reservas = new ToolStripMenuItem("&Reservas");
            //menuItem_Reservas.DropDownItems.Add("Sub menu item");
            //strip.Items.Add(menuItem_Reservas);

            if (rol == "recepcionista" || rol == "administrador")
            {
                ToolStripMenuItem menuItem_Clientes = new ToolStripMenuItem("&Clientes");
                ToolStripMenuItem menuItem_Estadias = new ToolStripMenuItem("&Estadías");
                ToolStripMenuItem menuItem_Consumiciones = new ToolStripMenuItem("&Consumiciones");
                ToolStripMenuItem menuItem_Facturaciones = new ToolStripMenuItem("&Facturaciones");

                if (rol == "administrador")
                {
                    ToolStripMenuItem menuItem_Roles = new ToolStripMenuItem("&Roles");
                    ToolStripMenuItem menuItem_Usuarios = new ToolStripMenuItem("&Usuarios");
                    ToolStripMenuItem menuItem_Hoteles = new ToolStripMenuItem("&Hoteles");
                    ToolStripMenuItem menuItem_Habitaciones = new ToolStripMenuItem("&Habitaciones");
                    ToolStripMenuItem menuItem_Regimenes = new ToolStripMenuItem("&Regímenes");
                    ToolStripMenuItem menuItem_Listado_Estadistico = new ToolStripMenuItem("&Listado Estadístico");
                }

                // Add menu to form
                this.Controls.Add(menuPrincipal);
            }
        }
    }
}






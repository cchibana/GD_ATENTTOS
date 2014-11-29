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

        public PantallaPrincipal()
        {
            InitializeComponent();
            MaximizarVentana();
            CreateSimpleMenu();
        }

        private void CreateSimpleMenu() {
            
            // Create high level menu container
            menuPrincipal = new MenuStrip();
            string rol = Dominio.UsuarioLogin.TheInstance.getRol();

            List<int> listaIDFuncionalidades = Dominio.UsuarioLogin.TheInstance.BuscarFuncionalidades();

            if (listaIDFuncionalidades.Exists(element => element == 1))
            {
                ToolStripMenuItem menuItem_Roles = new ToolStripMenuItem("Roles", null, new EventHandler(menuItem_Roles_Click));
                menuPrincipal.Items.Add(menuItem_Roles);
            }

            if (listaIDFuncionalidades.Exists(element => element == 2))
            {
                ToolStripMenuItem menuItem_Usuarios = new ToolStripMenuItem("&Usuarios", null, new EventHandler(menuItem_Usuarios_Click));
                menuPrincipal.Items.Add(menuItem_Usuarios);                 
            }

            if (listaIDFuncionalidades.Exists(element => element == 3))
            {
                ToolStripMenuItem menuItem_Clientes = new ToolStripMenuItem("&Clientes", null, new EventHandler(menuItem_Clientes_Click));
                menuPrincipal.Items.Add(menuItem_Clientes);
            }

            if (listaIDFuncionalidades.Exists(element => element == 4))
            {
                ToolStripMenuItem menuItem_Hoteles = new ToolStripMenuItem("&Hoteles", null, new EventHandler(menuItem_Hoteles_Click));
                menuPrincipal.Items.Add(menuItem_Hoteles);
            }

            if (listaIDFuncionalidades.Exists(element => element == 5))
            {
                ToolStripMenuItem menuItem_Habitaciones = new ToolStripMenuItem("&Habitaciones", null, new EventHandler(menuItem_Habitaciones_Click));
                menuPrincipal.Items.Add(menuItem_Habitaciones);
            }

            if (listaIDFuncionalidades.Exists(element => element == 6))
            {
                ToolStripMenuItem menuItem_Regimenes = new ToolStripMenuItem("&Regímenes", null, new EventHandler(menuItem_Regimenes_Click));
                menuPrincipal.Items.Add(menuItem_Regimenes);
            }

            if (listaIDFuncionalidades.Exists(element => element == 7 || element == 8))
            {
                ToolStripMenuItem menuItem_Reservas = new ToolStripMenuItem("&Reservas", null);
                menuPrincipal.Items.Add(menuItem_Reservas);

                if (listaIDFuncionalidades.Exists(element => element == 7))
                {
                    menuItem_Reservas.DropDownItems.Add("Generar o Modificar Reserva",null, new EventHandler(menuItem_ReservasGenerarModificar));
                    menuPrincipal.Items.Add(menuItem_Reservas);
                }
                if (listaIDFuncionalidades.Exists(element => element == 8))
                {
                    menuItem_Reservas.DropDownItems.Add("Cancelar Reserva", null, new EventHandler(menuItem_ReservasCancelar));
                    menuPrincipal.Items.Add(menuItem_Reservas);
                }
            }

            if (listaIDFuncionalidades.Exists(element => element == 9))
            {
                ToolStripMenuItem menuItem_Estadias = new ToolStripMenuItem("&Estadías", null, new EventHandler(menuItem_Estadias_Click));
                menuPrincipal.Items.Add(menuItem_Estadias);
            }

            if (listaIDFuncionalidades.Exists(element => element == 10))
            {
                ToolStripMenuItem menuItem_Consumiciones = new ToolStripMenuItem("&Consumiciones", null, new EventHandler(menuItem_Consumiciones_Click));
                menuPrincipal.Items.Add(menuItem_Consumiciones);
            }

            if (listaIDFuncionalidades.Exists(element => element == 11))
            {
                ToolStripMenuItem menuItem_Facturaciones = new ToolStripMenuItem("&Facturaciones", null, new EventHandler(menuItem_Facturaciones_Click));
                menuPrincipal.Items.Add(menuItem_Facturaciones);
            }

            if (listaIDFuncionalidades.Exists(element => element == 12))
            {
                ToolStripMenuItem menuItem_Listado_Estadistico = new ToolStripMenuItem("&Listado Estadístico", null, new EventHandler(menuItem_Listado_Estadistico_Click));
                menuPrincipal.Items.Add(menuItem_Listado_Estadistico);
            }
            
            //Item: Salir del sistema 
            ToolStripMenuItem menuItem_Salir = new ToolStripMenuItem("&Salir del Sistema", null, new EventHandler(menuItem_Salir_Click));
            menuPrincipal.Items.Add(menuItem_Salir);

            // Add menu to form
            this.Controls.Add(menuPrincipal);
        }

        //EventHandler
        private void menuItem_Roles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles");
        }

        private void menuItem_Usuarios_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuarios newUsu = new ABM_de_Usuario.Usuarios();
            newUsu.Show(this);
        }

        private void menuItem_Clientes_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Clientes newCli = new ABM_de_Cliente.Clientes();
            newCli.Show(this);
        }

        private void menuItem_Hoteles_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Hoteles newHotel = new ABM_de_Hotel.Hoteles();
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

        private void menuItem_ReservasGenerarModificar(object sender, EventArgs e)
        {
            MessageBox.Show("Reservas: Generara o Modificar");
        }

        private void menuItem_ReservasCancelar(object sender, EventArgs e)
        {
            MessageBox.Show("Reservas: Cancelar");
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

        private void menuItem_Listado_Estadistico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listado estadístico");
        }

        private void menuItem_Salir_Click(object sender, EventArgs e) 
        {
            this.Close();
            Application.Exit();
            
        }

        //protected override void OnClosed(EventArgs e)
        //{
            //DialogResult resultado; 
            //resultado = MessageBox.Show("¿Desea salir del sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //if (DialogResult.OK == resultado)
            //{
                //base.OnClosed(e);
                //MessageBox.Show("Se cerrará su sesión."); 
            //}
        //}

        private void MaximizarVentana() {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
       }

    }
}
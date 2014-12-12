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
            Dominio.UsuarioLogin.TheInstance.setFechaSistema();
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
                ToolStripMenuItem menuItem_Roles = new ToolStripMenuItem("Roles", null);
                menuPrincipal.Items.Add(menuItem_Roles);

                menuItem_Roles.DropDownItems.Add("Alta de Rol", null, new EventHandler(menuItem_Rol_Alta_Click));
                menuPrincipal.Items.Add(menuItem_Roles);

                menuItem_Roles.DropDownItems.Add("Modificación de Rol", null, new EventHandler(menuItem_Rol_Modificacion_Click));
                menuPrincipal.Items.Add(menuItem_Roles);

                menuItem_Roles.DropDownItems.Add("Baja de Rol", null, new EventHandler(menuItem_Rol_Baja_Click));
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
                    menuItem_Reservas.DropDownItems.Add("Generar Reserva", null, new EventHandler(menuItem_GenerarReserva));
                    menuPrincipal.Items.Add(menuItem_Reservas);
                    menuItem_Reservas.DropDownItems.Add("Modificar Reserva", null, new EventHandler(menuItem_ModificarReserva));
                    menuPrincipal.Items.Add(menuItem_Reservas);

                }
                if (listaIDFuncionalidades.Exists(element => element == 8))
                {
                    menuItem_Reservas.DropDownItems.Add("Cancelar Reserva", null, new EventHandler(menuItem_CancelarReserva));
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

            if (rol != "Guest")
            {
                //Item: Cambiar Contraseña propia
                ToolStripMenuItem menuItem_Configuracion = new ToolStripMenuItem("Configuración", null);
                menuPrincipal.Items.Add(menuItem_Configuracion);

                menuItem_Configuracion.DropDownItems.Add("Cambiar contraseña propia", null, new EventHandler(menuItem_ContraseñaPropia_Click));
                menuPrincipal.Items.Add(menuItem_Configuracion);   
            }

            //Item: Salir del sistema 
            ToolStripMenuItem menuItem_Salir = new ToolStripMenuItem("&Salir del Sistema", null, new EventHandler(menuItem_Salir_Click));
            menuPrincipal.Items.Add(menuItem_Salir);

            // Add menu to form
            this.Controls.Add(menuPrincipal);
        }

        //EventHandler
        private void menuItem_Rol_Alta_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.Rol_Alta newVentanaRolAlta = ABM_de_Rol.Rol_Alta.ObtenerInstancia();
            newVentanaRolAlta.Show();
        }

        private void menuItem_Rol_Baja_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.Rol_Baja newVentanaRolBaja = ABM_de_Rol.Rol_Baja.ObtenerInstancia();
            newVentanaRolBaja.Show();
        }

        private void menuItem_Rol_Modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.Rol_Modificacion newVentanaRolModificacion = ABM_de_Rol.Rol_Modificacion.ObtenerInstancia();
            newVentanaRolModificacion.Show();
        }

        private void menuItem_Usuarios_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.Usuarios newUsu = ABM_de_Usuario.Usuarios.ObtenerInstancia();
            newUsu.Show();
        }

        private void menuItem_Clientes_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.Clientes newCli = ABM_de_Cliente.Clientes.ObtenerInstancia();
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
            newHab.Show();
        }

        private void menuItem_Regimenes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABM Regímenes no disponible.");
        }

        private void menuItem_GenerarReserva(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Reserva_Generar newGenRes = Generar_Modificar_Reserva.Reserva_Generar.ObtenerInstancia();
            newGenRes.Show();
        }

        private void menuItem_ModificarReserva(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Reserva_Modificar newModRes = Generar_Modificar_Reserva.Reserva_Modificar.ObtenerInstancia();
            newModRes.Show();
        }

        private void menuItem_CancelarReserva(object sender, EventArgs e)
        {
            Cancelar_Reserva.Cancelar_Reserva newCancRes = Cancelar_Reserva.Cancelar_Reserva.ObtenerInstancia();
            newCancRes.Show();
        }
        
        private void menuItem_Estadias_Click(object sender, EventArgs e)
        {            
            Registrar_Estadia.Estadia_checkIn newCheckIn = new Registrar_Estadia.Estadia_checkIn();
            newCheckIn.Show();
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

        private void menuItem_ContraseñaPropia_Click(object sender, EventArgs e)
        {
            Contrasenia.NuevaContraseniaUsuarioLogueado newContrUsuLogin = Contrasenia.NuevaContraseniaUsuarioLogueado.ObtenerInstancia();
            newContrUsuLogin.Show();
        }


        private void menuItem_Salir_Click(object sender, EventArgs e) 
        {
            this.Close();
            Application.Exit();
        }

        private void MaximizarVentana() {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }


    }
}
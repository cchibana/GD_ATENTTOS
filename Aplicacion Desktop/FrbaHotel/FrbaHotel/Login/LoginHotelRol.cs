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
    public partial class LoginHotelRol : Form
    {
        List<Dominio.HotelRolLista> hotelRolLista;

        private static LoginHotelRol _instancia;

        public static LoginHotelRol ObtenerInstancia(List<Dominio.HotelRolLista> listaHotelRol)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new LoginHotelRol(listaHotelRol);
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private LoginHotelRol(List<Dominio.HotelRolLista> listaHotelRol)
        {
            hotelRolLista = listaHotelRol;
            InitializeComponent();
            ArmarListView(listaHotelRol);            
        }

        private void ArmarListView(List<Dominio.HotelRolLista> listaHotelRol)
        {
            listViewHotelRol.AutoResizeColumn(0,
               ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHotelRol.AutoResizeColumn(1,
               ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHotelRol.AutoResizeColumn(2,
               ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var iHotelRol in listaHotelRol)
            {
                var itemLV = new ListViewItem(iHotelRol.idHotel.ToString());
                itemLV.SubItems.Add(iHotelRol.nombreHotel);
                itemLV.SubItems.Add(iHotelRol.rol.ToString());
                listViewHotelRol.Items.Add(itemLV);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Segun qué rol y hotel eligio seteo el usuario con esos datos y creo la pantallaPrincipal

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TERMINARRRR!!!!!!!!!!!!!!!!
            if (listViewHotelRol.SelectedItems.Count == 1)
            {
                ListViewItem itemLVSeleccionado = listViewHotelRol.SelectedItems[0];

                //MessageBox.Show("Usted ha seleccionado:" + itemLVSeleccionado.SubItems[0].Text //Hotel_cod
                //                + " - " + itemLVSeleccionado.SubItems[1].Text  //Hotel_Nombre
                //                + " - " + itemLVSeleccionado.SubItems[2].Text); //Rol_Id

                if (Dominio.UsuarioLogin.TheInstance.BuscarEstadoDelRol(itemLVSeleccionado.SubItems[2].Text))
                {
                    Dominio.UsuarioLogin.TheInstance.setearHotelRol(itemLVSeleccionado.SubItems[1].Text, Convert.ToInt32(itemLVSeleccionado.SubItems[0].Text), itemLVSeleccionado.SubItems[2].Text);

                    this.Hide();
                    PantallaPrincipal pantPrinc = new PantallaPrincipal();
                    pantPrinc.Show(this);
                }
                else
                {
                    MessageBox.Show("El Rol con el que se quiere ingresar se encuentra Inactivo.");
                    LoginHotelRol.ObtenerInstancia(this.hotelRolLista);
                }
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un hotel y un rol");
            }
        }

        private void listViewHotelRol_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewHotelRol.Columns[e.ColumnIndex].Width;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Dominio.UsuarioLogin.TheInstance.setUsu_Username(null);
            Login.ObtenerInstancia().Show();
            this.Close();
        }
    }
}

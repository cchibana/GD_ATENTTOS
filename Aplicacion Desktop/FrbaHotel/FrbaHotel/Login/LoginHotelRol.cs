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
        private Dominio.UsuarioLogin usuarioLogueado;

        public LoginHotelRol(List<Dominio.HotelRolLista> listaHotelRol, Dominio.UsuarioLogin usu1)
        {
            usuarioLogueado = usu1;
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

                usuarioLogueado.setearHotelRol(itemLVSeleccionado.SubItems[1].Text, Convert.ToInt32(itemLVSeleccionado.SubItems[0].Text), itemLVSeleccionado.SubItems[2].Text);

                this.Hide();
                if (itemLVSeleccionado.SubItems[2].Text == "Administrador")
                {
                    //Pantalla ADMINISTRADOR
                    PantallaPrincipal pantPrinc = new PantallaPrincipal("Administrador");
                    pantPrinc.Show(this);
                }
                else if (itemLVSeleccionado.SubItems[2].Text == "Recepcionista")
                {
                    //Pantalla Recepcionista
                    PantallaPrincipal pantPrinc = new PantallaPrincipal("Recepcionista");
                    pantPrinc.Show(this);
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
    }
}

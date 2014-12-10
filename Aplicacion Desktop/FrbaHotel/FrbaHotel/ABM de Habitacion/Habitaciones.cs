using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class Habitaciones : Form
    {
        Dominio.Habitacion habitacion1 = new Dominio.Habitacion();

        private string idEstado;
        private string descEstado;

        public Habitaciones()
        {
            InitializeComponent();
            InicializarCboxUbicacion();
            InicializarCboxTipoHab();

            int idHotel = Dominio.UsuarioLogin.TheInstance.getHotel();
            txt_hotel.Text = idHotel.ToString();

        }

        public void Limpiar()
        {
            txt_numero.Text = "";
            txt_piso.Text = "";
            txt_descripcion.Text = "";
            cbox_ubicacion.SelectedIndex = 0;
            cbox_tipo_hab.SelectedIndex = 0;
            dgv_habitacion.DataSource = null;
        }

        private void KeyPressAlfa(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorAlfa(e.KeyChar);
        }

        private void KeyPressNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Dominio.Validadores.ValidadorNumerico(e.KeyChar);
        }

        private void InicializarCboxUbicacion()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cbox_ubicacion.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Vista Externa";
            item1.Value = "Vista Externa";
            cbox_ubicacion.Items.Add(item1);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "Vista Interna";
            item2.Value = "Vista Interna";
            cbox_ubicacion.Items.Add(item2);

            cbox_ubicacion.SelectedIndex = 0;
        }

        private void InicializarCboxTipoHab()
        {
            Dominio.ComboBoxItem item0 = new Dominio.ComboBoxItem();
            item0.Text = "Sin Especificar";
            item0.Value = null;
            cbox_tipo_hab.Items.Add(item0);

            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Base simple";
            item1.Value = "1001";
            cbox_tipo_hab.Items.Add(item1);

            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "Base doble";
            item2.Value = "1002";
            cbox_tipo_hab.Items.Add(item2);

            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "Base triple";
            item3.Value = "1003";
            cbox_tipo_hab.Items.Add(item3);

            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "Base cuadruple";
            item4.Value = "1004";
            cbox_tipo_hab.Items.Add(item4);

            Dominio.ComboBoxItem item5 = new Dominio.ComboBoxItem();
            item5.Text = "King";
            item5.Value = "1005";
            cbox_tipo_hab.Items.Add(item5);

            cbox_tipo_hab.SelectedIndex = 0;
        }


        private string DescripEstado(string idEstado)
        {
            if (idEstado == "True")
            {
                descEstado = "Disponible";
            }
            else
            {
                descEstado = "No Disponible";
            }
            return descEstado;
        }


        private void btn_alta_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Alta hab_Alta = new FrbaHotel.ABM_de_Habitacion.Habitacion_Alta();
            hab_Alta.Show(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Modificacion hab_Modificacion = new FrbaHotel.ABM_de_Habitacion.Habitacion_Modificacion();

            //se pasan los datos de la fila seleccionada a la pantalla de modificación
            hab_Modificacion.txt_numero.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            hab_Modificacion.txt_piso.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            hab_Modificacion.txt_ubicacion.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();            
            hab_Modificacion.txt_tipohab.Text = dgv_habitacion.CurrentRow.Cells[3].Value.ToString();
            hab_Modificacion.txt_descripcion.Text = dgv_habitacion.CurrentRow.Cells[4].Value.ToString();
            hab_Modificacion.txt_porcentual.Text = dgv_habitacion.CurrentRow.Cells[5].Value.ToString();

            idEstado = dgv_habitacion.CurrentRow.Cells[5].Value.ToString();
            DescripEstado(idEstado);
            hab_Modificacion.txt_estado.Text = descEstado;      
                    
            hab_Modificacion.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.Habitacion_Baja hab_Baja = new FrbaHotel.ABM_de_Habitacion.Habitacion_Baja();

            //se pasan los datos de la fila seleccionada a la pantalla de baja
            hab_Baja.txt_numero.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            hab_Baja.txt_piso.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            hab_Baja.txt_ubicacion.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();
            hab_Baja.txt_tipohab.Text = dgv_habitacion.CurrentRow.Cells[3].Value.ToString();
            hab_Baja.txt_descripcion.Text = dgv_habitacion.CurrentRow.Cells[4].Value.ToString();
            hab_Baja.txt_porcentual.Text = dgv_habitacion.CurrentRow.Cells[5].Value.ToString();
            //hab_Baja.txt_estado.Text = dgv_habitacion.CurrentRow.Cells[6].Value.ToString();

            idEstado = dgv_habitacion.CurrentRow.Cells[6].Value.ToString();
            DescripEstado(idEstado);
            hab_Baja.txt_estado.Text = descEstado; 

            hab_Baja.Show();
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Dominio.Habitacion hab1 = new Dominio.Habitacion();

            try
            {
                Dominio.ComboBoxItem itemCbox_ubicacion = (Dominio.ComboBoxItem)cbox_ubicacion.SelectedItem;
                Dominio.ComboBoxItem itemCbox_tipoHab = (Dominio.ComboBoxItem)cbox_tipo_hab.SelectedItem;

                if (itemCbox_ubicacion.Value == null)
                {
                    itemCbox_ubicacion.Value = "";
                }
                if (itemCbox_tipoHab.Value == null)
                {
                    itemCbox_tipoHab.Value = "";
                }

                DataTable dt = hab1.BuscarHabitaciones(txt_hotel.Text, txt_numero.Text, txt_piso.Text, txt_descripcion.Text, itemCbox_ubicacion.Value.ToString(), itemCbox_tipoHab.Value.ToString());

                if (dt.Rows.Count == 0)
                {
                    DialogResult Result;
                    Result = MessageBox.Show("No se encontró la habitación. Desea darlo de alta?", " ", MessageBoxButtons.OKCancel);

                    if (Result == DialogResult.OK)
                    {
                        ABM_de_Habitacion.Habitacion_Alta hab_Alta = new FrbaHotel.ABM_de_Habitacion.Habitacion_Alta();
                        hab_Alta.Show(this);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    dgv_habitacion.DataSource = dt;
                }                
            }
            catch
            {
                MessageBox.Show("Error al realizar la búsqueda");
            }          
        }

        private void dgv_habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificacion.Enabled = true;
            btn_baja.Enabled = true;
        }
    }
}

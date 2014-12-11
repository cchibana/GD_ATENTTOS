using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListadosEstadisticos : Form
    {
        private static ListadosEstadisticos _instancia;

        public static ListadosEstadisticos ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new ListadosEstadisticos();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public ListadosEstadisticos()
        {
            InitializeComponent();
            CargarComboBox();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cb_anio.SelectedIndex = 0;
            cb_nroListado.SelectedIndex = 0;
            cb_trimestre.SelectedIndex = 0;
        }

        private void CargarComboBox()
        {
            CargarComboBoxAnio();
            CargarComboBoxTrimestres();
            CargarComboBoxListados();

        }

        private void CargarComboBoxListados()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Hoteles con mayor cantidad de reservas canceladas";
            item1.Value = 1;
            cb_nroListado.Items.Add(item1);
            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "Hoteles con mayor cantidad de consumibles facturados";
            item2.Value = 3;
            cb_nroListado.Items.Add(item2);
            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "Hoteles con mayor cantidad de días fuera de servicio";
            item3.Value = 3;
            cb_nroListado.Items.Add(item3);
            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "Habitaciones con mayor cantidad de días y veces que fueron ocupadas";
            item4.Value = 4;
            cb_nroListado.Items.Add(item4);
            Dominio.ComboBoxItem item5 = new Dominio.ComboBoxItem();
            item5.Text = "Cliente con mayor cantidad de puntos";
            item5.Value = 5;
            cb_nroListado.Items.Add(item5);
        }

        private void CargarComboBoxAnio()
        {
            for (int i = DateTime.Today.Year; i >= 1950; i--)
            {
                Dominio.ComboBoxItem item = new Dominio.ComboBoxItem();
                item.Value = i;
                item.Text = i.ToString();
                cb_anio.Items.Add(item);
            }
        }



        private void CargarComboBoxTrimestres()
        {
            Dominio.ComboBoxItem item1 = new Dominio.ComboBoxItem();
            item1.Text = "Primer Trimestre";
            item1.Value = 1;
            cb_trimestre.Items.Add(item1);
            Dominio.ComboBoxItem item2 = new Dominio.ComboBoxItem();
            item2.Text = "Segundo Trimestre";
            item2.Value = 3;
            cb_trimestre.Items.Add(item2);
            Dominio.ComboBoxItem item3 = new Dominio.ComboBoxItem();
            item3.Text = "Tercer Trimestre";
            item3.Value = 3;
            cb_trimestre.Items.Add(item3);
            Dominio.ComboBoxItem item4 = new Dominio.ComboBoxItem();
            item4.Text = "Cuarto Trimestre";
            item4.Value = 4;
            cb_trimestre.Items.Add(item4);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Dominio.ComboBoxItem itemCb_Anio = (Dominio.ComboBoxItem)cb_anio.SelectedItem;
            Dominio.ComboBoxItem itemCb_Trimestre = (Dominio.ComboBoxItem)cb_trimestre.SelectedItem;
            Dominio.ComboBoxItem itemCb_Listado = (Dominio.ComboBoxItem)cb_nroListado.SelectedItem;

            Dominio.Listado list1 = new Dominio.Listado();
            DataTable dtListado = list1.ObtenerListado(itemCb_Anio.Value.ToString(), itemCb_Trimestre.Value.ToString(), Convert.ToInt32(itemCb_Listado.Value));

            dataGridView1.DataSource = dtListado;
        }



    }
}

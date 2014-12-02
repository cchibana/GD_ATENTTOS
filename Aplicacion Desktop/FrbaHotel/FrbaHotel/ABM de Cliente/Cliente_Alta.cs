﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class Cliente_Alta : Form
    {
        public Cliente_Alta()
        {
            InitializeComponent();
            
        }


        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cbox_nacionalidad.SelectedItem = null;
            txt_mail.Text = "";
            txt_telefono.Text = "";
            date_nacimiento.Value = DateTime.Now;
            txt_dom_calle.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";            
            txt_nrodoc.Text = "";
            cbox_tipodoc.SelectedItem = null;
            cbox_estado.SelectedItem = "Habilitado";            
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


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //   Clientes clientenuevo = new Clientes
        }


        private void Cliente_Alta_Load(object sender, EventArgs e)
        {
            Dominio.Cliente nacionalidad1 = new Dominio.Cliente();
            DataTable nacionalidad = nacionalidad1.ListarNacionalidades();

            for (int i = 0; i < nacionalidad.Rows.Count; i++)
            {
                cbox_nacionalidad.Items.Add(nacionalidad.Rows[i][0]);
            }

            Dominio.Cliente tipoDoc1 = new Dominio.Cliente();
            DataTable tipoDoc = tipoDoc1.ListarTipoDoc();

            for (int i = 0; i < tipoDoc.Rows.Count; i++)
            {
                cbox_tipodoc.Items.Add(tipoDoc.Rows[i][0]);
            }
        }
                      

    }
}

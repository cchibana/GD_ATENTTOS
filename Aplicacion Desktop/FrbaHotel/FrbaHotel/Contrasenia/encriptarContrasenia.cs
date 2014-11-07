using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;  

namespace FrbaHotel.Contrasenia
{
    public partial class encriptarContrasenia : Form
    {
        public encriptarContrasenia()
        {
            InitializeComponent();
        }

        private void chb_mostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_mostrarCaracteres.Checked)
            {
                txt_contrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txt_contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void btn_encriptarContrasenia_Click(object sender, EventArgs e)
        {
            string resultado = hash(txt_contrasenia.Text); 
            mostrarPanel(resultado);
        }

        private void mostrarPanel(string resultadoHash) { 
            lbl_hash.Visible = true;
            txt_hash.Visible = true;
            txt_hash.Text = resultadoHash;
        }

        public string hash(string input)
        {

            SHA256 hash = SHA256.Create();

            // Convertir la cadena en un array de bytes y calcular hash
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Copiar cada elemento del array a un
            // StringBuilder en formato hexadecimal
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }
}

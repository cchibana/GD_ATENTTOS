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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_contrasenia_Click(object sender, EventArgs e)
        {
            Contrasenia.encriptarContrasenia cont = new Contrasenia.encriptarContrasenia();
            cont.Show(this);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login.Login v_login = new Login.Login();
            v_login.Show(this);
        }
    }
}

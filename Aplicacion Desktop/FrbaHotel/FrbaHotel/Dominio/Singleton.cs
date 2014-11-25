using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace FrbaHotel.Dominio
{
    public class Singleton : CDatos
    {
        public static Singleton Instancia = new Singleton();
        private Singleton() { }
        public int Numero;
        public void DiNumer() {
            MessageBox.Show(Numero.ToString());
        }

    }
}
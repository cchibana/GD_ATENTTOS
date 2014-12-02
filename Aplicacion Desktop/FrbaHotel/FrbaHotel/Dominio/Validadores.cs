using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace FrbaHotel.Dominio
{
    public class Validadores
    {
        public static bool ValidadorNumerico(char e)
        {
            string CaracteresPermitidos = "0123456789\b";
            bool Existe;

            Existe = CaracteresPermitidos.Contains(e);

            if (Existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidadorAlfa(char e)
        {
            string CaracteresPermitidos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyzáéíóú \b";
            bool Existe;

            Existe = CaracteresPermitidos.Contains(e);

            if (Existe == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

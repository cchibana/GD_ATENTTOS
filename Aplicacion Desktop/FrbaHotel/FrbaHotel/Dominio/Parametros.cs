using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Dominio 
{
    public class Parametros
    {
    	private string nombre;

    	public string Nombre
    	{
    		get	{ return nombre; }
    		set { nombre = value; }
    	}

    	private string valor;

    	public string Valor
    	{
    		get { return valor; }
    		set { valor = value; }
    	}

    	public Parametros(string n, string v)
    	{
    		Nombre = n;
    		Valor = v;
    	}
    }
}

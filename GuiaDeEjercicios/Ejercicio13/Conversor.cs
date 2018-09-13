using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double d)
        {
            string cadena="";
            int i;
            
            for(i=0; i<d;i++)
                if(i % 2==1)
                {
                    cadena += "1";
                }else
                {
                    cadena += "0";
                }
            

            return cadena;
        }

        public static double BinarioDecimal(string s)
        {
            int exponente = s.Length - 1;
            double num_decimal = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (int.Parse(s.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return num_decimal;
        }
    }
}

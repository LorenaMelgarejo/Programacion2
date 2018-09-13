using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio05";

            double aumento = 1;
            double numero;
            double i;
            double j;
            double sumaAtras;
            double sumaAdelante;

            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            while (aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    { break; }
                    sumaAdelante = sumaAdelante + j;
                }

                
                if (sumaAtras == sumaAdelante)
                { Console.WriteLine("Es centro numerico: {0}", aumento); }
            }
            Console.ReadLine();
        }
    }
}

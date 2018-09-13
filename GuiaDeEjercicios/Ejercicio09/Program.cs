using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio09";
            int altura;
            int i;
            int incremento=0;

            altura = int.Parse(Console.ReadLine());

            while (incremento <= altura)
            {
                incremento++;
                for (i = 0; i < incremento; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

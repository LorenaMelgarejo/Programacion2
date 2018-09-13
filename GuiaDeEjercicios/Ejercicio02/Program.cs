using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio02";

            int num;
            double cuadrado=0;
            double cubo=0;
            bool flag = false;

            do
            {
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    cuadrado = Math.Pow(num, 2);
                    cubo = Math.Pow(num, 3);
                }
                else
                {
                    Console.WriteLine("ERROR.¡Reingresar numero!");
                    flag = true;
                }
            } while (flag==true);


            Console.WriteLine("{0} {1} {2}", num, cuadrado, cubo);

            Console.ReadLine();
        }
    }
}

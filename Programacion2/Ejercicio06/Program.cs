using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio06";

            double añoBisiesto=2018;
            int i;

            for(i=1;i<añoBisiesto;i++)
            {
                if((i%4==0 && i%100!=0) || i %400==0)
                {
                    Console.WriteLine("{0}",i);
                }
            }

            Console.ReadLine();
        }
    }
}

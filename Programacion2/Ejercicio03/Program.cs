using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio03";

            int num;
            int i;

            num = int.Parse(Console.ReadLine());

            for(i=1;i<=num;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.ReadLine();
        }
    }
}

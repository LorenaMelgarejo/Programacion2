using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio04";

            int numPerfec;
            int i;
            int num=0;

            numPerfec = int.Parse(Console.ReadLine());

            if(numPerfec >0)
            {
                for(i=1;i<numPerfec;i++)
                {
                   if(numPerfec%i==0)
                   {
                        num +=i;
                        Console.Write(i);    
                        if(num==numPerfec)
                        { break; }    
                   }
                }
            }
           
            Console.WriteLine("  {0}",num);
            Console.ReadLine();
        }
    }
}

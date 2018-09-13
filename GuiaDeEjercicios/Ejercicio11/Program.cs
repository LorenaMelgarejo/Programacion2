using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int min = 0;
            int max=0;
            float suma=0;
            float promedio=0;
            int flag = 0;

            for (i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());

                Validacion.Validar(num, -100, 100);

                if(min>num || flag==0)
                {
                    min = num;
                    flag = 1;
                }
                if(num>max)
                {
                    max = num;
                }
                suma = suma + num;
            }
            promedio = suma / 10;

            Console.WriteLine("minimo:{0},maximo:{1},promedio:{2}",min,max,promedio);
            Console.ReadLine();
        }
    }
}

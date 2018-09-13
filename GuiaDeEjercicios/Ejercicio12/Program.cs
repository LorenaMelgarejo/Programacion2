using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio12";

            int num;
            int suma=0;
            char respuesta;
            bool flag=true;

            do
            {
                num = int.Parse(Console.ReadLine());
                suma = suma + num;

                Console.WriteLine("¿Continuar?(S/N)");
               flag= ValidarRespuesta.ValidaS_N(respuesta=char.Parse(Console.ReadLine()));
            } while (flag);

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}

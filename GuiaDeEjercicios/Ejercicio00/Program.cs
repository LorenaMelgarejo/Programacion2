using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.WriteLine("Hola Mundo");
            nombre=Console.ReadLine();
            Console.WriteLine(nombre);

            edad = int.Parse(Console.ReadLine());
            Console.Write(edad);
        }
    }
}

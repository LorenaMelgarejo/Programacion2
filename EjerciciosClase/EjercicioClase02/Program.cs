using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje ="Michelle";
            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "Michelle";
            Sello.color = ConsoleColor.Cyan;
            Sello.ImprimirEnColor();


     
            Sello.mensaje = Console.ReadLine();
            Console.WriteLine(Sello.Imprimir());

      Console.ReadLine();
        }
    }
}

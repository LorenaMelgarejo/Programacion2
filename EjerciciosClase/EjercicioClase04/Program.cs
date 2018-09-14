using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioClase04";
            Cosa cosas = new Cosa();

            Console.WriteLine(Cosa.Mostrar(cosas));

            Cosa cosas2 = new Cosa("ee");
            Console.WriteLine(Cosa.Mostrar(cosas2));

            cosas.cadena = "MM";
            cosas.numero = 22;
            Console.WriteLine(Cosa.Mostrar(cosas));

            Console.ReadLine();
        }
    }
}

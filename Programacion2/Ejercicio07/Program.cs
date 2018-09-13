using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimiento;
            DateTime fechaActual = DateTime.Now;
            TimeSpan diasVividos;

            Console.WriteLine(fechaActual);
            Console.WriteLine("Ingrese dia mes anio:");
            nacimiento = DateTime.Parse(Console.ReadLine());

            diasVividos = fechaActual - nacimiento;

            Console.WriteLine(diasVividos.Days);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio08";

            int valorHora;
            string nombre;
            int antiguedad;
            int cantHoras;
            float importe;
            float descuento;
            float total;

            Console.WriteLine("Ingrese valorHora,nombre,antiguedad,cantidadHoras");
            valorHora = int.Parse(Console.ReadLine());
            nombre=Console.ReadLine();
            antiguedad = int.Parse(Console.ReadLine());
            cantHoras = int.Parse(Console.ReadLine());

            importe = (float)valorHora * cantHoras;
            importe += antiguedad * 150;

            descuento = (importe * 13) % 100;
            total = importe - descuento;

            Console.WriteLine("nombre:{0}\nantiguedad:{1}\nvalorHora:{2}\nimporteBruto:{3}\ndescuento:{4}\ntotalPago:{5}", nombre,antiguedad,valorHora,importe,descuento,total);
            Console.ReadLine();
        }
    }
}

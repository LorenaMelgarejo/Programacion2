using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioClase05";
            Tinta tin = new Tinta(ConsoleColor.Cyan,ETipoTinta.China);

            Console.WriteLine(Tinta.Mostrar(tin));

            Tinta tint = new Tinta();
            Console.WriteLine(Tinta.Mostrar(tint));

            Pluma plum = new Pluma("marca", 2,tin);
            Console.WriteLine(plum);

          /*  plum = plum + tint;
            Console.WriteLine(plum);*/

           /* Pluma pluam = new Pluma();
            Console.WriteLine(pluam);*/

            Console.ReadLine();
            
        }
    }
}

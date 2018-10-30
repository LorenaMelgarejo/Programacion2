using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestMascota1
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo gr = new Grupo("rio unica");

            Perro a1 = new Perro("moro","pitbull",0,true);
            gr += a1;
            Perro a2 = new Perro("ramo","salchicha",2,true);
            gr += a2;
            Gato a3 = new Gato("fer","siames");
            gr += a3;

            Console.WriteLine((string)gr);

            Console.ReadLine();
        }
    }
}

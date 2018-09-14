using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

       public static string Imprimir()
        {
      Console.WriteLine(Sello.ArmarFormatoMensaje());
      return Sello.mensaje;
        }

       public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.BackgroundColor = Sello.color=ConsoleColor.DarkGray;

        }

        private static string ArmarFormatoMensaje()
        {
         int cantidad;
         string a = "";
         int i;
         string cadena="";

      if (Sello.TryParse(Sello.mensaje, out cadena))
      {
        Sello.mensaje = cadena;


        cantidad = Sello.mensaje.Length;

        cantidad = cantidad + 2;

        for (i = 0; i < cantidad; i++)
        {
          a = a + "*";
        }
        a = a + "\n";
        a = a + "*";
        a = a + Sello.mensaje;
        a = a + "*\n";

        for (i = 0; i < cantidad; i++)
        {
          a = a + "*";
        }
      }
      else
      {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("No hay mensaje para imprimir");
        Console.BackgroundColor = ConsoleColor.DarkGray;
      }
         return a;
        }

        private static bool TryParse(string mensaje, out string salida)
        {
         bool retorno = false;
         int cantidad;

         cantidad = mensaje.Length;

      salida = "";

         if(cantidad>0)
        {
        salida = mensaje;
        retorno = true;
        }

         return retorno;
        }
    }
}

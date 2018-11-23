using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            } }
        public double PrecioDeNovelas { get { return this.ObtenerPrecio(ELibro.Novela); }  }
        public double PrecioTotal { get { return this.ObtenerPrecio(ELibro.Ambos); } }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }
        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad de la biblioteca: {0}\n", e._capacidad);
            sb.AppendFormat("Total por manuales: {0:N}\n", e.PrecioDeManuales);
            sb.AppendFormat("Total por novelas: {0:N}\n", e.PrecioDeNovelas);
            sb.AppendFormat("Total: {0:N}\n", e.PrecioTotal);

            sb.AppendLine("****************************\n" + "Listado de libros\n" + "****************************");

            foreach (Libro item in e._libros)
            {
                if (item is Novela)
                { sb.Append(((Novela)item).Mostrar()); }

                if (item is Manual)
                { sb.Append(((Manual)item).Mostrar()); }

                sb.AppendLine();
            }

            return sb.ToString();
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;
            double contManuales = 0, contNovelas = 0;

            foreach (Libro item in this._libros)
            {
                if (item is Novela)
                {
                    contNovelas += (Novela)item;
                }
                else if (item is Manual)
                {
                    contManuales += (Manual)item;
                }
            }

            if (tipoLibro == ELibro.Manual)
            { retorno = contManuales; }
            else if (tipoLibro == ELibro.Novela)
            { retorno = contNovelas; }
            else
            { retorno = contNovelas + contManuales; }

            return retorno;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca();
            b._capacidad = capacidad;
            return b;
        }
        public static bool operator !=(Biblioteca e,Libro l)
        {
            return !(e == l);
        }
        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;

            foreach (Libro item in e._libros)
            {
                if (item == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if(e._capacidad>e._libros.Count)
            {
                if(e!=l)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("El libro ya esta en la biblioteca!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la biblioteca!!!");
            }
            return e;
        }

    }
}

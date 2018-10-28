using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela:Libro
    {
        public EGenero genero;

        public Novela (string titulo,float precio,Autor autor,EGenero genero):base(titulo,autor,precio)
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            return (string)this + "\nTipo: " + this.genero +"\n";
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
        public static bool operator !=(Novela a,Novela b)
        {
            return !(a == b);
        }
        public static bool operator ==(Novela a,Novela b)
        {
            return (a.Mostrar() == b.Mostrar());
        }
    }
}

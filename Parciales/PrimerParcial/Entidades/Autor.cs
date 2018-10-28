using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static implicit operator string(Autor a)
        {
            return "AUTOR:"+ a.nombre + " - " + a.apellido;
        }
        public static bool operator !=(Autor a,Autor b)
        {
            return !(a==b);
        }
        public static bool operator ==(Autor a,Autor b)
        {
            return (a.nombre==b.nombre && a.apellido==b.apellido);
        }
        
    }
}

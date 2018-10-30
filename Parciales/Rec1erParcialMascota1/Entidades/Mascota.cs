using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre { get { return this.nombre; } }
        public string Raza { get { return this.raza; } }

        public Mascota(string nombre,string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nnombre y raza: {0} {1}",this.Nombre,this.Raza);
            return sb.ToString();
        }
        protected abstract string Ficha();
        
    }
}

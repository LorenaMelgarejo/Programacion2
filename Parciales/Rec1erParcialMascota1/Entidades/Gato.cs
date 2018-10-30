using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Gato:Mascota
    {
        public Gato(string nombre,string raza):base(nombre,raza)
        { }

        protected override string Ficha()
        {
            string retorno;
            
                retorno = this.DatosCompletos() + ",alda de la manada,edad ";
                return retorno;
        }

        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return (obj == this);
            }

            return false;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public static bool operator !=(Gato obj1,Gato obj2)
        {
            return !(obj1 == obj2);
        }
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return (obj1.Nombre==obj2.Nombre &&obj1.Raza==obj2.Raza);
        }
    }
}

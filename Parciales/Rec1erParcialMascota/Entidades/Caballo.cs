using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo:Animal
    {
        private string _nombre;
        private static int _patas;

        static Caballo()
        {
            Caballo._patas = 4;
        }
        public Caballo (string nombre,int velocidadMaxima):base(4,velocidadMaxima)
        {
            this._nombre = nombre;
        }

        public string MostrarCaballo()
        {
            return this.MostrarDatos()+ "\nnombre:" + this._nombre;
        }

        public static bool operator !=(Caballo c1,Caballo c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Caballo c1,Caballo c2)
        {
            return c1._nombre == c2._nombre;
        }
    }
}

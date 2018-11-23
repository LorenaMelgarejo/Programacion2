using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   

    public class Perro:Animal
    {
 public enum Razas { Galgo,OvejeroAleman}

        private static int _patas;
        private Razas _raza;

        static Perro()
        {
            Perro._patas = 4;
        }
        public Perro(int velocidadMaxima):base(4,velocidadMaxima)
        { }
        public Perro(Razas raza,int velocidadMaxima):this(velocidadMaxima)
        {
            this._raza = raza;
        }

        public string MostrarPerro()
        {
            return this.MostrarDatos()+"\nraza:" + this._raza;
        }

        public static bool operator !=(Perro p1,Perro p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Perro p1,Perro p2)
        {
            return (p1._raza == p2._raza && p1.VelocidadMaxima == p2.VelocidadMaxima);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Humano:Animal
    {
        private string _apellido;
        private string _nombre;
        private static int _piernas;

        static Humano()
        {
            Humano._piernas = 2;
        }
        public Humano(int velocidadMaxima):base(2,velocidadMaxima)
        {
        }
        public Humano(string nombre,string apellido,int velocidadMaxima):this(velocidadMaxima)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public string MostrarHumano()
        {
            return  this.MostrarDatos()+"\nnombre:"+this._nombre+"\napellido:"+this._apellido;
        }

        public static bool operator !=(Humano h1,Humano h2)
        {
            return !(h1 == h2);
        }
        public static bool operator ==(Humano h1,Humano h2)
        {
            return (h1._nombre == h2._nombre && h1._apellido == h2._apellido);
        }
    }
}

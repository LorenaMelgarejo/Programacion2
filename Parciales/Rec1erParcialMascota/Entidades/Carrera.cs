using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Carrera
    {
        private List<Animal> _animales;
        private int _corredoresMax;

        private Carrera()
        {
            this._animales = new List<Animal>();
        }
        public Carrera(int corredoresMax):this()
        {
            this._corredoresMax = corredoresMax;
        }

        public string MostrarCarrera(Carrera c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CorredoresMaximos: {0}\n", c._corredoresMax);

            //if (c._animales != null)
            //{
                for (int i = 0; i < c._animales.Count; i++)
                {
                    if (c._animales[i] is Humano)
                    {
                        sb.Append(((Humano)c._animales[i]).MostrarHumano());
                    }
                    if (c._animales[i] is Perro)
                    {
                        sb.Append(((Perro)c._animales[i]).MostrarPerro());
                    }
                    if (c._animales[i] is Caballo)
                    {
                        sb.Append(((Caballo)c._animales[i]).MostrarCaballo());
                    }
                    sb.AppendLine();
                //}
            }
            return sb.ToString();
        }

        public static bool operator !=(Carrera c,Animal a)
        {
            return !(c == a);
        }
        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno=false;
            if (c._animales != null)
            {
                foreach (Animal item in c._animales)
                {
                    if (item == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static Carrera operator +(Carrera c, Animal a)
        {
            if (c._animales != null)
            {
                if (c._corredoresMax > c._animales.Count)
                {
                    if (c != a)
                    {
                        c._animales.Add(a);
                    }
                    else { Console.WriteLine("son iguales"); }
                }
                else { Console.WriteLine("no hay lugar"); }
            }
            return c;
        }
    }
}

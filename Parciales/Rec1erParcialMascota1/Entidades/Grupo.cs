using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        public enum TipoManada {Unica,Mixta }

        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        public TipoManada Tipo { set { Grupo.tipo = value; } }

        static Grupo()
        {
           Grupo.tipo=TipoManada.Unica;
        }
        private Grupo()
        { manada = new List<Mascota>(); }
        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre,TipoManada tipo):this(nombre)
        {
            this.Tipo = tipo;
        }

        public static implicit  operator string(Grupo e)
        {
            string retorno;

            retorno = e.nombre + "\nintegrantes:";

            for(int i=0;i<e.manada.Count;i++)
            {
                retorno += "\n"+e.manada[i];
            }
           return retorno;
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static bool operator ==(Grupo e, Mascota j)
        {
            bool retorno = false;

            foreach(Mascota item in e.manada)
            {
                if(item ==j)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }
        public static Grupo operator+(Grupo e,Mascota j)
        {
            if(!(e==j))
            {
                e.manada.Add(j);
            }
            return e;
        } 
    }
}

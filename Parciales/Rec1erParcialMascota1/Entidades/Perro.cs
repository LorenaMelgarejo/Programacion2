using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad {
            get { return this.edad; }
            set { this.edad = value; } }
        public bool EsAlfa {
            get { if (this.Edad == 0)
                { this.esAlfa = false; }
                return this.esAlfa; }
            set { this.esAlfa = value; } }

        public Perro(string nombre, string raza):base(nombre,raza)
        { }
        public Perro(string nombre,string raza,int edad,bool esAlfa):this(nombre,raza)
        {
                this.Edad = edad;
                this.EsAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string retorno;
            if(this.EsAlfa==true)
            {
                retorno = this.DatosCompletos() +",alfa de la manada,edad "+this.Edad.ToString();
            }
            else
            {
                retorno = this.DatosCompletos() + ", edad " + this.Edad.ToString();
            }
            return retorno;
        }

        public override bool Equals(object obj)
        {
            
            if (obj is Perro)
            {
                return (obj == this);
            }

            return false;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        public static bool operator!=(Perro j1,Perro j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Perro j1,Perro j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad);
        }
    }
}

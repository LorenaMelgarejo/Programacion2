using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        protected int _cantidadPata;
        protected static Random _distanciaRecorrida;
        protected int _velocidadMaxima;

        public int CantidadPatas {
            get { if (this._cantidadPata > 4)
                {
                    return 4;
                }
                return this._cantidadPata;
            }
            set { this._cantidadPata = value; } }
        public int DistanciaRecorrida {
            get {
                int i;
                 i = Animal._distanciaRecorrida.Next(10, this._velocidadMaxima);
                return i;
            }  }
        public int VelocidadMaxima {
            get { if(this._velocidadMaxima>60)
                {
                    return 60;
                }
                return this._velocidadMaxima;
            }
            set { this._velocidadMaxima = value; } }

         static Animal()
        {
            Animal._distanciaRecorrida = new Random();
        }
        public Animal(int cantidadPatas,int velocidadMaxima)
        {
            this._cantidadPata = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima;
        }

        public string MostrarDatos()
        {
            return "\npatas:" + this.CantidadPatas + "\nvelocidad:" + this.VelocidadMaxima;
        }
    }
}

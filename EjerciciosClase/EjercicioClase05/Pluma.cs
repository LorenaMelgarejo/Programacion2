using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Pluma
    {
        #region atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;
        #endregion

        #region constructores
        public Pluma()
        {
            this._marca = "sinMarca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca) :this()
        {
            this._marca = marca;
        }

        public Pluma(string marca,int cant) :this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant, Tinta tin) :this(marca,cant)
        {
            this._tinta = tin;
        }
        #endregion

        #region metodos
        private string Mostrar()
        {
            string retorno;
            if ((object)this._tinta != null)
            {
                retorno = this._marca + " " + this._cantidad + " " + Tinta.Mostrar(this._tinta);
            }
            else
            {
                retorno = this._marca + " " + this._cantidad;
            }
            return retorno;
        }
        #endregion

        #region sobrecargaOperadores
        public static implicit operator string(Pluma plum)
        {
            return plum.Mostrar();
        }

        public static bool operator ==(Pluma p, Tinta t)
        {
            if ((object)p != null && (object)t != null)
            {
                return p == t;
            }
                return false;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            if ((object)p != null && (object)t != null)
            {
                return !(p == t);
            }
            return false;
        }

        public static Pluma operator +(Pluma p,Tinta t)
        {
            if (!object.Equals(t,null))
            {
                if (p == t && p._cantidad < 100 || t == null)
                {
                    p._cantidad += 10;
                }
            }
            return p;
        }

        public static Pluma operator -(Pluma p, Tinta t)
        {
            if ((object)t != null)
            {
                if (p == t && p._cantidad > 0)
                {
                    p._cantidad -= 8;
                }
            }
            return p;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.clase07
{
    public class Tempera
    {
        #region atributos
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;
        #endregion
        #region constructor
        public Tempera()
        {
            this._cantidad = 0;
            this._color = ConsoleColor.Blue;
            this._marca = "sinMarca";
        }

        public Tempera(sbyte s):this()
        {
            this._cantidad = s;
        }

        public Tempera(sbyte s,ConsoleColor c) :this(s)
        {
            this._color = c;
        }

        public Tempera(sbyte s,ConsoleColor c,string m):this(s)
        {
            this._marca = m;
        }
        #endregion
        #region metodos
        private string Mostrar()
        {
            string cadena;

            cadena =this._cantidad.ToString()+" "+this._color.ToString()+" "+this._marca;

            return cadena;
        }
        #endregion
        #region sobrecargas
        public static implicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static explicit operator sbyte(Tempera t)
        {
            return t._cantidad;
        }

        public static bool operator ==(Tempera t1,Tempera t2)
        {
            if((object)t1!=null && (object)t2 != null)
            {
 return t1._color == t2._color && t1._marca == t2._marca;
            }
            return false;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            if ((object)t1 != null && (object)t2 != null)
            {
                return !(t1._color == t2._color && t1._marca == t2._marca);
            }
            return false;
        }

        public static Tempera operator +(Tempera t, sbyte s)
        {
            Tempera t2 = new Tempera((sbyte)t._cantidad,t._color,t._marca);

            if ((object)t != null)
            {
               t2._cantidad= t._cantidad += s;
            }
            return t2;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera t3 = new Tempera((sbyte)t1._cantidad,t1._color,t1._marca);

            if ((object)t1 != null && (object)t2!=null )
            {
                if(t1==t2)
                {
                    t3._cantidad += t2._cantidad;
                }
            }
            return t3;
        }
        #endregion
    }
}

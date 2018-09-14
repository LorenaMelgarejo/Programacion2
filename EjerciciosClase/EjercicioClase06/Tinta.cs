using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tinta
    {
        #region atributos
        private ConsoleColor _color;
        private ETipoTinta _tipo;
        #endregion

        #region constructor
        public Tinta()
            {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillito;
            }

        public Tinta(ConsoleColor a) :this()
        {
            this._color = a;
        }

        public Tinta(ConsoleColor c, ETipoTinta t) :this(c)
        {
            this._tipo = t;
        }
        #endregion

        #region metodos
        public static string Mostrar(Tinta tinta)
        {
            if ((object)tinta != null) // O se puede hacer if(!objec.Equals(tinta,null))
            {
                return tinta.Mostrar();
            }
            return "-";
        }

        private  string Mostrar()
        {
            string retorno;

            retorno = this._color.ToString() + " " + this._tipo.ToString();
            return retorno;
        }
        #endregion

        #region sobrecargaOperadores
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            if ((object)t1!=null && (object)t2 != null)
            {
                return t1._tipo == t2._tipo && t1._color == t2._color;
            }
            return false;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            if ((object)t1 != null && (object)t2 != null)
            {
                return !(t1._tipo == t2._tipo && t1._color == t2._color);
            }
            return false;
        }
        #endregion
    }
}

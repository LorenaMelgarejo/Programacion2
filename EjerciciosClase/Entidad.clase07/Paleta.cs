using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad.clase07
{
    public class Paleta
    {
        #region atributos
        private Tempera[] _colores;
        private int _cantMaximaElementos;
        #endregion
        #region constructores
        public Paleta():this(5)
        {
        }

        public Paleta(int i)
        {
            this._cantMaximaElementos = i;
            this._colores = new Tempera[this._cantMaximaElementos];
        }
        #endregion
        #region metodos
        private string Mostrar()
        {
            string cadena= this._cantMaximaElementos.ToString();

            foreach(Tempera index in this._colores)
            {
                cadena += index;
            }
            
           return cadena;
        }

        private int ObtenerIndice()
        {
            int indice=-1;
            int i=0;

            foreach(Tempera t in this._colores)
            {
                if (this._colores.GetValue(i)==null)
                {
                    indice = i;
                    break;
                }
                    i++;
            }
           return indice;
        }

        private int ObtenerIndice(Tempera t) 
        {
            int indice=-1;
            int i = 0;

            foreach (Tempera item in this._colores)
            {
                if (this._colores.GetValue(i) != null)
                {
                    if(t==item)
                    {
                        indice = i;
                        break;
                    }
                }
                i++;
            }

            return indice;
        }
        #endregion
        #region sobrecarga
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static implicit operator Paleta(int i)
        {
            return new Paleta(i);
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            int i;
            bool flag = false;

                for(i=0;i<p._cantMaximaElementos;i++)
                {
                    if(p._colores.GetValue(i)!=null)
                    {
                        if(p._colores[i]==t)
                        {
                            flag = true;
                            break;
                        }
                    }
                }

            return flag;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            int i;
            bool flag = true;

            for (i = 0; i < p._cantMaximaElementos; i++)
            {
                if (p._colores.GetValue(i) != null)
                {
                    if (p._colores[i] == t)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return flag;
        }

        public static Paleta operator +(Paleta p,Tempera t)
        {
            int indice = -1;

            if(p==t)
            {
                indice = p.ObtenerIndice(t);
                p._colores[indice] += t;
            }
            else
            {
                indice = p.ObtenerIndice();
                if(indice>-1)
                {
                    p._colores[indice] = t;
                }
            }
            return p;
        }

        public static Paleta operator -(Paleta p,Tempera t)
        {
            int i;
            int indice=-1;
            sbyte aux1;
            sbyte aux2;

                for(i=0;i<p._cantMaximaElementos;i++)
                {
                if (p == t)
                { 
                    indice = p.ObtenerIndice(t);
                    aux1 = (sbyte)p._colores[indice];
                    aux2 = (sbyte)t;
                    
                    if(aux1-aux2<=0)
                    {
                        p._colores[indice] = null;
                    }
                    else
                    {
                        p._colores[indice] += (sbyte)(aux2 * -1);
                    }
                }
                }
            return p;
        }
        #endregion
    }
}

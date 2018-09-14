using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        #region atributos
        public string cadena;
        public double numero;
        public DateTime fecha;
        #endregion

        #region constructores
        public Cosa()
        {
            this.cadena = "SinValor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(string c) :this()
        {
            this.cadena = c;
        }
        #endregion

        #region metodos
        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar();
        }

        private string Mostrar()
        {
            return this.cadena +" "+ this.numero.ToString() +" "+ this.fecha.ToLongDateString();
        }

        public void EstablecerValor(string a)
        {
            this.fecha = DateTime.Now;
            this.numero=1.9;
        }
        
        #endregion
    }
}

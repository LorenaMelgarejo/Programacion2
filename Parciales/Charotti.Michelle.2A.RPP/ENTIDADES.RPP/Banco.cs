using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    public abstract class Banco
    {
        public string nombre;

        public Banco(string nom) { nombre = nom; }

        public abstract string Mostrar();
        public abstract string Mostrar(Banco b);
    }
}

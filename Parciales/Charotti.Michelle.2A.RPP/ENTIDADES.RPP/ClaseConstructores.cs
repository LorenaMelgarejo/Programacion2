using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTIDADES.RPP
{
    //Crear una clase (ClaseConstructores) que al instanciarse:
    //    1)pase por un constructor estático
    //    2)pase por un constructor que reciba 2 parámetros (privado)
    //    3)pase por un constructor publico (default)
    //    4)pase por una propiedad de sólo escritura
    //    5)pase por una propiedad de sólo lectura
    //    6)pase por un método de instancia
    //    7)pase por un método de clase
    //NOTA: el orden no se puede alterar.
    //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
    //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
    //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
    public class ClaseConstructores
    {
        private static string nombre;
        private string nombre2;

        static ClaseConstructores()
        {
            ClaseConstructores.nombre = "michelle";
            MessageBox.Show("constructor estatico");
        }
        private ClaseConstructores(string p1, string p2)
        {
            ClaseConstructores.nombre = p1;
            this.nombre2=p2;
            MessageBox.Show("constructor privado con dos parametros");
        }
        public ClaseConstructores() : this("nombre1", "nombre2")
        {
            MessageBox.Show("constructor default");
        }

        public string Nombre
        {
            get
            {
                MessageBox.Show("propiedad solo lectura");
                return nombre2;
            }
        }
        public string Nombre2
        {
            set
            {
                MessageBox.Show("propiedad solo escritura");
                this.nombre2 = value;
            }

        }

        private static string Mostrar1()
        {
            MessageBox.Show("metodo de instancia");
            
            return ClaseConstructores.nombre;
        }

        public string Mostrar()
        {
            MessageBox.Show("metodo de clase");
            return this.Nombre;
        }
    }
}


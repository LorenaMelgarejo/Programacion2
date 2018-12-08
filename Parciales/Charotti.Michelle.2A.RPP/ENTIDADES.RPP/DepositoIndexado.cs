using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    //A partir de la clase depósito, crear la clase DepositoIndexado, modificando
    //el modificador de visibilidad del atributo productos (a privado)
    //Generar un indexador sobre DepositoIndexado. Por defecto, de 3 elementos.
    //Aplicar las validaciones necesarias.
    public class DepositoIndexado:Deposito
    {
        private Producto[] producto2;

        public DepositoIndexado()
        {
           this.producto2 = new Producto[3];
        }
        public DepositoIndexado(int num) : this()
        {
            if (num >= 0 && num<3)
            {
                for (int i = 0; i < num; i++)
                {
                    this.producto2[i] = this.productos[i];
                }
            }
        }

        public Producto this[int indice]
        {
            get
            {
                if (indice >= this.productos.GetLength(0) || indice < 0)
                    return null;
                else
                    return this.productos[indice];
            }
            set
            {
                if (indice >= 0 && indice < this.productos.GetLength(0))
                    this.productos[indice] = value;
                else if (indice == this.productos.GetLength(0))
                {

                    this.productos = this + indice;
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }

        public static Producto[] operator +(DepositoIndexado depo, int indice)
        {
            int i = indice >= depo.productos.GetLength(0) ? ++indice : --indice;

            Producto[] aux = new Producto[i];

            depo.productos.CopyTo(aux, 0);

            return aux;

        }
    }
}

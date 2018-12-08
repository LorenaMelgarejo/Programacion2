using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    public class Deposito
    {
        public Producto[] productos;


        public Deposito() : this(3)
        {
        }
        public Deposito(int num)
        {
            this.productos = new Producto[num];
        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] array = new Producto[d1.productos.Length + d2.productos.Length];
            d1.productos.CopyTo(array, 0);
            d2.productos.CopyTo(array, d1.productos.Length);

            for (int i = 0; i < d1.productos.Length; i++)
            {
                array[i] = d1.productos[i];
            }
            for (int i = d1.productos.Length; i < d2.productos.Length + d1.productos.Length; i++)
            {
                array[i] = d2.productos[i - d1.productos.Length];
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] != null && array[j] != null)
                    {
                        if (array[i] == array[j])
                        {
                            array[i].stock += array[j].stock;
                            array[j] = null;
                        }
                    }
                }
            }

            return array;
        }

    }
}

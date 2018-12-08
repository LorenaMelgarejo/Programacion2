using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    //Agregar en la clase BancoMunicipal una sobrecarga en el implicit para que retorne todas
    //las características de la instancia en formato string. Aplicar polimorfismo sobre el método ToString
    //que deberá reutilizar código.
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio)
            : base(new BancoNacional(bp.nombre, bp.pais), bp.provincia)
        {
            this.municipio = municipio;
        }

        public override string Mostrar()
        {
            return "Banco Municipal";
        }

        public static implicit operator string(BancoMunicipal c)
        {
            return c.Mostrar(c);
        }
        public override string ToString()
        {
            return (string)this;
        }
    }
}

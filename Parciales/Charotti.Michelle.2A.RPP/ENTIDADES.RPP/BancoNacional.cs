using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    public class BancoNacional:Banco
    {
        public string pais;

        public BancoNacional(string nombre, string pais) : base(nombre) { this.pais = pais; }

        public override string Mostrar()
        {
            return "Banco Nacional";
        }

        public override string Mostrar(Banco b)
        {
            StringBuilder sb = new StringBuilder();

            if (b is BancoMunicipal)
            {

                sb.AppendLine(((BancoMunicipal)b).municipio);
                sb.AppendLine(((BancoMunicipal)b).nombre);
                sb.AppendLine(((BancoMunicipal)b).pais);
                sb.AppendLine(((BancoMunicipal)b).provincia);
            }
            else if (b is BancoProvincial)
            {

                sb.AppendLine(((BancoProvincial)b).nombre);
                sb.AppendLine(((BancoProvincial)b).pais);
                sb.AppendLine(((BancoProvincial)b).provincia);
            }
            else if (b is BancoNacional)
            {

                sb.AppendLine(((BancoNacional)b).nombre);
                sb.AppendLine(((BancoNacional)b).pais);
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Erros
{
    internal class Class2
    {

        public double Base { get; set; }

        public double Altura { get; set; }

        public double Area { get; set; }

       public double CalcularArea(double B, double H)
        {
            return Area = B * H;
        }

        public string Exibir()
        {
            return $"Valor total da área: { Area }";
        }
    }
}

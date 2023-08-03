using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Erros
{
    internal class Class1
    {

        private string animal { get; set; }
        private int coelho { get; set; }
        private int cachorro { get; set; }
        private int gato { get; set; }

        public void tipoAnimal(string animalTipo)
        {
            this.animal = animalTipo.ToLower();

            if (this.animal == "cachorro") this.cachorro++;
            else if (this.animal == "gato") this.gato++;
            else  this.coelho++;

        }

        public string qntiAnimais()
        {

            return $"Total de cachorros: {this.cachorro}; \n Total de gatos: {this.gato} \n Total de coelhos: {this.coelho} ";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Erros
{
    public class Class3
    {

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa()
            {
                Nome = "";
                Idade = 0;
            }

            public string Pessoas(string nome)
            {
                return Nome = nome;
            }

            public int Idades(int idade)
            {
                return Idade = idade;
            }

            public string ExibirDados()
            {
                return $"Nome: {Nome}\nIdade: {Idade}";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcionario
{
    public class Dependente
    {
        public string Nome;
        public int Idade;

        public Dependente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"{Nome}, {Idade} anos";
        }
    }
}

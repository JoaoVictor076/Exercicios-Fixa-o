using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcionario
{
    public class Funcionario
    {
        public string Nome;
        public string Cargo;
        public List<Dependente> Dependentes;

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Dependentes = new List<Dependente>();
        }

        public void AdicionarDependente(Dependente dependente)
        {
            Dependentes.Add(dependente);
        }

        public void RemoverDependente(Dependente dependente)
        {
            Dependentes.Remove(dependente);
        }

        public override string ToString()
        {
            string dependentes = "";
            foreach (Dependente dependente in Dependentes)
            {
                dependentes += $"  {dependente}\n";
            }
            return $"{Nome} ({Cargo}):\n  Dependentes:\n{dependentes}";
        }
    }
}

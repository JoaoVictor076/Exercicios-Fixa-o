using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_lista_02
{
         class Assalariado : Empregado
        {
        public Assalariado(string? nome, string? sobrenome, string? cpf, double salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Salario = salario;
        }

        public double Salario { get; set; }

        public override double Vencimento()
        {
            return Salario;
        }

    }
}

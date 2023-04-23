using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_lista_02
{
     class Horista : Empregado 
    {
        private double precoHora;

        public Horista(string? nome, string? sobrenome, string? cpf, double precoHora, double totalHoras)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            this.precoHora = precoHora;
            TotalHoras = totalHoras;
        }

        public double PrecoHoras {  get; set; }
        public double TotalHoras { get; set; }

        public override double Vencimento()
        {
            return PrecoHoras * TotalHoras;
        }
    }
}

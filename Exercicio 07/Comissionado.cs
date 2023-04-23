using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_lista_02
{
     class Comissionado : Empregado
    {
        private double comissao;

        public Comissionado(string? nome, string? sobrenome, string? cpf, double totalVendas, double comissao)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            TotalVendas = totalVendas;
            this.comissao = comissao;
        }

        public double TotalVendas { get; set; }
        public double TaxaComissao { get; set; }

        public override double Vencimento()
        {
            return TotalVendas * (TaxaComissao / 100);
        }
    }
}

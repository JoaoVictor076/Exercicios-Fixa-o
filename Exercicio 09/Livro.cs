using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    public class Livro
    {
        private string? nome;

        public Livro(string? isbn, string? nome, Autor autor, string? idioma, int edicao, DateTime dataLancamento)
        {
            ISBN = isbn;
            this.nome = nome;
            Autor = autor;
            Idioma = idioma;
            Edicao = edicao;
            DataLancamento = dataLancamento;
        }

        public string ISBN { get; set; }
        public string NomeLivro { get; set; }
        public Autor Autor { get; set; }
        public string Idioma { get; set; }
        public int Edicao { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}

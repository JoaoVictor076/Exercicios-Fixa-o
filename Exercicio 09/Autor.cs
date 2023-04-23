using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    public class Autor
    {
        private string? nomeAutor;
        private string? paisOrigemAutor;
        private DateTime dataNascimentoAutor;
        private string? idiomaNativoAutor;

        public Autor(string? nomeAutor, string? paisOrigemAutor, DateTime dataNascimentoAutor, string? idiomaNativoAutor)
        {
            this.nomeAutor = nomeAutor;
            this.paisOrigemAutor = paisOrigemAutor;
            this.dataNascimentoAutor = dataNascimentoAutor;
            this.idiomaNativoAutor = idiomaNativoAutor;
        }

        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public DateTime DataNascimento { get; set; }
        public string IdiomaNativo { get; set; }


    }
}

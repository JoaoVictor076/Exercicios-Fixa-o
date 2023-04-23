using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exercicio_03
{
    public class Impressora
    {
        private Documento _documento;
        
        public  Impressora(Documento documento)
        {
            _documento = documento;
            
        }

        public void Imprimir(int quantidade_impressao = 1)
        {
            for(int i = 1; i <= quantidade_impressao; i++)
            {
                Console.WriteLine(_documento.texto);
            }
        }

        public int SolicitarQuantidade()
        {
            Console.WriteLine("Digite a quantidade de copias : ");
            return int.Parse(Console.ReadLine());
            

        }

        public void SolicitarTexto()
        {
            Console.WriteLine("Digite o documento a ser impresso : ");
            string texto = Console.ReadLine();
            _documento = new Documento(texto);
        }

       

    }
}


using Exercicio_03;

Impressora impressao2 = new Impressora(null);
impressao2.SolicitarTexto();

Console.WriteLine("Digite a quantidade de copias : ");
int quantidade_impressao = int.Parse(Console.ReadLine());


impressao2.Imprimir(quantidade_impressao);




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
     class Hexagono : Forma
    {
        int lado;
        public override void CalcularArea()
        {
            Console.WriteLine(" Vamos calcular a area do hexagono !!");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o valor do lado : ");
            Console.WriteLine("\n");
            lado = int.Parse(Console.ReadLine());

            area = (3 * Math.Sqrt(3) * Math.Pow(lado, 2)) / 2;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine($"Esse é o area do hexagono :{area}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine(" Vamos calcular a perimetro do hexagono !!");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o valor do lado : ");
            Console.WriteLine("\n");
            lado = int.Parse(Console.ReadLine());

            perimetro = 6 * lado;

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine($"Esse é o perimetro do hexagono :{perimetro}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
    }
}

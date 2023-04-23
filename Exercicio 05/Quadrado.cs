using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
     class Quadrado : Forma
    { 

        public int lado;

        public override void CalcularArea()
        {
            Console.WriteLine(" Vamos calcular a area do quadrado !!");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o valor do lado : ");
            Console.WriteLine("\n");
            lado = int.Parse(Console.ReadLine());

            area = lado * lado;

            
            Console.WriteLine("\n");
            Console.WriteLine($"Esse é o area do quadrado :{area}");
            
            Console.WriteLine("\n");
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine(" Vamos calcular primeiro o perimetro do quadrado !!");
            Console.WriteLine("Digite o valor do lado : ");
            lado = int.Parse(Console.ReadLine());

            perimetro = lado * 4;

            
            Console.WriteLine("\n");
            Console.WriteLine($"Esse é o perimetro do quadrado :{perimetro}");
            Console.WriteLine("\n");
            
        }
    }
}

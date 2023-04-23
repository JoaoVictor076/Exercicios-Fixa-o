using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO;
     class Triangulo : Forma
    {   
        int ladoA;
        int ladoB;
        int ladoC;
        public int basetriagulo;
        public int altura;

        public override void CalcularArea()
        {
            Console.WriteLine(" Vamos calcular a area do triangulo !!");
            Console.WriteLine("Digite o valor da base : ");
            basetriagulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura : ");
            altura = int.Parse(Console.ReadLine());


            area = basetriagulo * altura / 2 ;

            Console.WriteLine("\n");

            Console.WriteLine("Valor da area é :" + area);

            Console.WriteLine("\n");

        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine(" Vamos calcular o perimetro do triangulo !!");
            Console.WriteLine("Digite o valor do lado A : ");
            ladoA= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B : ");
            ladoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C : ");
            ladoC = int.Parse(Console.ReadLine());

            perimetro = ladoA + ladoB + ladoC;
            Console.WriteLine("\n");

            Console.WriteLine("valor do perimetro : " + perimetro);

            Console.WriteLine("\n");
    }
    }


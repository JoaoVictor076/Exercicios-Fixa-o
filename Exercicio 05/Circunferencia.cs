using System;
using System.Drawing;
using System.Formats.Asn1;

namespace Exercicios_POO;




class Circunferencia : Forma
{

    public int raio;
   
    public override void CalcularArea()
        {
        Console.WriteLine(" Vamos calcular a area do circunferencia !!");
        Console.WriteLine("\n");
        Console.WriteLine("Digite o valor do raio : ");
        Console.WriteLine("\n");
        raio = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        area = Math.PI * Math.Pow(raio,2);

        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("Valor da area é :" + area);
        Console.WriteLine("\n");
        Console.WriteLine("\n");

    }

    public override void CalcularPerimetro()
    {
        Console.WriteLine(" Vamos calcular primeiro o perimetro da circunferencia !!");
        Console.WriteLine("\n");
        Console.WriteLine("Digite o valor do raio : ");
        Console.WriteLine("\n");
        raio = int.Parse(Console.ReadLine());

        perimetro = (int)(2 * Math.PI * raio);

        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("valor do perimetro : " + perimetro);
        Console.WriteLine("\n");
        Console.WriteLine("\n");
    }
}


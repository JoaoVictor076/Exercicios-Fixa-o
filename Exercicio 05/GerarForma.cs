namespace Exercicios_POO;

public class GerarForma

{

    public void SolicitarForma()
    {


        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Calcular área e perímetro de um hexagono");
        Console.WriteLine("2 - Calcular área e perímetro de um circulo");
        Console.WriteLine("3 - Calcular área e perímetro de um triangulo");
        Console.WriteLine("4 - Calcular área e perímetro de um quadrado");
        Console.WriteLine("0 - Sair");



    }

    public void ExecutarMenuSolicitarForma()
    {

        int opcao = -1;

        while (opcao != 0)
        {
            GerarForma menu = new GerarForma();

            menu.SolicitarForma();


            if (int.TryParse(Console.ReadLine(), out opcao))
            {


                switch (opcao)
                {
                    case 1:
                        Hexagono calc_hexagono = new Hexagono();

                        calc_hexagono.CalcularPerimetro();
                        calc_hexagono.CalcularArea();

                        break;

                    case 2:
                        Circunferencia calc_circunferencia = new Circunferencia();
                        calc_circunferencia.CalcularPerimetro();
                        calc_circunferencia.CalcularArea();

                        break;

                    case 3:
                        Triangulo calc_triagulo = new Triangulo();
                        calc_triagulo.CalcularArea();
                        calc_triagulo.CalcularPerimetro();

                        break;

                    case 4:

                        Quadrado calc_quadrado = new Quadrado();

                        calc_quadrado.CalcularArea();
                        calc_quadrado.CalcularPerimetro();

                        break;

                }
            }
            else
            {
                Console.WriteLine("Opção Invalida !");
            }

            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para sair ...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}


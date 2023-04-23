using Exercicios_lista_02;

Console.WriteLine("========== Cadastro de Empregado ==========");
Console.Write("Digite o nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o sobrenome: ");
string sobrenome = Console.ReadLine();

Console.Write("Digite o CPF: ");
string cpf = Console.ReadLine();

Console.Write("Digite o tipo de empregado (Assalariado, Comissionado ou Horista): ");
string tipoEmpregado = Console.ReadLine();

double salario = 0, totalVendas = 0, comissao = 0, precoHora = 0, totalHoras = 0;

switch (tipoEmpregado)
{
    case "Assalariado":
        Console.Write("Digite o salário: ");
        salario = double.Parse(Console.ReadLine());
        break;
    case "Comissionado":
        Console.Write("Digite o total de vendas: ");
        totalVendas = double.Parse(Console.ReadLine());
        Console.Write("Digite a comissão: ");
        comissao = double.Parse(Console.ReadLine());
        break;
    case "Horista":
        Console.Write("Digite o preço da hora: ");
        precoHora = double.Parse(Console.ReadLine());
        Console.Write("Digite o total de horas trabalhadas: ");
        totalHoras = double.Parse(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Tipo de empregado inválido.");
        return;
}

Empregado empregado = null;

switch (tipoEmpregado)
{
    case "Assalariado":
        empregado = new Assalariado(nome, sobrenome, cpf, salario);
        break;
    case "Comissionado":
        empregado = new Comissionado(nome, sobrenome, cpf, totalVendas, comissao);
        break;
    case "Horista":
        empregado = new Horista(nome, sobrenome, cpf, precoHora, totalHoras);
        break;
}

Console.WriteLine($"O vencimento de {empregado.Nome} é: {empregado.Vencimento():C}");
        
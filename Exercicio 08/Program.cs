using Exercicio_Funcionario;

Controle controle = new Controle();
Funcionario func1 = new Funcionario("João", "Gerente");
func1.AdicionarDependente(new Dependente("Maria", 10));
func1.AdicionarDependente(new Dependente("Pedro", 8));
controle.AdicionarFuncionario(func1);

Funcionario func2 = new Funcionario("Ana", "Analista");
func2.AdicionarDependente(new Dependente("Mariana", 5));
controle.AdicionarFuncionario(func2);

controle.ListarDependentes(func1);
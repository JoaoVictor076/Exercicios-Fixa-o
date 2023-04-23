using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_Funcionario
{
    public class Controle
    {

        public List<Funcionario> Funcionarios;

        public Controle()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }

        public void AdicionarDependente(Funcionario funcionario, Dependente dependente)
        {
            funcionario.AdicionarDependente(dependente);
        }

        public void RemoverDependente(Funcionario funcionario, Dependente dependente)
        {
            funcionario.RemoverDependente(dependente);
        }

        public void ListarDependentes(Funcionario funcionario)
        {
            Console.WriteLine(funcionario);
        }
    }
   


    
}

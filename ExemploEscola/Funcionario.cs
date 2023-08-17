using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEscola
{
    public class Funcionario
    {
        public string nomeFunc;
        public string cargoFunc;
        public double salarioFunc;

        public void AumentarSalario(double valor)
        {
            salarioFunc = salarioFunc + valor;
        }
        public void ConsultarInformacoesFuncionario()
        {
            Console.WriteLine("\t\t---Informações Funcionário---\n");
            Console.WriteLine($"Nome: {nomeFunc}\n" +
                $"Cargo: {cargoFunc}\n" +
                $"Salário: {salarioFunc}");
        }
    }
}

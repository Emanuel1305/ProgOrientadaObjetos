using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Funcionario
    {
        public string nomeFunc;
        public double salarioFunc;

        public void AumentarSalario(int taxa)
        {
            salarioFunc = salarioFunc + (salarioFunc * taxa / 100);
        }
        public void ImprimirDados()
        {
            Console.WriteLine("\n\t\t---Imprimi os dados do funcionario---\n\n");
            Console.WriteLine($"Nome: {nomeFunc}\nSalário: {salarioFunc:c2}");
        }       
    }
}

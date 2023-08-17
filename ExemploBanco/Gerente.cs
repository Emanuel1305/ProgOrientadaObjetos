using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Gerente
    {
        public double salario;
        public void AumentarSalario()
        {
            AumentarSalario(10);
        }
        public void AumentarSalario(double taxa)
        {
            double aumento = salario * (taxa / 100);
            salario = salario + aumento;
        }
        public void ImprimirInformacoesGerente()
        {
            Console.WriteLine("\t\t---Informações gerente---\n");
            Console.WriteLine($"Salario: {salario}");
        }
    }
}

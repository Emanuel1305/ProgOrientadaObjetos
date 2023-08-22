using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Gerente
    {
        public string nomeGeren;
        public double salarioGeren;
        public void AumentarSalario()
        {
            AumentarSalario(10);
        }
        public void AumentarSalario(double taxa)
        {
            double aumento = salarioGeren * (taxa / 100);
            salarioGeren = salarioGeren + aumento;
        }
        public void ImprimirInformacoesGerente()
        {
            Console.WriteLine("\t\t---Informações gerente---\n\n");
            Console.Write($"Nome: {nomeGeren}\nSalario: {salarioGeren:c2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImuladorPessoa
{
    internal class Program
    {
        static Pessoa pessoa1 = new Pessoa("", 0, 0);
        static void Main(string[] args)
        {
            Console.WriteLine("\t---Simulador De Pessoa---\n");
            pessoa1.ImprimirInformacoes();
            Console.ReadKey();
        }
    }
}

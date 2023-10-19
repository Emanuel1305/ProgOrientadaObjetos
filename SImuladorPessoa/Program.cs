using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SImuladorPessoa
{
    internal class Program
    {
        static Pessoa pessoa1 = new Pessoa("", 0, 0);
        static void Main(string[] args)
        {
            int opc;
            do
            {
                opc = 0;
                Console.WriteLine("\t---Simulador De Pessoa---\n");
                pessoa1.ImprimirInformacoes();
                Console.Write("\n[1] Alterar Nome\t[5] Engordar\n" +
                    "[2] Alterar Peso\t[6] Emagrecer\n" +
                    "[3] Alterar Altura\t[7] Envelhecer\n" +
                    "[4] Alterar Idade\t[8] Crescer\n" +
                    "\n[9] SAIR\n\n" +
                    "Qual opção deseja execultar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("informe o novo nome: ");
                        string nome = Console.ReadLine();
                        pessoa1.Nome = nome;
                        break;
                    case 2:
                        Console.Write("informe o novo peso: ");
                        double peso = Double.Parse(Console.ReadLine());
                        pessoa1.Peso = peso;
                        break;
                    case 3:
                        Console.Write("informe a nova altura: ");
                        double altura = Double.Parse(Console.ReadLine());
                        pessoa1.Altura = altura;
                        break;
                    case 4:
                        Console.Write("informe a nova idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        pessoa1.Idade = idade;
                        break;
                    case 5:
                        pessoa1.Engordar();
                        break;
                    case 6:
                        pessoa1.Emagrecer();
                        break;
                    case 7:
                        pessoa1.Envelhecer();
                        break;
                    case 8:
                        pessoa1.Crescer();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opc != 9);
            Console.ReadKey();
        }
    }
}

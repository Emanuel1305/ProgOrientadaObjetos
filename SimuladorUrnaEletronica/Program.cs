using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorUrnaEletronica
{
    internal class Program
    {
        static Candidatos cand1 = new Candidatos(13, "Luiz Inácio Lula da Silva");
        static Candidatos cand2 = new Candidatos(22, "Jair Messias Bolsonaro");
        static Candidatos cand3 = new Candidatos(14, "Kelmon Luís da Silva Souza ");
        static void Main(string[] args)
        {
            int opc;
            do
            {
                opc = 0;
                Console.WriteLine("\t\t---Urna Eletrônica---\n\n");

                Console.WriteLine("\t\t--Candidatos--\n" +
                    "\n13 - Luiz Inácio Lula da Silva\n" +
                    "14 - Kelmon Luís da Silva Souza\n" +
                    "22 - Jair Messias Bolsonaro\n");

                Console.Write("\n[1] Votar\n" +
                    "[2] Ver quantidade de votos\n" +
                    "[3] Sair\n" +
                    "Informe a opção deseja execultar: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.Write("\nInforme o numero do candidato que deseja votar: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Informe a quantidade de votos que deseja adicionar: ");
                    int qtVotos = int.Parse(Console.ReadLine());
                    AdicionarVotos(num, qtVotos);
                } else if (opc == 2)
                {
                    ImprimirVotos();
                }
                Console.Clear();

            } while (opc != 3);
            Console.WriteLine("Programa Finalizado!");
            Console.ReadKey();
        }
        public static void AdicionarVotos(int numero, int qntdVotos)
        {
            if (numero == 13)
            {
                cand1.IncrementraVotos(qntdVotos);
            }else if (numero == 14)
            {
                cand2.IncrementraVotos(qntdVotos);
            }else if (numero == 22)
            {
                cand3.IncrementraVotos(qntdVotos);
            }
            else
            {
                Console.WriteLine("Numero inválido");
            }
        }
        public static void ImprimirVotos()
        {
            Console.Write("\n\n\t\t---Quantidade de Votos---\n\n");
            Console.WriteLine($"Luiz Inácio Lula da Silva\t{cand1.NumeroVotos} votos\n" +
                $"Kelmon Luís da Silva Souza\t{cand2.NumeroVotos} votos\n" +
                $"Jair Messias Bolsonaro\t\t{cand3.NumeroVotos} votos");
            Console.ReadKey();
        }
    }
}

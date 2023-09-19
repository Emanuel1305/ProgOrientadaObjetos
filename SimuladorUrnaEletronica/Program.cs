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

                Console.WriteLine("\t\t---Urna Eletrônica---\n");

                Console.Write("\n[1] Votar\n" +
                    "[2] Votar em massa\n" +
                    "[3] Visualizar quantidade de votos\n" +
                    "[4] Lista de candidatos\n" +
                    "[5] Sair\n" +
                    "Informe a opção deseja execultar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Votar();
                        break;
                    case 2:
                        Console.Write("\nInforme a quantidade de votos que deseja adicionar: ");
                        int valor = int.Parse(Console.ReadLine());
                        Votar(valor);
                        break;
                    case 3:
                        ImprimirVotos();
                        break;
                    case 4:
                        MostrarListaDeCandidatos();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nAperte qualquer tecla para continuar!");
                Console.Clear();

            } while (opc != 5);

            Console.WriteLine("Programa Finalizado!");
            Console.ReadKey();
        }
        public static void Votar()
        {
            MostrarListaDeCandidatos();
            Console.Write("\nInforme o numero do candidato que deseja votar: ");
            int num = int.Parse(Console.ReadLine());
            AdicionarVotos(num, 1);
        }
        public static void Votar(int v)
        {
            MostrarListaDeCandidatos();
            Console.Write($"\nInforme o numero do candidato o qual deseja adicionar {v} votos: ");
            int num = int.Parse(Console.ReadLine());
            AdicionarVotos(num, v);
        }
        public static void AdicionarVotos(int numero, int qntdVotos)
        {
            switch (numero)
            {
                case 13:
                    cand1.IncrementraVotos(qntdVotos);
                    break;
                case 14:
                    cand2.IncrementraVotos(qntdVotos);
                    break;
                case 22:
                    cand3.IncrementraVotos(qntdVotos);
                    break;
                default:
                    Console.WriteLine("Numero inválido");
                    break;
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
        public static void MostrarListaDeCandidatos()
        {
            Console.Clear();
            Console.WriteLine("\t\t---Urna Eletrônica---\n\n");

            Console.WriteLine("\t\t--Candidatos--\n" +
                "\n13 - Luiz Inácio Lula da Silva\n" +
                "14 - Kelmon Luís da Silva Souza\n" +
                "22 - Jair Messias Bolsonaro\n");
        }
    }
}

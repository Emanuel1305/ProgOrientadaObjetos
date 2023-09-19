using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorUrnaEletronica
{
    internal class Program
    {
        static Candidatos cand1 = new Candidatos(12, "Ciro Gomes");
        static Candidatos cand2 = new Candidatos(13, "Luiz Inácio Lula");
        static Candidatos cand3 = new Candidatos(14, "Padre Kelmon");
        static Candidatos cand4 = new Candidatos(15, "Simone Tebet");
        static Candidatos cand5 = new Candidatos(16, "Vera"); 
        static Candidatos cand6 = new Candidatos(22, "Jair Bolsonaro");
        static Candidatos cand7 = new Candidatos(44, "Soraya Thronicke");
        
        static void Main(string[] args)
        {
            int opc;

            do
            {
                opc = 0;

                Console.WriteLine("\t     ---Urna Eletrônica---\n");

                Console.Write("\n[1] Votar\n" +
                    "[2] Votar em massa\n" +
                    "[3] Visualizar quantidade de votos\n" +
                    "[4] Lista de candidatos\n" +
                    "[5] Sair\n" +
                    "\nInforme a opção deseja execultar: ");
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
                case 12:
                    cand1.IncrementraVotos(qntdVotos);
                    break;
                case 13:
                    cand2.IncrementraVotos(qntdVotos);
                    break;
                case 14:
                    cand3.IncrementraVotos(qntdVotos);
                    break;
                case 15:
                    cand4.IncrementraVotos(qntdVotos);
                    break;
                case 16:
                    cand5.IncrementraVotos(qntdVotos);
                    break;
                case 22:
                    cand6.IncrementraVotos(qntdVotos);
                    break;
                case 44:
                    cand7.IncrementraVotos(qntdVotos);
                    break;
                default:
                    Console.WriteLine("Numero inválido");
                    break;
            }
        }
        public static void ImprimirVotos()
        {
            Console.Write("\n\n\t---Quantidade de Votos---\n\n");
            Console.WriteLine(
                $"=====================================\n" +
                $"{cand1.Nome} \t\t{cand1.NumeroVotos} votos\n" +
                $"{cand2.Nome} \t{cand2.NumeroVotos} votos\n" +
                $"{cand3.Nome} \t\t{cand3.NumeroVotos} votos\n" +
                $"{cand4.Nome} \t\t{cand4.NumeroVotos} votos\n" +
                $"{cand5.Nome} \t\t\t{cand5.NumeroVotos} votos\n" +
                $"{cand6.Nome} \t\t{cand6.NumeroVotos} votos\n" +
                $"{cand7.Nome} \t{cand7.NumeroVotos} votos\n" +
                $"=====================================");
            Console.ReadKey();
        }
        public static void MostrarListaDeCandidatos()
        {
            Console.Clear();
            Console.WriteLine("\t     ---Urna Eletrônica---\n");

            Console.WriteLine("\t\t--Candidatos--\n\n" +
                "    <==============================>\n" +
                $"\t{cand1.Numero} -\t{cand1.Nome}\n" +
                $"\t{cand2.Numero} -\t{cand2.Nome}\n" +
                $"\t{cand3.Numero} -\t{cand3.Nome}\n" +
                $"\t{cand4.Numero} -\t{cand4.Nome}\n" +
                $"\t{cand5.Numero} -\t{cand5.Nome}\n" +
                $"\t{cand6.Numero} -\t{cand6.Nome}\n" +
                $"\t{cand7.Numero} -\t{cand7.Nome}\n" +
                "    <==============================>");
        }
    }
}

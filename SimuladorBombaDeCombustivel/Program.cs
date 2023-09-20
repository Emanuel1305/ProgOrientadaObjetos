using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBombaDeCombustivel
{
    internal class Program
    {
        static BombaDeCombustivel bomba1 = new BombaDeCombustivel("Diesel", 10);
        static void Main(string[] args)
        {
            int opc = 0;

            do
            {
                Console.WriteLine("\t\t---Teste de Bomba---\n");
                bomba1.MostarInformacoesBomba();

                Console.WriteLine("");
                Console.Write("\n" +
                    "[1] Abastecer Por Valor\n" +
                    "[2] Abastecer por Litro\n" +
                    "[3] Alterar Valor\n" +
                    "[4] Alterar Combustivel\n" +
                    "[5] Alterar Quantidade de Combustivel\n" +
                    "[6] Sair");
                Console.Write("\n\nQual opção deseja realizar: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        AbastecerPorValor();
                        break;
                    case 2:
                        AbastecerPorLitro();
                        break;
                    case 3:
                        AlterarValor();
                        break;
                    case 4:
                        AlterarCombustivel();
                        break;
                    case 5:
                        AlterarQualtidadeDeCombustivel();
                        break;
                    default:
                        Console.WriteLine("O programa será encerrado!!");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();

            } while (opc != 6);
            Console.ReadKey();
        }

        private static void AlterarQualtidadeDeCombustivel()
        {
            Console.Write("Informe qual será a nova quantidade de combustivel: ");
            double quant = double.Parse(Console.ReadLine());
            bomba1.AlterarQuantidadeDeCombustivel(quant);
            Console.WriteLine("\nNova quantidade: " + bomba1.QuantidadeCombustivel);
            Console.ReadKey();
        }

        private static void AlterarCombustivel()
        {
            Console.Write("Informe qual será o novo tipo de combustivel: ");
            string tipo = Console.ReadLine();
            bomba1.AlterarCombustivel(tipo);
            Console.WriteLine("\nNovo tipo: " + bomba1.TipoCombustivel);
            Console.ReadKey();
        }

        private static void AlterarValor()
        {
            Console.Write("Informe qual será o novo preço: ");
            double preco = double.Parse(Console.ReadLine());
            bomba1.AlterarValor(preco);
            Console.WriteLine($"\nNovo valor: {bomba1.ValorLitro:c2}");
            Console.ReadKey();
        }

        private static void AbastecerPorLitro()
        {
            Console.Write("Informe a quantidade de litros que deseja abastecer: ");
            double litros = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor cobrado: {bomba1.AbastecerPorLitro(litros):c2}");
            Console.ReadKey();
        }

        private static void AbastecerPorValor()
        {
            Console.Write("Informe o valor que deseja abastecer: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine($"Quantidade de litros adicionados: {bomba1.AbastecerPorValor(valor)} litros");
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                opc = 0;
                Console.WriteLine("\t\t---Calcular a area do retangulo---\n");
                Console.Write("X - ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Y - ");
                double y = double.Parse(Console.ReadLine());
                Retangulo retangulo = new Retangulo(x, y);

                Console.Write($"\nArea = {retangulo.Area} metros quadrados");

                Console.Write("\n\nDeseja realizar outra operação: \n" +
                    "[1] sim\n" +
                    "[2] não\n");
                
                opc = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (opc != 2);
            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Program
    {
        static Retangulo local = new Retangulo(0, 0);
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calucula quantidade de pisos e de rodapés necessárias para o local---\n\n");
            Console.Write("Qual as medidas deste local\nLado A: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            double ladoB = double.Parse(Console.ReadLine());
            CalcularMateriaisRetangulo(ladoA, ladoB);

            
        }
        static void CalcularMateriaisRetangulo(double lado1, double lado2)
        {
            local.LadoA = lado1;
            local.LadoB = lado2;

            Console.Write("\nQual a altura do rodapé que deseja colocar: ");
            double alturaRod = double.Parse(Console.ReadLine());
            Console.Write($"\nPrecisará de...\n{local.Area} metros quadrados de piso\n" +
                $"{local.Perimetro * alturaRod} metros quadrados de rodapé");

            Console.ReadKey();
        }
    }
}

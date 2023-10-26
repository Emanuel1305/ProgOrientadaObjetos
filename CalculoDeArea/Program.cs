using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    internal class Program
    {
        static double baseTriangulo = 50;
        static double alturaTriangulo = 25;

        static double ladoARetangulo = 100;
        static double ladoBRetangulo = 50;

        static double ladoQuadrado = 70;

        static double raioCirculo = 10;

        static Triangulo t = new Triangulo(baseTriangulo, alturaTriangulo);
        static Retangulo r = new Retangulo(ladoARetangulo, ladoBRetangulo);
        static Quadrado q = new Quadrado(ladoQuadrado);
        static Circulo c = new Circulo(raioCirculo);
        static void Main(string[] args)
        {
            Console.WriteLine("\t---Calcular Area---\n");
            Console.WriteLine($"" +
                $"--TRIANGULO--" +
                $"\nBASE\t{baseTriangulo}" +
                $"\nALTURA\t{alturaTriangulo}" +
                $"\nAREA\t{t.Area}" +
                $"\n\n--RETANGULO--" +
                $"\nLADO-A\t{ladoARetangulo}" +
                $"\nLADO-B\t{ladoBRetangulo}" +
                $"\nAREA\t{r.Area}" +
                $"\n\n--QUADRADO--" +
                $"\nLADO\t{ladoQuadrado}" +
                $"\nAREA\t{q.Area}" +
                $"\n\n--CIRCULO--" +
                $"\nRAIO\t{raioCirculo}" +
                $"\nAREA\t{c.Area}");

            Console.ReadKey();
        }
    }
}

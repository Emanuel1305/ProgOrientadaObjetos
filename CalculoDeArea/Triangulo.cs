using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    public class Triangulo : IAreaCalculavel
    {
        private double base1;
        private double altura;
        private double area;

        public Triangulo(double base1, double altura)
        {
            Base1 = base1;
            Altura = altura;
            CalcularArea();
        }

        public double Base1 { get => base1; set => base1 = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Area { get => area; }

        public void CalcularArea()
        {
            this.area = (Base1 * Altura) / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    public class Quadrado : IAreaCalculavel
    {
        private double lado;
        private double area;

        public Quadrado(double lado)
        {
            Lado = lado;
            CalcularArea();
        }

        public double Lado { get => lado; set => lado = value; }
        public double Area { get => area; }

        public void CalcularArea()
        {
            this.area = Lado * Lado;
        }
    }
}

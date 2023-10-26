using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    public class Retangulo : IAreaCalculavel
    {
        private double ladoA;
        private double ladoB;
        private double area;

        public Retangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            CalcularArea();
        }

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double Area { get => area; }

        public void CalcularArea()
        {
            this.area =  LadoA * LadoB;
        }
    }
}

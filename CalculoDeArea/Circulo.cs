using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    public class Circulo : IAreaCalculavel
    {
        private double raio;
        private double area;

        public Circulo(double raio)
        {
            Raio = raio;
            CalcularArea();
        }

        public double Raio { get => raio; set => raio = value; }
        public double Area { get => area; }

        public void CalcularArea()
        {
            this.area = 3.14 * (Raio * Raio);
        }
    }
}

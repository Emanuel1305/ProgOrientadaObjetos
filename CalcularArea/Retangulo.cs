using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    public class Retangulo
    {
        private double x;
        private double y;
        private double area;

        public Retangulo(double x, double y)
        {
            X = x;
            Y = y;
            CalcularArea();
        }
        private void CalcularArea()
        {
            Area = X * Y;
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0)
                {
                    x = value;
                }
                else
                {
                    Console.WriteLine("\nA altura deve ser maior que zero.");
                }
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                { 
                    Console.WriteLine("\nA altura deve ser maior que zero.");
                }
            }
        }
        public double Area { get => area; set => area = value; }


    }
}

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
                return X;
            }
            set
            {
                if (value > 0)
                {
                    X = value;
                }
                else
                {
                    Console.WriteLine("A altura deve ser maior que zero.");
                }
            }
        }
        public double Y
        {
            get
            {
                return Y;
            }
            set
            {
                if (value > 0)
                {
                    Y = value;
                }
                else
                { 
                    Console.WriteLine("A altura deve ser maior que zero.");
                }
            }
        }
        public double Area { get => area; set => area = value; }


    }
}

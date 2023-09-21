using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Retangulo
    {
        private double ladoA;
        private double ladoB;
        private double area;
        private double perimetro;

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public Retangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            CalcularPerimetro();
            
        }

        public void MudarValorDosLados(double nvLadoA, double nvLadoB)
        {
            LadoA = nvLadoA;
            LadoB = nvLadoB;
        }

        public void CalcularArea()
        {
            Area = LadoA * LadoB;
        }

        public void CalcularPerimetro()
        {
            Perimetro = (LadoA * 2) + (LadoB * 2);
        }

    }
}

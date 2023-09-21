using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Quadrado
    {
        private double tamanhoDoLado;
        private double perimetro;
        private double area;

        public double TamanhoDoLado { get => tamanhoDoLado; set => tamanhoDoLado = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }
        public double Area { get => area; set => area = value; }

        public Quadrado(double tamanhoDoLado)
        {
            TamanhoDoLado = tamanhoDoLado;
            CalcularPerimetro();
            CalcularArea();
        }

        public void MudarValorDoLado(double nvValor)
        {
            TamanhoDoLado = nvValor;
        }

        public void CalcularPerimetro()
        {
            Perimetro = TamanhoDoLado * 4;
        }

        public void CalcularArea()
        {
             Area = TamanhoDoLado * 2;
        }
    }
}

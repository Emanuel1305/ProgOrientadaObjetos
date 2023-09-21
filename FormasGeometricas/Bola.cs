using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Bola
    {
        private string cor;
        private double circunferencia;
        private string material;

        public Bola(string cor, double circunferencia, string material)
        {
            Cor = cor;
            Circunferencia = circunferencia;
            Material = material;
        }

        public string Cor { get => cor; set => cor = value; }
        public double Circunferencia { get => circunferencia; set => circunferencia = value; }
        public string Material { get => material; set => material = value; }

        public void AlterarCor(string nvCor)
        {
            Cor = nvCor;
        }

        public string MostrarCor()
        {
            return Cor;
        }
    }
}

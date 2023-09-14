using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorUrnaEletronica
{
    public class Candidatos
    {
        private int numero;
        private string nome;
        private int numeroVotos;

        public Candidatos(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            NumeroVotos = 0;
        }
        public void IncrementraVotos(int valor)
        {
            NumeroVotos += valor;
        }
        public int ImprimirVotos()
        {
            return NumeroVotos;
        }
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public int NumeroVotos { get => numeroVotos; set => numeroVotos = value; }
    }
}

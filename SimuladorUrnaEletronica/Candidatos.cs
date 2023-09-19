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
            numeroVotos = 0;
        }
        public void IncrementraVotos(int valor)
        {
            numeroVotos += valor;
        }
        public int ImprimirVotos()
        {
            return NumeroVotos;
        }
        public void Informacoes()
        {
            Console.WriteLine($"\n\nNumero: {Numero}\n" +
                $"Nome: {Nome}\n" +
                $"Total de votos: {NumeroVotos}");
        }
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public int NumeroVotos { get => numeroVotos;}
    }
}

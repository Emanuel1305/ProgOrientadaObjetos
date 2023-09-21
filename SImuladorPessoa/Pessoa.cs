using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImuladorPessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private double peso;
        private double altura;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public Pessoa(string nome, double peso, double altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            Idade = 0;
        }
        public void Envelhecer(int idadeAdic)
        {
            Idade += idadeAdic;
        }
        public void Envelhecer()
        {
            Envelhecer(1);
        }
        public void Engordar(double pesoAdic)
        {
            Peso += pesoAdic;
        }
        public void Engordar()
        {
            Engordar(1);
        }
        public void Emagrecer(double pesoDimin)
        {
            Peso -= pesoDimin;
        }
        public void Emagrecer()
        {
            Emagrecer(1);
        }
        public void Crescer(double alturaAdic)
        {
            Altura += alturaAdic;
        }
        public void Crescer()
        {
            Crescer(1);
        }
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"\n\t\t---{Nome}---\n" +
                $"      <===========================>\n" +
                $"\tPeso\t\t{Peso} Kg\n" +
                $"\tAltura\t\t{Altura} metros\n" +
                $"\tIdade\t\t{Idade} anos\n" +
                $"      <===========================>");
        }
    }
}

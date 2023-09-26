using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimal
{
    public class Animal
    {
        private string nome;

        public string Nome { get { return nome; } set { nome = value; } }

        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }
        public void Acordar()
        {
            Console.WriteLine("Acordando...");
        }
        public void Comer()
        {
            Console.WriteLine("Comendo...");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimal
{
    public class Mamifero : Animal //Herança
    {
        private int idade;

        public int Idade { get => idade; set => idade = value; }

        public void Mamar()
        {
            Console.WriteLine("Mamando...");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nIdade: {Idade} anos";
        }
    }
}

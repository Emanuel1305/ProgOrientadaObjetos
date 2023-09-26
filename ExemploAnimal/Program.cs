using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal anim = new Animal();
            anim.Nome = "Lobo";
            anim.Acordar();
            anim.Comer();
            anim.Dormir();

            Console.WriteLine(anim + "\n");

            Mamifero mami = new Mamifero();
            mami.Nome = "Formiga";
            mami.Acordar();
            mami.Comer();
            mami.Mamar();
            mami.Idade = 6;
            mami.Dormir();

            Console.WriteLine(mami + "\n");

            Morcego morc = new Morcego();
            morc.Nome = "Morcego";
            morc.Idade = 1;
            morc.Acordar();
            morc.Comer();
            morc.Mamar();
            morc.Voar();
            morc.Dormir();

            Console.WriteLine(morc + "\n");

            Baleia bale = new Baleia();
            bale.Nome = "Baleia";
            bale.Idade = 3;
            bale.Acordar();
            bale.Comer();
            bale.Mamar();
            bale.Nadar();
            bale.Dormir();

            Console.WriteLine(bale + "\n");

            Console.ReadKey();
        }
    }
}

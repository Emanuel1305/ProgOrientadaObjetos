using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Funcionario
    {
        private string nomeFunc;
        private double salarioFunc;

        //Ctrl + ponto em cima do atributo
        public double SalarioFunc { get => salarioFunc; set => salarioFunc = value; }
        public string NomeFunc { get => nomeFunc; set => nomeFunc = value; }

        /*Forma simples
        public string NomeFunc { get; set; }
        */

        /*Forma Expandida       
        public string NomeFunc
        {
            get
            {
                return nomeFunc;
            }
            set
            {
                nomeFunc = value;
            }
               
        }
        */

        public void AumentarSalario(int taxa)
        {
            SalarioFunc = SalarioFunc + (SalarioFunc * taxa / 100);
        }
        public void ImprimirDados()
        {
            Console.WriteLine("\n\t\t---Imprimi os dados do funcionario---\n\n");
            Console.WriteLine($"Nome: {NomeFunc}\nSalário: {SalarioFunc:c2}");
        }       
    }
}

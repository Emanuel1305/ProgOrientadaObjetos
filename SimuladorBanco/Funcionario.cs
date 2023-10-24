using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    abstract public class Funcionario
    {
        private string nome;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
        public void AumentarSalario(double valor)
        {
            Salario += valor;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nSalario: {Salario}";
        }
        public virtual double CalculaBonificacao()
        {
            return Salario * 0.1;
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Salário : " + Salario.ToString("c2"));
            Console.WriteLine("Bonificação : " + CalculaBonificacao().ToString("c2"));
        }
    }
}

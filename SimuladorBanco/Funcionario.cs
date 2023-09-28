using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public Funcionario(string nome)
        {
            Nome = nome;
            Salario = 0;
        }
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
    }
}

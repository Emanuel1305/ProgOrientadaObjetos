using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Telefonista : Funcionario
    {
        private int estacaoDeTrabalho;

        public int EstacaoDeTrabalho { get => estacaoDeTrabalho; set => estacaoDeTrabalho = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nCodigo de estação de trabalho: {estacaoDeTrabalho}";
        }
        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Telefonista---");
            base.MostrarDados();
            Console.WriteLine("Estação de trabalho: " + EstacaoDeTrabalho);
        }
    }
}

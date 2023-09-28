using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class CartaoDeCredito : Cartao
    {
        private string dtValidade;
        private double limite;

        public CartaoDeCredito(string numero, Agencia agencia) : base(numero, agencia)
        {
        }

        public string DtValidade { get => dtValidade; set => dtValidade = value; }
        public double Limite { get => limite; set => limite = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nData de Validade: {DtValidade}\nLimite: {Limite:c2}";
        }
    }
}

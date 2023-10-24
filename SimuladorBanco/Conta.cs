using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public abstract class Conta
    {
        private double saldo;
        private Agencia agencia;

        protected Conta(Agencia agencia)
        {
            Agencia = agencia;
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public Agencia Agencia { get => agencia; set => agencia = value; }
        public abstract void ImprimeExtratoDetalhado();

        public override string ToString()
        {
            return $"SALDO: {Saldo:c2}";
        }
    }
}

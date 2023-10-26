using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public abstract class Conta
    {
        private Agencia agencia;

        protected Conta(Agencia agencia)
        {
            Agencia = agencia;
        }

        public decimal Saldo { get; set; }
        public Agencia Agencia { get => agencia; set => agencia = value; }

        public abstract void Depositar(decimal valor);
        public abstract void Transferir(Conta destino, decimal valor);

        public abstract void Sacar(decimal valor);


        public override string ToString()
        {
            return $"SALDO: {Saldo:c2}";
        }
    }
}

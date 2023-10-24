using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class ContaCorrente : Conta
    {
        private double limite;

        public ContaCorrente(Agencia agencia) : base(agencia)
        {
        }

        public double Limite { get => limite; set => limite = value; }

        public override void ImprimeExtratoDetalhado()
        {
            Console.WriteLine($"AGÊNCIA: {Agencia.Numero}\nSALDO: {Saldo:c2}\nLIMITE: {Limite:c2}");
        }
    }
}

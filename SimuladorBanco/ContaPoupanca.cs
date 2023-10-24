using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class ContaPoupanca : Conta
    {
        private string aniversario;

        public ContaPoupanca(Agencia agencia) : base(agencia)
        {
        }

        public string Aniversario { get => aniversario; set => aniversario = value; }

        public override void ImprimeExtratoDetalhado()
        {
            Console.WriteLine($"AGÊNCIA: {Agencia.Numero}\nSALDO: {Saldo:c2}\nANIVERSÀRIO: {Aniversario}");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nANIVERSÁRIO: {Aniversario}";
        }
    }
}

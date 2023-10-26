using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class ContaPoupanca : Conta, IGeradorDeExtrato
    {
        public decimal Limite { get; set; }
        private string aniversario;
        public string Aniversario { get => aniversario; set => aniversario = value; }

        public override void Sacar(decimal valor)
        {
            Saldo = Saldo - valor;
        }

        public override void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public override void Transferir(Conta destino, decimal valor)
        {
            Saldo = Saldo - valor;
            destino.Saldo = destino.Saldo + valor;
        }
        public ContaPoupanca(Agencia agencia) : base(agencia)
        {
        }

        public void GerarExtrato()
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:dd/MM/yyyy HH:mm:ss}", agora);
            Console.WriteLine("Data: " + horario);
            Console.WriteLine("Saldo: " + Saldo.ToString("c2"));
            Console.WriteLine("Limite: " + Limite.ToString("c2"));
            Console.WriteLine("Aniversário: " + Aniversario);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nANIVERSÁRIO: {Aniversario}";
        }
    }
}

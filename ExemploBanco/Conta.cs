using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Conta
    {
        private string numeroCont;
        private double saldoCont;
        private double limiteCont = 100;
        private Agencia agencia;

        public string NumeroCont { get => numeroCont; set => numeroCont = value; }
        public double SaldoCont { get => saldoCont; set => saldoCont = value; }
        public double LimiteCont { get => limiteCont; set => limiteCont = value; }
        public Agencia Agencia { get => agencia; set => agencia = value; }

        public void Depositar(double valor)
        {
            SaldoCont = SaldoCont + valor;
        }
        public void Sacar(double valor)
        {
            SaldoCont = SaldoCont - valor;
        }
        public double ConsultarSaldo()
        {
            return SaldoCont;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("\n\t\t---Extrato Detalhado---");
            Console.WriteLine($"\nSaldo: {SaldoCont:c2}");
            Console.WriteLine($"Limite: {LimiteCont:c2}");
        }
        public void TransferirParaConta(Conta contaTrans, Conta contaReceb, double valor)
        {
            contaTrans.SaldoCont = contaTrans.SaldoCont - valor;
            contaReceb.SaldoCont = contaReceb.SaldoCont + valor;
        }

        public Conta (Agencia agencia)
        {
            this.Agencia = agencia;
        }
    }
}

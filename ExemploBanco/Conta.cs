using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Conta
    {
        private string numero;
        private double saldo;
        private double limite = 100;
        private Agencia agencia;

        public string Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
        public Agencia Agencia { get => agencia; set => agencia = value; }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }
        public double ConsultarSaldo()
        {
            return Saldo;
        }
        public void TransferirParaConta(Conta contaTrans, Conta contaReceb, double valor)
        {
            contaTrans.Saldo = contaTrans.Saldo - valor;
            contaReceb.Saldo = contaReceb.Saldo + valor;
        }

        public Conta (Agencia agencia)
        {
            Agencia = agencia;
        }
        public override string ToString()
        {
            return $"\nNumero: {Numero}\n" +
                $"Agência: {Agencia}\n" +
                $"Saldo: {Saldo:c2}\n" +
                $"Limite: {Limite:c2}";
        }
    }
}

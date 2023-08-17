using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Conta
    {
        public string numeroCont;
        public double saldoCont;
        public double limiteCont = 100;
        public Agencia agencia;

        public void Depositar(double valor)
        {
            saldoCont = saldoCont + valor;
        }
        public void Sacar(double valor)
        {
            saldoCont = saldoCont - valor;
        }
        public double ConsultarSaldo()
        {
            return saldoCont;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("\t\t---Extrato Detalhado---");
            Console.WriteLine($"\nSaldo: {saldoCont:c2}");
            Console.WriteLine($"Limite: {limiteCont:c2}");
        }
    }
}

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

        public double Limite { get => limite; set => limite = value; }
    }
}

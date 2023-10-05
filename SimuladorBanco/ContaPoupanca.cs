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

        public string Aniversario { get => aniversario; set => aniversario = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Cartao
    {
        private string numero;
        private Agencia agencia;

        public Cartao(string numero, Agencia agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }

        public string Numero { get => numero; set => numero = value; }
        public Agencia Agencia { get => agencia; set => agencia = value; }

        public override string ToString()
        {
            return $"Numero: {Numero}";
        }
    }
}

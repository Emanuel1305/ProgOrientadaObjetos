using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Agencia
    {
        private string numero;

        public Agencia(string numero)
        {
            Numero = numero;
        }

        public string Numero { get => numero; set => numero = value; }
    }
}

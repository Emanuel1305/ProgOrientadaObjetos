using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Clientes
    {
        private string nome;
        private string codigo;
        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCódigo: {Codigo}";
        }
    }
}

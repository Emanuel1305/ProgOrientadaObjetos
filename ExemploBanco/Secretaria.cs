using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Secretaria : Funcionario
    {
        private string numeroDeRamal;
        public string NumeroDeRamal { get => numeroDeRamal; set => numeroDeRamal = value; }
        public override string ToString()
        {
            return base.ToString() + $"\nNumero de Ramal: {NumeroDeRamal}";
        }
    }
}

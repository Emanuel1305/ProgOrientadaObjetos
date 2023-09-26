using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Telefonista : Funcionario
    {
        private int codigoDeEstacaoDeTrabalho;

        public int CodigoDeEstacaoDeTrabalho { get => codigoDeEstacaoDeTrabalho; set => codigoDeEstacaoDeTrabalho = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nCodigo de Estação de Trabalho: {CodigoDeEstacaoDeTrabalho}";
        }
    }
}

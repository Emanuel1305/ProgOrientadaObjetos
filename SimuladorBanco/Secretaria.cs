using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Secretaria : Funcionario
    {
        private int ramal;

        public int Ramal { get => ramal; set => ramal = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nNumero de ramal: {Ramal}";
        }
        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Secretária---");
            base.MostrarDados();
            Console.WriteLine("Ramal : " + Ramal);
        }
    }
}

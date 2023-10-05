using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class Gerente : Funcionario
    {
        private string usuario;
        private string senha;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nNome de Usuario: {Usuario}\nSenha: {Senha}";
        }
        public override double CalculaBonificacao()
        {
            return Salario * 0.15;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Gerente---");
            base.MostrarDados();
            Console.WriteLine("Usuário : " + Usuario);
            Console.WriteLine("Senha : " + Senha);
        }
    }
}

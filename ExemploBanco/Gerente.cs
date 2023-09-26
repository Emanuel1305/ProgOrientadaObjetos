using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Gerente : Funcionario
    {
        private string nomeDeUsuario;
        private string senha;

        public string NomeDeUsuario { get => nomeDeUsuario; set => nomeDeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }

        public void AumentarSalario()
        {
            AumentarSalario(10);
        }
        public void AumentarSalario(double taxa)
        {
            double aumento = Salario * (taxa / 100);
            Salario = Salario + aumento;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNome de Usuario: {NomeDeUsuario}\nSenha: {Senha}";
        }
    }
}

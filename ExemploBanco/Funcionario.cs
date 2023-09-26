using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        //Ctrl + ponto em cima do atributo
        public double Salario { get => salario; set => salario = value; }
        public string Nome { get => nome; set => nome = value; }

        /*Forma simples
        public string NomeFunc { get; set; }
        */

        /*Forma Expandida       
        public string NomeFunc
        {
            get
            {
                return nomeFunc;
            }
            set
            {
                nomeFunc = value;
            }
               
        }
        */

        public void AumentarSalario(int taxa)
        {
            Salario = Salario + (Salario * taxa / 100);
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nSalário: {Salario:c2}";
        }
    }
}

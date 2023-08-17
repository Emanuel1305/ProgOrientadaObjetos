using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEscola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testar Turma

            Console.WriteLine("\t\t---Testar Turma---\n");
            Turma turma1 = new Turma();
            turma1.serie = "2 A";
            turma1.tpEnsino = "Integrado";
            turma1.sigla = "2AINFO";

            string msg = "";
            msg += $"Serie: {turma1.serie}\n" +
                $"Tipo de ensino: {turma1.tpEnsino}\n" +
                $"Sigla: {turma1.sigla}\n\n";

            Turma turma2 = new Turma();
            turma2.serie = "4";
            turma2.tpEnsino = "ADS";
            turma2.sigla = "4ADS";

            msg += $"Serie: {turma2.serie}\n" +
                $"Tipo de ensino: {turma2.tpEnsino}\n" +
                $"Sigla: {turma2.sigla}";

            Console.WriteLine(msg);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar aluno

            Console.WriteLine("\t\t---Testar Aluno---\n");
            Aluno aluno1 = new Aluno();
            aluno1.nomeAluno = "Emanuel";
            aluno1.RG = "000 000 000-00";
            aluno1.dtNascimento = "00/00/0000";
            aluno1.turma = turma1;
            string msg2 = "";
            msg2 += $"ALUNO 1\n" +
                $"Nome: {aluno1.nomeAluno}\n" +
                $"RG: {aluno1.RG}\n" +
                $"Data de Nascimento: {aluno1.dtNascimento}\n" +
                $"Turma: {aluno1.turma.sigla}\n\n";

            Aluno aluno2 = new Aluno();
            aluno2.nomeAluno = "Henrique";
            aluno2.RG = "111 111 111-11";
            aluno2.dtNascimento = "11/11/1111";
            aluno2.turma = turma2;
            msg2 += $"ALUNO 2\n" +
                $"Nome: {aluno2.nomeAluno}\n" +
                $"RG: {aluno2.RG}\n" +
                $"Data de Nascimento: {aluno2.dtNascimento}\n" +
                $"Turma: {aluno2.turma.sigla}";

            Console.WriteLine(msg2);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Funcionario

            Console.WriteLine("\t\t---Testar Funcionario---\n");
            Funcionario funcionario1 = new Funcionario();
            funcionario1.nomeFunc = "Douglas";
            funcionario1.cargoFunc = "Cordenador de curso";
            funcionario1.salarioFunc = 6000;
            string msg3 = "";
            msg3 += $"FUNCIONARIO 1\n" +
                $"Nome: {funcionario1.nomeFunc}\n" +
                $"Cargo: {funcionario1.cargoFunc}\n" +
                $"Salario: {funcionario1.salarioFunc:c2}\n";

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nomeFunc = "Wagner";
            funcionario2.cargoFunc = "Professor de FAS";
            funcionario2.salarioFunc = 3000;
            msg3 += $"\nFUNCIONARIO 2\n" +
                $"Nome: {funcionario2.nomeFunc}\n" +
                $"Cargo: {funcionario2.cargoFunc}\n" +
                $"Salario: {funcionario2.salarioFunc:c2}\n";

            Console.WriteLine(msg3);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Metodos da Classe Funcinario

            Console.WriteLine("\t\t---Testar Metodos da Classe Funcinario---\n");
            Console.WriteLine($"Atualmente {funcionario1.nomeFunc} recebe {funcionario1.salarioFunc:c2}!");
            Console.Write("Informe o Valor que deseja aumentar do salario deste funcionario: ");
            double valAumetoSalario = Double.Parse(Console.ReadLine());
            funcionario1.AumentarSalario(valAumetoSalario);
            Console.Write("\n");
            funcionario1.ConsultarInformacoesFuncionario();

            Console.ReadKey();
            Console.Clear();

            #endregion           
        }
        }
}

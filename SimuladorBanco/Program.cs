using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestarHeranca();
            Console.ReadKey();
            Console.Clear();
            TestarGerador();
            Console.ReadKey();
            Console.Clear();
            TestarControleDePonto();
            Console.Clear();
            TestarClasseAbstrata();

            Console.ReadKey();
        }
        static void TestarHeranca()
        {
            Gerente g = new Gerente();
            g.Nome = "Rafael Cosentino";
            g.Salario = 2000;
            g.Usuario = "rafae.cosentino";
            g.Senha = "12345";
            g.MostrarDados();

            Telefonista t = new Telefonista();
            t.Nome = " Carolina Mello ";
            t.Salario = 1000;
            t.EstacaoDeTrabalho = 13;
            t.MostrarDados();

            Secretaria s = new Secretaria();
            s.Nome = " Tatiane Andrade ";
            s.Salario = 1500;
            s.Ramal = 198;
            s.MostrarDados();
        }
        static void TestarGerador()
        {
            GeradorDeExtrato gerador = new GeradorDeExtrato();
            Agencia a1 = new Agencia("123");
            Agencia a2 = new Agencia("321");

            ContaPoupanca cp = new ContaPoupanca(a1);
            cp.Saldo = 2000;

            ContaCorrente cc = new ContaCorrente(a2);
            cc.Saldo = 1000;

            gerador.ImprimeExtratoBasico(cp);
            gerador.ImprimeExtratoBasico(cc);
        }
        static void TestarControleDePonto()
        {
            ControleDeEntradaESaida ponto = new ControleDeEntradaESaida();

            Gerente g = new Gerente();
            g.Nome = "Pedro";

            Telefonista t = new Telefonista();
            t.Nome = "João";

            ponto.RegistrarEntrada(g);
            ponto.RegistrarSaida(g);
            Console.WriteLine("\n");
            ponto.RegistrarEntrada(t);
            ponto.RegistrarSaida(t);
        }
        static void TestarClasseAbstrata()
        {
            Agencia a1 = new Agencia("123");

            ContaPoupanca c = new ContaPoupanca(a1);
            c.Saldo = 1000;
            c.Aniversario = "02/11/2006";
            c.ImprimeExtratoDetalhado();

            Console.ReadKey();
        }
    }
}

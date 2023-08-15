using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testar Cliente

            Console.WriteLine("\t\t---Testar Classe Cliente---\n");

            string msg = "";

            Cliente cliente1 = new Cliente();
            Console.Write("Informe o nome do primeiro Cliente: ");
            cliente1.nomeClien = Console.ReadLine();
            Console.Write($"Informe o código do cliente {cliente1.nomeClien}: ");
            cliente1.codigoClien = Console.ReadLine();

            msg += $"\nCLIENTE 1\n" +
                $"Nome: {cliente1.nomeClien}\n" +
                $"Código: {cliente1.codigoClien}\n\n";

            Cliente cliente2 = new Cliente();
            Console.Write("\nInforme o nome do segundo Cliente: ");
            cliente2.nomeClien = Console.ReadLine();
            Console.Write($"Informe o código do cliente {cliente2.nomeClien}: ");
            cliente2.codigoClien = Console.ReadLine();

            msg += $"CLIENTE 2\n" +
                $"Nome: {cliente2.nomeClien}\n" +
                $"Código: {cliente2.codigoClien}\n\n";

            Console.WriteLine(msg);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Cartao

            Console.WriteLine("\t\t---Testar Classe Cartão de Credito---\n");

            string msg2 = "";

            CartaoDeCredito cartao1 = new CartaoDeCredito();
            Console.Write("Informe o Numero do primeiro Cartão: ");
            cartao1.numeroCart = Console.ReadLine();
            Console.Write($"Informe a data de validade do Cartão {cartao1.numeroCart} (dd/MM/yyyy): ");
            cartao1.dtValidadeCart = Console.ReadLine();

            msg2 += $"\nCARTÃO 1\n" +
                $"Numero: {cartao1.numeroCart}\n" +
                $"Data de validade: {cartao1.dtValidadeCart}\n\n";

            CartaoDeCredito cartao2 = new CartaoDeCredito();
            Console.Write("\nInforme o Numero do segundo Cartão: ");
            cartao2.numeroCart = Console.ReadLine();
            Console.Write($"Informe a data de validade do Cartão {cartao2.numeroCart} (dd/MM/yyyy): ");
            cartao2.dtValidadeCart = Console.ReadLine();

            msg2 += $"CARTÃO 2\n" +
                $"Numero: {cartao2.numeroCart}\n" +
                $"Data de validade: {cartao2.dtValidadeCart}\n\n";

            Console.WriteLine(msg2);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Agencia

            Console.WriteLine("\t\t---Testar Classe Agencia---\n");

            string msg3 = "";

            Agencia agencia1 = new Agencia();
            Console.Write("Informe o Numero da primeira Agência: ");
            agencia1.numeroAgen = Console.ReadLine();

            msg3 += $"\nAGÊNCIA 1\n" +
                $"Numero: {agencia1.numeroAgen}\n\n";

            Agencia agencia2 = new Agencia();
            Console.Write("Informe o Numero da segunda Agência: ");
            agencia2.numeroAgen = Console.ReadLine();

            msg3 += $"AGÊNCIA 2\n" +
                $"Numero: {agencia2.numeroAgen}\n";

            Console.WriteLine(msg3);

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}

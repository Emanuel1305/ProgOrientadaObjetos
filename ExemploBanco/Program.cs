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
            #region Testar Endereço

            Console.WriteLine("\t\t---Testar Classe Endereço---\n");

            string msg = "";

            Endereco endereco1 = new Endereco();
            endereco1.rua = "Prof Carlos Mazala";
            endereco1.bairro = "Jardim America";

            msg += $"\nENDEREÇO 1\n" +
                $"Rua: {endereco1.rua}\n" +
                $"Bairro: {endereco1.bairro}\n\n";

            Endereco endereco2 = new Endereco();
            endereco2.rua = "Limoneto";
            endereco2.bairro = "Dos Limoeiros";

            msg += $"ENDEREÇO 2\n" +
                $"Rua: {endereco2.rua}\n" +
                $"Bairro: {endereco2.bairro}";

            Console.Write(msg);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Cliente

            Console.WriteLine("\t\t---Testar Classe Cliente---\n");

            string msg1 = "";

            Cliente cliente1 = new Cliente();
            cliente1.nomeClien = "Emanuel";
            cliente1.codigoClien = "111";
            cliente1.endereco = endereco1;

            msg1 += $"\nCLIENTE 1\n" +
                $"Nome: {cliente1.nomeClien}\n" +
                $"Código: {cliente1.codigoClien}\n" +
                $"\nENDEREÇO\nRua: {cliente1.endereco.rua}\n" +
                $"Bairro: {cliente1.endereco.bairro}\n\n";

            Cliente cliente2 = new Cliente();
            cliente2.nomeClien = "Hemrique";
            cliente2.codigoClien = "222";
            cliente2.endereco = endereco2;

            msg1 += $"CLIENTE 2\n" +
                $"Nome: {cliente2.nomeClien}\n" +
                $"Código: {cliente2.codigoClien}\n" +
                $"\nENDEREÇO\nRua: {cliente2.endereco.rua}\n" +
                $"Bairro: {cliente2.endereco.bairro}";

            Console.WriteLine(msg1);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Cartao

            Console.WriteLine("\t\t---Testar Classe Cartão de Credito---\n");

            string msg2 = "";

            CartaoDeCredito cartao1 = new CartaoDeCredito();
            cartao1.numeroCart = "000 000 000 000";
            cartao1.dtValidadeCart = "00/00/0000";
            cartao1.cliente = cliente1;

            msg2 += $"\nCARTÃO 1\n" +
                $"Numero: {cartao1.numeroCart}\n" +
                $"Data de validade: {cartao1.dtValidadeCart}\n" +
                $"Pertence ao cliente: {cartao1.cliente.nomeClien}\n\n";

            CartaoDeCredito cartao2 = new CartaoDeCredito();
            cartao2.numeroCart = "111 111 111 111";
            cartao2.dtValidadeCart = "11/11/1111";
            cartao2.cliente = cliente2;

            msg2 += $"CARTÃO 2\n" +
                $"Numero: {cartao2.numeroCart}\n" +
                $"Data de validade: {cartao2.dtValidadeCart}\n" +
                $"Pertence ao cliente: {cartao2.cliente.nomeClien}";

            Console.WriteLine(msg2);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Agencia

            Console.WriteLine("\t\t---Testar Classe Agencia---\n");

            string msg3 = "";

            Agencia agencia1 = new Agencia();
            agencia1.numeroAgen = "123";

            msg3 += $"\nAGÊNCIA 1\n" +
                $"Numero: {agencia1.numeroAgen}\n\n";

            Agencia agencia2 = new Agencia();
            agencia2.numeroAgen = "321";

            msg3 += $"AGÊNCIA 2\n" +
                $"Numero: {agencia2.numeroAgen}";

            Console.WriteLine(msg3);

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Conta

            Console.WriteLine("\t\t---Testar Classe Conta---\n");

            string msg4 = "";

            Conta conta1 = new Conta();
            conta1.numeroCont = "111 111 111-11";
            conta1.saldoCont = 15000;
            conta1.agencia = agencia1; //Vinculo de cliente com agencia

            msg4 += $"\nCONTA 1\n" +
                $"Numero: {conta1.numeroCont}\n" +
                $"Saldo: {conta1.saldoCont.ToString("c2")}\n" +
                $"Limite: {conta1.limiteCont.ToString("c2")}\n" +
                $"Agência: {conta1.agencia.numeroAgen}\n\n";

            Conta conta2 = new Conta();
            conta2.numeroCont = "222 222 222-22";
            conta2.saldoCont = 20000;
            conta2.agencia = agencia2; //Vinculo de cliente 2 com agencia 2

            msg4 += $"CONTA 2\n" +
                $"Numero: {conta2.numeroCont}\n" +
                $"Saldo: {conta2.saldoCont.ToString("c2")}\n" +
                $"Limite: {conta2.limiteCont.ToString("c2")}\n" +
                $"Agencia: {conta2.agencia.numeroAgen}";

            Console.WriteLine(msg4);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Metodos da Classe Conta

            Console.WriteLine("\t\t---Testar Metodos Classe Conta---\n");

            Console.WriteLine($"\nSaldo Disponivel: {conta1.ConsultarSaldo():c2}");

            Console.Write("\n\nInforme o Valor que deseja depositar: ");
            double deposito = Double.Parse(Console.ReadLine());
            conta1.Depositar(deposito);

            Console.Write("Informe o Valor que deseja sacar: ");
            double saque = Double.Parse(Console.ReadLine());
            conta1.Sacar(saque);
            Console.Write("\n");
            conta1.ImprimeExtrato();

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region  Testar Metodos da Classe Funcionario

            Funcionario funcionario1 = new Funcionario();
            funcionario1.nomeFunc = "Pedro";
            funcionario1.salarioFunc = 2000;
            funcionario1.ImprimirDados();
            funcionario1.AumentarSalario(10);
            Console.Write("\n");
            funcionario1.ImprimirDados();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Metodos da Classe Gerente

            Console.WriteLine("\t\tTestar Metodos da Classe Gerente\n\n");

            Gerente gerente1 = new Gerente();
            gerente1.nomeGeren = "João";
            gerente1.salarioGeren = 1000;
            Console.WriteLine($"Salario: {gerente1.salarioGeren:c2}");
            gerente1.AumentarSalario();
            Console.WriteLine($"Salario com aumento de 10%: {gerente1.salarioGeren:c2}");
            Console.Write("\nInforme quantos % deseja aumentar do salario: ");
            double taxa = Double.Parse(Console.ReadLine());
            gerente1.AumentarSalario(taxa);
            Console.Write($"Salario com aumento de {taxa}%: {gerente1.salarioGeren:c2}");
            Console.ReadKey();
            Console.Clear();
            gerente1.ImprimirInformacoesGerente();

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Tranferencia de Conta

            Console.Write("\t\t---Testar Tranferencia de Conta---\n\n");
            Console.WriteLine($"CONTA 1\n{conta1.ConsultarSaldo()}\n" +
                $"\nCONTA 2\n{conta2.ConsultarSaldo()}");

            Console.Write("\n" +
                $"\n[1] {conta1.numeroCont}" +
                $"\n[2] {conta2.numeroCont}" +
                $"\nQual sua conta: ");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    Console.Write($"\nQual valor deseja tranferir para {conta2.numeroCont}? ");
                    double v = double.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    conta1.TransferirParaConta(conta1, conta2, v);
                    Console.Write("CONTA 1");
                    conta1.ImprimeExtrato();
                    Console.Write("\nCONTA 2");
                    conta2.ImprimeExtrato();
                    break;
                case 2:
                    Console.Write($"\nQual valor deseja tranferir para {conta1.numeroCont}? ");
                    double v2 = double.Parse(Console.ReadLine());
                    conta1.TransferirParaConta(conta2, conta1, v2);
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("CONTA 1");
                    conta1.ImprimeExtrato();
                    Console.Write("\nCONTA 2");
                    conta2.ImprimeExtrato();
                    break;
                default:
                    Console.Write("Numero informado não está disponível!!");
                    break;

            }
            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}

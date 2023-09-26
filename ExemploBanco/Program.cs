using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    internal class Program
    {
        static Gerente gerente1 = new Gerente();
        static Agencia agencia = new Agencia("123");
        static Conta conta1 = new Conta(agencia);
        static void Main(string[] args)
        {

            int opc = 0;
            do
            {
                Console.WriteLine("\t\t---Simulador De Banco---\n\n");
                Console.WriteLine("[1] Classes e Objetos\n" +
                    "[2] Metodos\n" +
                    "[3] Tranferencia de Conta\n" +
                    "[4] Sobrecarga\n" +
                    "[5] Herança\n" +
                    "[6] Sair\n");
                Console.Write("Qual opção deseja execultar: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        TestarClassesObjetos();
                        break;
                    case 2:
                        TestarMetodos();
                        break;
                    case 3:
                        TransferenciaDeConta();
                        break;
                    case 4:
                        TestarSobrecarga();
                        break;
                    case 5:
                        TestarHeranca();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Clear();
                opc = 0;
            } while (opc != 6);

        }
        public static void TestarClassesObjetos()
        {
            Console.Clear();
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

            CartaoDeCredito cartao1 = new CartaoDeCredito("000 000 000 000");
            cartao1.dtValidadeCart = "00/00/0000";
            cartao1.cliente = cliente1;

            msg2 += $"\nCARTÃO 1\n" +
                $"Numero: {cartao1.numeroCart}\n" +
                $"Data de validade: {cartao1.dtValidadeCart}\n" +
                $"Pertence ao cliente: {cartao1.cliente.nomeClien}\n\n";

            CartaoDeCredito cartao2 = new CartaoDeCredito("111 111 111 111");
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

            Agencia agencia1 = new Agencia("123");

            msg3 += $"\nAGÊNCIA 1\n" +
                $"Numero: {agencia1.numeroAgen}\n\n";

            Agencia agencia2 = new Agencia("321");

            msg3 += $"AGÊNCIA 2\n" +
                $"Numero: {agencia2.numeroAgen}";

            Console.WriteLine(msg3);

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Conta
            Console.WriteLine("\t\t---Testar Classe Conta---\n");

            string msg4 = "";

            Conta conta1 = new Conta(agencia1);
            conta1.NumeroCont = "111 111 111-11";
            conta1.SaldoCont = 15000;
            //conta1.agencia = agencia1; Vinculo de cliente com agencia

            msg4 += $"\nCONTA 1\n" +
                $"Numero: {conta1.NumeroCont}\n" +
                $"Saldo: {conta1.SaldoCont.ToString("c2")}\n" +
                $"Limite: {conta1.LimiteCont.ToString("c2")}\n" +
                $"Agência: {conta1.Agencia.numeroAgen}\n\n";

            Conta conta2 = new Conta(agencia2);
            conta2.NumeroCont = "222 222 222-22";
            conta2.SaldoCont = 20000;

            msg4 += $"CONTA 2\n" +
                $"Numero: {conta2.NumeroCont}\n" +
                $"Saldo: {conta2.SaldoCont.ToString("c2")}\n" +
                $"Limite: {conta2.LimiteCont.ToString("c2")}\n" +
                $"Agencia: {conta2.Agencia.numeroAgen}";

            Console.WriteLine(msg4);

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
        public static void TestarMetodos()
        {
            //Métodos
            Console.Clear();
            int opc = 0;
            int op = 0;
            int o = 0;
            do
            {
                Console.WriteLine("\t\t---Testar Métodos---\n\n");
                Console.Write($"[1] Testar Metodos da Classe Conta\n[2] Testar Métodos da Classe Funcionário\n[3] Sair\nInforme qual deseja executar: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        conta1.SaldoCont = 1000;

                        do
                        {
                            Console.WriteLine("\t\t---Testar Metodos Classe Conta---\n");
                            Console.Write("\n[1] Consultar Saldo\n[2] Depositar\n[3] Sacar\n[4] Imprimir extrato\n[5] Sair\nInforme qual deseja realizar: ");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine($"\nSaldo Disponivel: {conta1.ConsultarSaldo():c2}");
                                    break;
                                case 2:
                                    Console.Write("\nInforme o Valor que deseja depositar: ");
                                    double deposito = Double.Parse(Console.ReadLine());
                                    conta1.Depositar(deposito);
                                    break;
                                case 3:
                                    Console.Write("Informe o Valor que deseja sacar: ");
                                    double saque = Double.Parse(Console.ReadLine());
                                    conta1.Sacar(saque);
                                    break;
                                case 4:
                                    conta1.ImprimeExtrato();
                                    break;
                                case 5:
                                    continue;
                                default:
                                    break;
                            }
                            op = 0;
                            Console.ReadKey();
                            Console.Clear();
                        } while (op != 5);

                        Console.ReadKey();

                        Console.Clear();
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("\t\t---Testar Metodos Classe Funcionário---\n");
                            Funcionario funcionario1 = new Funcionario();
                            funcionario1.Nome = "Pedro";
                            funcionario1.Salario = 2000;
                            Console.Write("[1] Imprimir Dados\n[2] Aumentar salário em 10%\n[3] Sair\nInforme qual deseja execultar: ");
                            o = int.Parse(Console.ReadLine());
                            switch (o)
                            {
                                case 1:
                                    Console.WriteLine("\n" + funcionario1);
                                    break;
                                case 2:
                                    funcionario1.AumentarSalario(10);
                                    Console.WriteLine("\n" + funcionario1);
                                    break;
                                case 3:
                                    continue;
                                default:
                                    break;
                            }
                            o = 0;
                            Console.ReadKey();
                            Console.Clear();
                        } while (o != 3);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opcão Iválida!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                opc = 0;
            } while (opc != 3 || op != 5 || o != 3);
            Console.WriteLine("Programa finalizado, aperte qualquer tecla para continuar");
            Console.ReadKey();
        }
        public static void TransferenciaDeConta()
        {
            Conta conta1 = new Conta(agencia);
            Conta conta2 = new Conta(agencia);
            Console.Write("\t\t---Testar Tranferencia de Conta---\n\n");
            Console.WriteLine($"CONTA 1\n{conta1.ConsultarSaldo()}\n" +
                $"\nCONTA 2\n{conta2.ConsultarSaldo()}");

            Console.Write("\n" +
                $"\n[1] {conta1.NumeroCont}" +
                $"\n[2] {conta2.NumeroCont}" +
                $"\nQual sua conta: ");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    Console.Write($"\nQual valor deseja tranferir para {conta2.NumeroCont}? ");
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
                    Console.Write($"\nQual valor deseja tranferir para {conta1.NumeroCont}? ");
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
        }
        public static void TestarSobrecarga()
        {
            Console.Clear();
            Console.WriteLine("\t\tTestar Metodos da Classe Gerente\n\n");
            gerente1.Nome = "João";
            gerente1.Salario = 1000;

            Console.WriteLine($"Salario: {gerente1.Salario:c2}");
            gerente1.AumentarSalario();
            Console.WriteLine($"Salario com aumento de 10%: {gerente1.Salario:c2}");
            Console.Write("\nInforme quantos % deseja aumentar do salario: ");
            double taxa = Double.Parse(Console.ReadLine());
            gerente1.AumentarSalario(taxa);
            Console.Write($"Salario com aumento de {taxa}%: {gerente1.Salario:c2}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n" + gerente1);

            Console.ReadKey();
            Console.Clear();
        }
        public static void TestarHeranca()
        {
            Console.WriteLine("\n\t\t---Testar Herança---\n");

            Funcionario func = new Funcionario();
            func.Nome = "Pedro";
            func.Salario = 1000;

            Console.WriteLine(func + "\n");

            Gerente gere = new Gerente();
            gere.Nome = "Douglas";
            gere.Salario = 2000;
            gere.NomeDeUsuario = "DouglasLegramante";
            gere.Senha = "Dg123";

            Console.WriteLine(gere + "\n");

            Telefonista tele = new Telefonista();
            tele.Nome = "Sabrina";
            tele.Salario = 1500;
            tele.CodigoDeEstacaoDeTrabalho = 123;

            Console.WriteLine(tele + "\n");

            Secretaria secr = new Secretaria();
            secr.Nome = "Joana";
            secr.Salario = 1000;
            secr.NumeroDeRamal = "12";

            Console.WriteLine(secr + "\n");

            Console.ReadKey();
        }
    }
}

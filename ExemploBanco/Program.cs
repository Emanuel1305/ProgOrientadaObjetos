using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBanco
{
    internal class Program
    {
        static Agencia agen1 = new Agencia("123");
        static Agencia agen2 = new Agencia("321");
        static Funcionario func = new Funcionario();
        static Gerente gere = new Gerente();
        static Telefonista tele = new Telefonista();
        static Secretaria secr = new Secretaria();
        static Conta cont1 = new Conta(agen1);
        static Conta cont2 = new Conta(agen2);
        static Endereco ende1 = new Endereco();
        static Endereco ende2 = new Endereco();
        static Cliente clie1 = new Cliente();
        static Cliente clie2 = new Cliente();
        static CartaoDeCredito cart1 = new CartaoDeCredito("000 000 000 000");
        static CartaoDeCredito cart2 = new CartaoDeCredito("111 111 111 111");
        static int opcaoGeral;

        static void Main(string[] args)
        {
            func.Nome = "Pedro";
            func.Salario = 1000;

            gere.Nome = "Douglas";
            gere.Salario = 2000;
            gere.NomeDeUsuario = "DouglasLegramante";
            gere.Senha = "Dg123";

            tele.Nome = "Sabrina";
            tele.Salario = 1500;
            tele.CodigoDeEstacaoDeTrabalho = 123;

            cont1.Numero = "000 000 000 000-00";
            cont1.Limite = 1000;
            cont1.Saldo = 1000;
            cont1.Numero = "111 111 111 111-11";
            cont2.Limite = 2000;
            cont2.Saldo = 2000;

            ende1.rua = "Prof Carlos Mazala";
            ende1.bairro = "Jardim America";
            ende2.rua = "Limoneto";
            ende2.bairro = "Dos Limoeiros";

            clie1.nomeClien = "Emanuel";
            clie1.codigoClien = "111";
            clie1.endereco = ende1;
            clie2.nomeClien = "Hemrique";
            clie2.codigoClien = "222";
            clie2.endereco = ende2;

            cart1.dtValidadeCart = "00/00/0000";
            cart1.cliente = clie1;
            cart2.dtValidadeCart = "11/11/1111";
            cart2.cliente = clie2;

            do
            {
                opcaoGeral = 0;
                Console.WriteLine(@"
█▀ █ █▀▄▀█ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▀ █▀█
▄█ █ █░▀░█ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▄ █▄█");
                Console.WriteLine("\n\n[1] Classes e Objetos\n" +
                    "[2] Metodos\n" +
                    "[3] Tranferencia de Conta\n" +
                    "[4] Sobrecarga\n" +
                    "[5] Herança\n" +
                    "[6] Sair\n");
                Console.Write("Qual opção deseja execultar: ");
                opcaoGeral = int.Parse(Console.ReadLine());
                switch (opcaoGeral)
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
            } while (opcaoGeral != 6);
            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
        public static void TestarClassesObjetos()
        {
            Console.Clear();
            #region Testar Endereço
            Console.WriteLine("\t\t---Testar Classe Endereço---\n");

            string msg = "";

            msg += $"\nENDEREÇO 1\n" +
                $"Rua: {ende1.rua}\n" +
                $"Bairro: {ende1.bairro}\n\n";
            msg += $"ENDEREÇO 2\n" +
                $"Rua: {ende2.rua}\n" +
                $"Bairro: {ende2.bairro}";

            Console.Write(msg);

            Console.ReadKey();
            Console.Clear();

            #endregion
            #region Testar Cliente

            Console.WriteLine("\t\t---Testar Classe Cliente---\n");

            string msg1 = "";

            msg1 += $"\nCLIENTE 1\n" +
                $"Nome: {clie1.nomeClien}\n" +
                $"Código: {clie1.codigoClien}\n" +
                $"\nENDEREÇO\nRua: {clie1.endereco.rua}\n" +
                $"Bairro: {clie1.endereco.bairro}\n\n";
            msg1 += $"CLIENTE 2\n" +
                $"Nome: {clie2.nomeClien}\n" +
                $"Código: {clie2.codigoClien}\n" +
                $"\nENDEREÇO\nRua: {clie2.endereco.rua}\n" +
                $"Bairro: {clie2.endereco.bairro}";

            Console.WriteLine(msg1);

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Cartao
            Console.WriteLine("\t\t---Testar Classe Cartão de Credito---\n");

            string msg2 = "";

            msg2 += $"\nCARTÃO 1\n" +
                $"Numero: {cart1.numeroCart}\n" +
                $"Data de validade: {cart1.dtValidadeCart}\n" +
                $"Pertence ao cliente: {cart1.cliente.nomeClien}\n\n";
            msg2 += $"CARTÃO 2\n" +
                $"Numero: {cart2.numeroCart}\n" +
                $"Data de validade: {cart2.dtValidadeCart}\n" +
                $"Pertence ao cliente: {cart2.cliente.nomeClien}";

            Console.WriteLine(msg2);

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Agencia

            Console.WriteLine("\t\t---Testar Classe Agencia---\n");

            string msg3 = "";

            msg3 += $"\nAGÊNCIA 1\n" +
                $"Numero: {agen1.numeroAgen}\n\n";
            msg3 += $"AGÊNCIA 2\n" +
                $"Numero: {agen2.numeroAgen}";

            Console.WriteLine(msg3);

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Testar Conta
            Console.WriteLine("\t\t---Testar Classe Conta---\n");

            string msg4 = "";

            //conta1.agencia = agencia1; Vinculo de cliente com agencia

            msg4 += $"\nCONTA 1 {cont1}\nCONTA 2 {cont2}";

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
                        do
                        {
                            op = 0;

                            Console.WriteLine($"\t\t---Testar Metodos Classe Conta---\n" +
                                $"==============================================\n" +
                                $"{cont1}\n" +
                                $"==============================================\n");
                            Console.Write("\n[1] Consultar Saldo\n" +
                                "[2] Depositar\n" +
                                "[3] Sacar\n" +
                                "[4] Imprimir extrato\n" +
                                "[5] Voltar\n" +
                                "[6] Sair\n" +
                                "Informe qual deseja realizar: ");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine($"\nSaldo Disponivel: {cont1.ConsultarSaldo():c2}");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Write("\nInforme o Valor que deseja depositar: ");
                                    double deposito = Double.Parse(Console.ReadLine());
                                    cont1.Depositar(deposito);
                                    break;
                                case 3:
                                    Console.Write("Informe o Valor que deseja sacar: ");
                                    double saque = Double.Parse(Console.ReadLine());
                                    cont1.Sacar(saque);
                                    break;
                                case 4:
                                    Console.WriteLine(cont1);
                                    Console.ReadKey();
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                        } while (op != 5);

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("\t\t---Testar Metodos Classe Funcionário---\n");

                            Console.Write("[1] Imprimir Dados\n[2] Aumentar salário em 10%\n[3] Sair\nInforme qual deseja execultar: ");
                            o = int.Parse(Console.ReadLine());
                            switch (o)
                            {
                                case 1:
                                    Console.WriteLine("\n" + func);
                                    break;
                                case 2:
                                    func.AumentarSalario(10);
                                    Console.WriteLine("\n" + func);
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
            Console.Write($"\t\t---Testar Tranferencia de Conta---\n" +
                $"==================================\n" +
                $"CONTA 1 {cont1}\n" +
                $"==================================\n" +
                $"CONTA 2 {cont2}" +
                $"==================================\n");
            Console.Write("\n" +
                $"\n[1] {cont1.Numero}" +
                $"\n[2] {cont2.Numero}" +
                $"\nQual sua conta: ");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    Console.Write($"\nQual valor deseja tranferir para {cont2.Numero}? ");
                    double v = double.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    cont1.TransferirParaConta(cont1, cont2, v);
                    Console.Write($"CONTA 1 {cont1}" +
                        $"\nCONTA 2 {cont2}");
                    break;
                case 2:
                    Console.Write($"\nQual valor deseja tranferir para {cont1.Numero}? ");
                    double v2 = double.Parse(Console.ReadLine());
                    cont1.TransferirParaConta(cont2, cont1, v2);
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"CONTA 1 {cont1}" +
                        $"\nCONTA 2 {cont2}");
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

            Console.WriteLine($"Salario: {gere.Salario:c2}");
            gere.AumentarSalario();
            Console.WriteLine($"Salario com aumento de 10%: {gere.Salario:c2}");
            Console.Write("\nInforme quantos % deseja aumentar do salario: ");
            double taxa = Double.Parse(Console.ReadLine());
            gere.AumentarSalario(taxa);
            Console.Write($"Salario com aumento de {taxa}%: {gere.Salario:c2}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n" + gere);

            Console.ReadKey();
            Console.Clear();
        }
        public static void TestarHeranca()
        {
            Console.WriteLine("\n\t\t---Testar Herança---\n");

            Console.WriteLine(func + "\n");
            Console.WriteLine(gere + "\n");
            Console.WriteLine(tele + "\n");
            Console.WriteLine(secr + "\n");

            Console.ReadKey();
        }
        public static void TestarBonificacao()
        {
            Console.WriteLine();
        }
    }
}

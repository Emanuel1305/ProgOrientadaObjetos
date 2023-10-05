using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBanco
{
    public class ControleDeEntradaESaida
    {
        public void RegistrarEntrada(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            System.Console.WriteLine($"NOME: {f.Nome}\nDATA DE ENTRADA: {horario}");
        }
        public void RegistrarSaida(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            System.Console.WriteLine($"NOME: {f.Nome}\nDATA DE SAIDA: {horario}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBombaDeCombustivel
{
    public class BombaDeCombustivel
    {
        private string tipoCombustivel;
        private double valorLitro;
        private double quantidadeCombustivel;

        public string TipoCombustivel { get => tipoCombustivel; set => tipoCombustivel = value; }
        public double ValorLitro { get => valorLitro; set => valorLitro = value; }
        public double QuantidadeCombustivel { get => quantidadeCombustivel; set => quantidadeCombustivel = value; }

        public BombaDeCombustivel(string tipoCombustivel, double valorLitro)
        {
            TipoCombustivel = tipoCombustivel;
            ValorLitro = valorLitro;
            QuantidadeCombustivel = 0;
        }

        public double AbastecerPorValor(double valorAbast)
        {
            double quantLitros = valorAbast / this.ValorLitro;
            QuantidadeCombustivel -= quantLitros;
            return quantLitros;
        }
        public double AbastecerPorLitro(double quantLitros)
        {
            double valorASerPago = quantLitros * this.ValorLitro;
            QuantidadeCombustivel -= quantLitros;
            return valorASerPago;
        }
        public void AlterarValor(double nvValor)
        {
            ValorLitro = nvValor;
        }
        public void AlterarCombustivel(string nvTipo)
        {
            TipoCombustivel = nvTipo;
        }
        public void AlterarQuantidadeDeCombustivel(double nvQuant)
        {
            QuantidadeCombustivel = nvQuant;
        }
        public void MostarInformacoesBomba()
        {
            Console.WriteLine($"\n\t\t---Informações Bomba---\n" +
                $"======================================================\n" +
                $"Tipo de Combustivel\t\t\t{TipoCombustivel}\n" +
                $"Valor por Litro\t\t\t\t{ValorLitro:c2}\n" +
                $"Quantidade de Combustivel restante\t{QuantidadeCombustivel} litros\n" +
                $"======================================================\n");
        }
    }
}

using System;
using System.Globalization;

namespace Exercicio7
{
    class ContaBancaria
    {
        public int Codigo { get; private set; }
        public double Saldo { get; private set; }
        public string Nome { get; set; }

        public ContaBancaria(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public ContaBancaria(int codigo, string nome, double valorDepositoInicial) : this(codigo, nome)
        {
            EntradaDinheiro(valorDepositoInicial);
        }

        public void EntradaDinheiro(double deposito)
        {
            Saldo += deposito;
        }

        public void SaidaDinheiro(double saque)
        {
            Saldo -= (saque + 5.00);
        }

        public override string ToString()
        {
            return "Conta: "
                + Codigo + ", "
                + "Titular: " + Nome + ", "
                + "Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;

namespace Main
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, int idade, bool temFilhos, int numeroConta, double saldo, string agencia) : base(nome, idade, temFilhos, numeroConta, saldo, agencia)
        {

        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                base.Saldo += valor;
                Console.WriteLine($"DEPOSITO: R${valor} depositado com sucesso");
            }
            else
            {
                Console.WriteLine("Não é possivel depositar o valor igual a 0");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor < base.Saldo)
            {
                base.Saldo -= valor;
                Console.WriteLine($"SAQUE: R${valor} sacado com sucesso");
            }
            else
            {
                Console.WriteLine("Não é possivel realizar esta ação");
            }
        }
        public override string ToString()
        {
            return $"Prezado(a) cliente {base.Nome}, seu saldo atual de R${base.Saldo}\n";
        }
    }
}

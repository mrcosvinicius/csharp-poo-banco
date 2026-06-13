using System;

namespace Main
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string nome, int idade, bool temFilhos, int numeroConta, double saldo, string agencia) : base(nome, idade, temFilhos, numeroConta, saldo, agencia)
        {

        }

        public void RenderConta()
        {
            base.Saldo += base.Saldo * 0.1;
        }

        public override string ToString()
        {
            return $"Prezado(a) cliente {base.Nome}, seu saldo atual de R${base.Saldo}\n";
        }
    }
}

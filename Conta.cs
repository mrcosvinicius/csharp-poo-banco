namespace Poo
{
    public class Conta : Cliente
    {
        public int NumConta { get; protected set; }
        public double Saldo { get; protected set; }
        public string Agencia { get; protected set; }

        public Conta(string nome, int idade, bool temFilhos, int numeroConta, double saldo, string agencia) : base(nome, idade, temFilhos)
        {
            NumConta = numeroConta;
            Saldo = saldo;
            Agencia = agencia;
        }
    }
}

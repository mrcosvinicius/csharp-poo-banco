namespace Poo
{
    public class Conta : Cliente
    {
        public int NumConta { get; set; }
        public double Saldo { get; set; }
        public string Agencia { get; set; }

        public Conta(string nome, int idade, bool temFilhos, int numeroConta, double saldo, string agencia) : base(nome, idade, temFilhos)
        {
            NumConta = numeroConta;
            Saldo = saldo;
            Agencia = agencia;
        }
    }
}

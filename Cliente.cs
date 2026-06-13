namespace Main
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool TemFilhos { get; set; }

        public Cliente(string nome, int idade, bool temFilhos)
        {
            Nome = nome;
            Idade = idade;
            TemFilhos = temFilhos;
        }
    }

}

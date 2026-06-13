using System;
namespace Main
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaVinicius = new ContaCorrente("Vinicius", 20, false, 101, 200, "001");
            contaVinicius.Sacar(12);
            Console.Write(contaVinicius.ToString());
        }
    }
}

using System;
namespace Poo
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaVinicius = new ContaCorrente("Vinicius", 20, false, 101, 200, "001");
            contaVinicius.sacar(12);
            Console.Write(contaVinicius.ToString());
        }
    }
}

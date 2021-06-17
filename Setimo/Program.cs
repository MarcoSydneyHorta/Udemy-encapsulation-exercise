using System;
using System.Globalization;

namespace Setimo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string havera = Console.ReadLine();
            if (havera == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                valor = 0;
            }
            Conta c = new Conta(conta, nome, valor);

            c.CriarConta(conta, nome, valor);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.retirada(valor);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(c);

        }
    }
}

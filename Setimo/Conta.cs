using System.Globalization;


namespace Setimo
{
    class Conta
    {
        public int Numero { get; private set; } // Auto Properties
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome) // Used when there is no initial deposit
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }
        public void CriarConta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;

        }
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void retirada(double saldo)
        {
            Saldo = Saldo - saldo - 5.00; // The bank charges an absurd fee of US$5.00 for each withdrawal!
        }

        public override string ToString() // Define the output string to use in console.writeline (c)
        {
            return
            "Conta: " + Numero + " , Titular: " + Nome + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}

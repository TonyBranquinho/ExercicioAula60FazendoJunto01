using ExercicioAula60FazendoJunto01;
using System;
using System.Globalization;

namespace MyApp // ExercicioAula60FazendoJunto01
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s / n) ? ");
            char teste = char.Parse(Console.ReadLine());

            if (teste == 's' || teste == 'S') {
                Console.Write("Digite o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CI);
                conta = new ContaBancaria(numeroConta, titularConta, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numeroConta, titularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);



        }
    }
}



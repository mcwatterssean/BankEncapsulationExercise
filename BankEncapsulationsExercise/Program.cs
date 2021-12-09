using System;

namespace BankEncapsulationsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            double amountToDepsoit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDepsoit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance,0:c}");

        }
    }
}

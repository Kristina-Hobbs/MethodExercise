using System;
using BankEncapsulationExercise;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How mch would you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Your balance is {account.GetBalance()}");
        }
    }
}



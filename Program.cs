using System;

namespace AbstractLAb5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank BankA = new BankA();
            Bank BankB = new BankB();
            Bank BankC = new BankC();

            Console.WriteLine($"Your Total Balance in BankA is : {BankA.getbalance()}$\n");
            Console.WriteLine($"Your Total Balance in BankB is : {BankB.getbalance()}$\n");
            Console.WriteLine($"Your Total Balance in BankC is : {BankC.getbalance()}$");
        }
    }
}

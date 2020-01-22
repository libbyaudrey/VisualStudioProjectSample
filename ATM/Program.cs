//Libby Snedaker
//October 13, 2019

using System;

namespace ATM
{ 
    class Program
    {
        //main method to run the user transactions
        static void Main(string[] args)
        {
            //three accounts/three account objects w/hardcoded values
            Account account1 = new Account(1001001001, 1234, 100.00);
            Account account2 = new Account(1001001002, 5678, 20.25);
            Account account3 = new Account(1001001003, 9010, 5.00);


            //account 1 ask for PIN
            Console.Write("Enter your PIN for account1: ");
            account1.pin = int.Parse(Console.ReadLine());

            //display account1 balance
            Console.WriteLine("Hello, your balance for account1 is " + account1.theBalance);

            //deposit money into account1
            Console.Write("Enter amount to deposit into account1 " + account1.aNumber + ": ");
            double myDeposit = double.Parse(Console.ReadLine());
            account1.Deposit(myDeposit);

            //withdraw money from account1
            Console.Write("Enter amount to withdraw from account1 " + account1.aNumber + ": ");
            double myWithdraw = double.Parse(Console.ReadLine());
            account1.Withdrawal(myWithdraw);

            //account 2 ask for PIN
            Console.Write("Enter your PIN for account2: ");
            account2.pin = int.Parse(Console.ReadLine());

            //display account2 balance
            Console.WriteLine("Hello, your balance for account2 is " + account2.theBalance);

            //deposit money into account2
            Console.Write("Enter amount to deposit into account2: " + account2.aNumber + ": ");
            myDeposit = double.Parse(Console.ReadLine());
            account2.Deposit(myDeposit);

            //withdraw money from account2
            Console.Write("Enter amount to withdraw from account2 " + account2.aNumber + ": ");
            myWithdraw = double.Parse(Console.ReadLine());
            account2.Withdrawal(myWithdraw);

            //account 3 ask for PIN
            Console.Write("Enter your PIN for account3: ");
            account3.pin = int.Parse(Console.ReadLine());

            //display account3 balance
            Console.WriteLine("Hello, your balance for account3 is " + account3.theBalance);

            //deposit money into account3
            Console.Write("Enter amount to deposit into account3 " + account3.aNumber + ": ");
            myDeposit = double.Parse(Console.ReadLine());
            account3.Deposit(myDeposit);

            //withdraw money from account3
            Console.Write("Enter amount to withdraw from account3 " + account3.aNumber + ": ");
            myWithdraw = double.Parse(Console.ReadLine());
            account3.Withdrawal(myWithdraw);

            //keeps program from ending automatically
            Console.ReadKey();
        }
    }
}

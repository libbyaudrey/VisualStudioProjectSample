//Libby Snedaker
//October 13, 2019

using System;
namespace ATM
{
    //new class for Account
    public class Account
    {
        //account object constructor
        public Account(int accountNumberIn, int PINin, double balanceIN)
        {
            aNumber = accountNumberIn;
            pin = PINin;
            theBalance = balanceIN;
        }

        //Account number property
        int accountNumber;
        public int aNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                //Account Number has to be 10 digits only
                if (value.ToString().Length == 10)
                {
                    accountNumber = value;
                }
                else
                {
                    Console.WriteLine("You must enter a 10 digit account number");
                }

            }
        }

        //PIN property
        int PIN;
        public int pin
        {
            get
            {
                return PIN;
            }

            set
            {
                //PIN is 4 digits only
                if (value.ToString().Length == 4)
                {

                    PIN = value;
                }
                else
                {
                    Console.WriteLine("You must enter a 4 digit PIN");
                }

            }
        }

        //Balance property
        public double balance;
        public double theBalance
        {
            get
            {
                return balance;
            }

            set
            {
                //Balance cannot be negative
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("You do not have enough money to withdraw that amount.");
                }

            }
        }

        //adds money to the balance
        public void Deposit(double myDeposit)
        {

            balance = balance + myDeposit;

            Console.WriteLine("Now your new balance is: " + balance);

        }

        //withdraws money from the balance
        public void Withdrawal(double myWithdrawal)
        {
            Console.WriteLine("There is a 4% fee to withdraw your money from account: " + accountNumber + "." + " Do you still want to withdraw it? (please enter 'yes' or 'no'.) ");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                if (balance - (myWithdrawal*1.04) >= 0)
                {
                    balance = balance - (myWithdrawal*1.04);
                    Console.WriteLine("Great, your new balance is: " + Math.Round(balance, 2));
                }
                else
                {
                    Console.WriteLine("You don't have enough money to make this withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Okay, that's fine, your balance remains: " + balance);
            }

        }
    }
}

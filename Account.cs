using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Account
    {
        //one private instance variable of type decimal to represent the account balance
        private decimal _balance;

        //constructor that recieve an initial balance and uses it to initialize the instance variable with public property
        public Account(decimal balance)
        {
            Balance = balance;
        }
        //The property should validate initial balance
        public decimal Balance
        {

            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        //Method credit should add an amount to the current balance
        public virtual void credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("credit amount must be greater than zero");
        }


        //Method Debit should withdraw money from the Account and ensure that the debit amount does not exceed the Account’s balance.
        //If it does, the balance should be left unchanged, and the method should display the message "Debit amount exceeded account balance.
        
        //Hints:Define Accounts Debit method so that it returns a bool indicating wether
        //money was withdraw
        public virtual bool Debit(decimal amount)
        {
            bool ok = true;
            if (Balance -amount>=0)
            {
                Balance -=amount;
                ok = true;

            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                ok = false;
            }
            return ok;
        }




      }      
    
    
    
 }

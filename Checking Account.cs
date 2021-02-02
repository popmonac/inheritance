using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    //CheckingAccount should inherit from base class Account and include a decimal instance 
    //variable that represents the fee charged per transaction.
    class Checking_Account : Account
    {
        private decimal _fee;
           
        //constructor should receive the initial balance, as well as a parameter indicating a fee amount.
            public Checking_Account (decimal balance, decimal fee): base(balance)
        {
            Fee = fee;
        }
        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Fee cannot be less than zero");
            }
        }
        // Class CheckingAccount should 
        //redefine methods Credit and Debit so that they subtract the fee from the account balance whenever either 
        //transaction is performed successfully.CheckingAccount’s versions of these methods should invoke 
        //the base-class Account version to perform the updates to an account balance.CheckingAccount’s Debit
        //method should charge a fee only if money is actually withdrawn(i.e., the debit amount does not exceed the account balance). [Hint: Define Account’s Debit method so that it returns a bool indicating whether
        //money was withdrawn.Then use the return value to determine whether a fee should be charged.]rride
        public override void credit(decimal amount)
        {
            base.credit(amount);
            Balance -= _fee;
        }
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }
    }
}

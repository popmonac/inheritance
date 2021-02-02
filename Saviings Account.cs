using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{

    //Derived class SavingsAccount should inherit the 
    //functionality of an Account, but also include a decimal instance variable indicating the interest rate
    //(percentage) assigned to the Account.
    class Saviings_Account:Account
    {
        private decimal _interestRate;
            //SavingsAccount’s constructor should receive the firstname, lastname, bvn, initial balance, 
            //as well as an initial value for the interest rate.
            public Saviings_Account(decimal balance,decimal interestRate) : base(balance)
        {
            InterestRate = InterestRate;
        }
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {

                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("interest rate must be greater than zero");
            }
        }
          



                //SavingsAccount should provide public method 
                //CalculateInterest that returns a decimal indicating the amount of interest earned by an account.
                //Method CalculateInterest should determine this amount by multiplying the interest rate by the account balance
                //[Note: SavingsAccount should inherit methods Credit and Debit without redefining them.]
                public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}

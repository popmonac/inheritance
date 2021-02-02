using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{

   // After defining the classes in this hierarchy, write an app that creates objects of each class and 
    //their methods.Add interest to the SavingsAccount object by first invoking its CalculateInterest method, 
    //then passing the returned interest amount to the object’s Credit method.
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalcredit = 0.0M;
            Saviings_Account sa = new Saviings_Account (1000.25M, 0.1M);

            Console.WriteLine("Beginning balance is {0:c",sa.Balance);
            totalcredit = sa.CalculateInterest();
            Console.WriteLine("total Interest:{0:c}",totalcredit);
            sa.credit(totalcredit);//adds credit to balance
            Console.WriteLine("Ending balance is:{0:c}",sa.Balance);
            Console.WriteLine();

            // Checking_Account has a fee for every transaction
            Checking_Account ca = new Checking_Account(1000.25M, 5.50M);
            Console.WriteLine("Beginning balance is {0:c}", ca.Balance);
            ca.credit(55.25M);//this is adds to the account (-fee)
            ca.Debit(925.55M);//this is taking from the account (-fee)
            Console.WriteLine("Ending balance is {0:c},ca.Balance");

            Console.ReadLine();
        }
    }
}

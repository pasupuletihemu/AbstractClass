using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Account
    {
        protected int AccountNo;
        protected string AccountName;
        protected double Amount;
        public Account(int aNo, string aName, double amt)
        {
            AccountNo = aNo;
            AccountName = aName;
            Amount = amt;
        }
        public void ShowAccount()
        {
            Console.WriteLine(AccountNo + "  " + AccountName + "   " + Amount);
        }
        public void Deposit(double amt)
        {
            Console.WriteLine("Before :" + Amount);
            Amount = Amount + amt;
            Console.WriteLine("After Deposit :" + Amount);
        }
        public abstract void WithDraw(double amt);
    }
}

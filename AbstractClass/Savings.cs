using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Savings:Account
    {
        public Savings(int accno, string aname, double amt):base(accno, aname, amt)
        {
            //AccountNo = accno;
            //AccountName =AssemblyName;
            //Amount =amt;
        }
        public override void WithDraw(double amt)
        {
            if((Amount-amt)<300)
            {
                Console.WriteLine("min balance 300 is required");
            }
            else
            {
                Amount = Amount - amt;
                Console.WriteLine("Amount After WithDraw :" + Amount);
            }
        }
    }
}

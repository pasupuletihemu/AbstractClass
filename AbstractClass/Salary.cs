using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Salary:Account
    {
        public Salary(int accno,string aname,double amt):base(accno,aname,amt)
        {

        }
        public override void WithDraw(double amt)
        {
            if((Amount-amt)<0)
            {
                Console.WriteLine("Negative Balance Is Not Allowed");
            }
            else
            {
                Amount = Amount - amt;
                Console.WriteLine("Amount after WithDraw :" + Amount);
            }
        }
    }
}
